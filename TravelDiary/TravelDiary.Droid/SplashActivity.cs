using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;

namespace TravelDiary.Droid
{
    [Activity(Label = "TravelDiary", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            System.Threading.Thread.Sleep(2000); //Let's wait awhile...
            this.StartActivity(typeof(MainActivity));
        }
    }
}