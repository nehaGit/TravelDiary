using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TravelDiary.ViewModels
{
    class SignupViewModel : BaseViewModel
    {
        ICommand logintapCommand;

        public SignupViewModel(INavigation navigation)
        {
            Navigation = navigation;
            logintapCommand = new Command(OnTapped);
        }

        #region Methods

        #region Commands

        public ICommand LogintapCommand
        {
            get { return logintapCommand; }
        }
        void OnTapped()
        {
            Navigation.PopModalAsync();
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