using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelDiary.Pages
{
    public class HomeView : ContentView
    {
        public HomeView()
        {
            BackgroundColor = Color.White;

            var label = new Image
            {
               HeightRequest=220,
               Aspect=Aspect.Fill
            };

            label.SetBinding(Image.SourceProperty, "ImageSource");

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    label
                }
            };
        }
    }
}