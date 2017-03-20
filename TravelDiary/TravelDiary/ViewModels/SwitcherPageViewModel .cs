using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiary.Pages;
using Xamarin.Forms;

namespace TravelDiary.ViewModels
{
    class SwitcherPageViewModel : BaseViewModel
    {
        public SwitcherPageViewModel()
        {
            Pages = new List<HomeViewModel>() {
                new HomeViewModel { ImageSource = "travel.jpg" },
                new HomeViewModel { ImageSource = "sand.jpg" },
                new HomeViewModel {  ImageSource = "sea.jpg" },
                new HomeViewModel { ImageSource = "sand.jpg" },
            };

            CurrentPage = Pages.First();
        }

        IEnumerable<HomeViewModel> _pages;
        public IEnumerable<HomeViewModel> Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                SetObservableProperty(ref _pages, value);
                CurrentPage = Pages.FirstOrDefault();
            }
        }

        HomeViewModel _currentPage;
        public HomeViewModel CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                SetObservableProperty(ref _currentPage, value);
            }
        }
    }

    public class HomeViewModel : BaseViewModel, ITabProvider
    {
        public HomeViewModel() { }

        public string Title { get; set; }
        public Color Background { get; set; }
        public string ImageSource { get; set; }
    }
}
