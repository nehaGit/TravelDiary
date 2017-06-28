using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiary.Models;
using Xamarin.Forms;

namespace TravelDiary.ViewModels
{
 public  class TimelineViewModel : BaseViewModel
    {

        private List<Blog> _blogList { get; set; }

        public List<Blog> BlogList;
        public TimelineViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _blogList = new List<Blog>();
            #region Add dummy Data
            _blogList.Add(new Blog() { Title = "The Heaven lies here", Description = "sbfiafhoai a ufioas fi saffc hoiasd siadh ", Rate = "5", CreatedDate = DateTime.Now, Image = "sand.jpg", Place = "Goa" });
            _blogList.Add(new Blog() { Title = "Ooty : The nature", Description = "sndflkcsa hfeiaesf awpoif uwaspd siadh ", Rate = "5", CreatedDate = DateTime.Now, Image = "travel.jpg", Place = "Ooty" });
            _blogList.Add(new Blog() { Title = "Kerala : ", Description = "sbdshfdjsd sedifh siisdhf chd asiasd siadh ", Rate = "5", CreatedDate = DateTime.Now, Image = "sea.jpg", Place = "Kerala" });
            _blogList.Add(new Blog() { Title = "Tnklcjndskcnsds", Description = "sbfiaawJDSHQWIUD WQD WOIAD  aiwof  ", Rate = "5", CreatedDate = DateTime.Now, Image = "sand.jpg", Place = "Koorg" });
            #endregion
        }
    }
}
