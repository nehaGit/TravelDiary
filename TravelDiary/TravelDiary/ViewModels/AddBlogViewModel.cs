using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TravelDiary
{
    class AddBlogViewModel : BaseViewModel
    {
        ICommand savetapCommand;

        public AddBlogViewModel(INavigation navigation)
        {
            Navigation = navigation;
            savetapCommand = new Command(OnTapped);
        }

        #region Methods

        #region Commands

        public ICommand SignuptapCommand
        {
            get { return savetapCommand; }
        }
        void OnTapped()
        {
            Navigation.PushModalAsync(new HomePage());
        }
        #endregion

        public override void OnAppear()
        {
            base.OnAppear();
            //IntervieweeDetail = new Interviewee();
        }

        #endregion
    }
}