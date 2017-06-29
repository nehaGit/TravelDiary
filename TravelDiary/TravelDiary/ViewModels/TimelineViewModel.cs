using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiary.Models;
using Xamarin.Forms;

namespace TravelDiary
{
 public class TimelineViewModel : BaseViewModel
    {

        private ObservableCollection<Blog> _blogList;

        public ObservableCollection<Blog> BlogList
        {
            get { return _blogList; }
            set { _blogList = SetBlogList(); OnPropertyChanged(); }
        }
        public TimelineViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

    public ObservableCollection<Blog> SetBlogList()
        {
            var blogList = new ObservableCollection<Blog>();
            #region Add dummy Data
            blogList.Add(new Blog() { Title = "The Heaven lies here", Description = "sbfiafhoai a ufioas fi saffc hoiasd siadh ", Rate = "5", CreatedDate = DateTime.Now, Image = "sand.jpg", Place = "Goa" });
            blogList.Add(new Blog() { Title = "Ooty : The nature", Description = "sndflkcsa hfeiaesf awpoif uwaspd siadh ", Rate = "5", CreatedDate = DateTime.Now, Image = "travel.jpg", Place = "Ooty" });
            blogList.Add(new Blog() { Title = "Kerala : ", Description = "sbdshfdjsd sedifh siisdhf chd asiasd siadh ", Rate = "5", CreatedDate = DateTime.Now, Image = "sea.jpg", Place = "Kerala" });
            blogList.Add(new Blog() { Title = "Tnklcjndskcnsds", Description = "sbfiaawJDSHQWIUD WQD WOIAD  aiwof  ", Rate = "5", CreatedDate = DateTime.Now, Image = "sand.jpg", Place = "Koorg" });
            #endregion
            return blogList;
        }

        public override void OnDisappear()
        {
            BlogList = null;
        }

        public override void OnAppear()
        {
            base.OnAppear();
            BlogList = new ObservableCollection<Blog>();
        }

    }
}
