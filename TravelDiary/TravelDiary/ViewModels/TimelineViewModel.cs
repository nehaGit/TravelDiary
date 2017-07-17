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
            _blogList = SetBlogList();
        }

        public ObservableCollection<Blog> SetBlogList()
        {
            var blogList = new ObservableCollection<Blog>();
            #region Add dummy Data
            blogList.Add(new Blog() { Title = "The Heaven lies here", Description = "Living in Charleston has taught me much more than I ever imagined and has provided me with endless opportunities. I’ve met so many wonderful friends and a great boyfriend, gotten awesome jobs and research positions, began yoga, and discovered an absolutely perfect college major.", Rate = "5", CreatedDate = DateTime.Now, Image = "sand.jpg", Place = "Goa" });
            blogList.Add(new Blog() { Title = "Coorg : The nature", Description = "Coorg, officially known as Kodagu, is the most affluent hill station in Karnataka. It is well known for its breathtakingly exotic scenery and lush greenery. Forest covered hills, spice and coffee plantations only add to the landscape. Madikeri is the region's centre point with all transportation for getting around starting from here.", Rate = "5", CreatedDate = DateTime.Now, Image = "coorg_road.PNG", Place = "Ooty" });
            blogList.Add(new Blog() { Title = "Kerala : ", Description = "sbdshfdjsd sedifh siisdhf chd asiasd siadh.sdlkhgepisdf sp9uf soidjvldkxjvadpofppj apomsm poosfi aopsu  ", Rate = "5", CreatedDate = DateTime.Now, Image = "sea.jpg", Place = "Kerala" });
            blogList.Add(new Blog() { Title = "Tnklcjndskcnsds", Description = "sbfiaawJDSHQWIUD WQD WOIAD  aiwof. ufioas fi saffc hoiasd siadh sajfpas fus9u fs9eduf 9sncskjzncb snx skjddfgqw8f . ufioas fi saffc hoiasd siadh  ", Rate = "5", CreatedDate = DateTime.Now, Image = "sand.jpg", Place = "Koorg" });
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
