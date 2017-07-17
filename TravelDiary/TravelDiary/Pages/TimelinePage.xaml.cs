using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiary.Models;
using Xamarin.Forms;

namespace TravelDiary
{
    public partial class TimelinePage : BaseContentPage
    {
        public TimelinePage()
        {
            InitializeComponent();
            this.Title = "TimeLine";
            this.BindingContext = new TimelineViewModel(this.Navigation);
            bloglistView.ItemSelected += OnItemSelected;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new TimelineViewModel(this.Navigation);
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Blog;
            this.Navigation.PushAsync(new FeedDetailPage(), true);
        }
    }
}
