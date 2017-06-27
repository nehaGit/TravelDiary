using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiary.Models;
using TravelDiary.Pages;
using Xamarin.Forms;

namespace TravelDiary
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Feeds",
                IconSource = "home.png",
                TargetType = typeof(HomePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Timeline",
                IconSource = "timeline.png",
                TargetType = typeof(HomePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Write Story",
                IconSource = "write.png",
                TargetType = typeof(AddBlogPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "My Account",
                IconSource = "account.png",
                TargetType = typeof(AccountPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "About us",
                IconSource = "user_white.png",
                TargetType = typeof(HomePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Logout",
                IconSource = "logout.png",
                TargetType = typeof(HomePage)
            });
            listView.ItemsSource = masterPageItems;
        }
    }
}