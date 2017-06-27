using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiary.Helper;
using TravelDiary.Pages;
using TravelDiary.ViewModels;
using Xamarin.Forms;
using static TravelDiary.Helper.CarouselLayout;

namespace TravelDiary
{
    public partial class AddBlogPage : ContentPage
    {
        public AddBlogPage()
        {
            InitializeComponent();

            BindingContext = new SwitcherPageViewModel();
            var pagesCarousel = Carousel.CreatePagesCarousel();
            var dots = Carousel.CreatePagerIndicatorContainer();
            cLayout.Children.Add(pagesCarousel,
                        Constraint.RelativeToParent((parent) => { return parent.X; }),
                        Constraint.RelativeToParent((parent) => { return parent.Y; }),
                        Constraint.RelativeToParent((parent) => { return parent.Width; }),
                        Constraint.Constant(220)
                    );
            cLayout.Children.Add(dots,
                        Constraint.Constant(0),
                        Constraint.RelativeToView(pagesCarousel,
                            (parent, sibling) => { return sibling.Height - 18; }),
                        Constraint.RelativeToParent(parent => parent.Width),
                        Constraint.Constant(18)
                    );

            var addImage = new Image();
            addImage.Source = "add_icon.png";
            cLayout.Children.Add(addImage,
                        Constraint.RelativeToView(pagesCarousel,
                            (parent, sibling) => { return sibling.Width - 60; }),
                      Constraint.RelativeToView(pagesCarousel,
                            (parent, sibling) => { return sibling.Height - 60; }),
                        Constraint.Constant(40),
                        Constraint.Constant(40)
                    );
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnTapGestureRecognizerTapped;
            addImage.GestureRecognizers.Add(tapGestureRecognizer);

        }
        async void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            try
            {


                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                    return;
                }
                var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium
                });

                if (file == null)
                    return;
            }
            catch (Exception ex)
            {

            }
            //AddImage.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = file.GetStream();
            //    file.Dispose();
            //    return stream;
            //});
        }
    }

    public class SpacingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var items = value as IEnumerable<HomeViewModel>;

            var collection = new ColumnDefinitionCollection();
            foreach (var item in items)
            {
                collection.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            }
            return collection;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
