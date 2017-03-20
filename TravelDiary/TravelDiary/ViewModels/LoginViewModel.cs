using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TravelDiary.ViewModels
{
  public class LoginViewModel : BaseViewModel
    {
        ICommand signuptapCommand;

        public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;
            signuptapCommand = new Command(OnTapped);
        }

        #region Methods

        #region Commands

        public ICommand SignuptapCommand
        {
            get { return signuptapCommand; }
        }
        void OnTapped()
        {
            Navigation.PushModalAsync(new SignupPage());
        }
        public ICommand OnTapDetailCommand { get { return new Command(async () => await RunSafe(OnTapDetail)); } }
        #endregion

        void OnTapDetail()
        {
            Navigation.PushAsync(new SignupPage());
        }

        public override void OnDisappear()
        {
        }

        public override void OnAppear()
        {
            base.OnAppear();
            //IntervieweeDetail = new Interviewee();
        }

        #endregion
    }
}