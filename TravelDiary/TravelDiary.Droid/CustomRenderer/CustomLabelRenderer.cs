using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using TravelDiary.Droid.CustomRenderer;
using TravelDiary.Control;

[assembly: ExportRenderer(typeof(TDLabel), typeof(CustomLabelRenderer))]
namespace TravelDiary.Droid.CustomRenderer
{
 public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var label = (TDLabel)e.NewElement;
                if(label!=null)
                this.Control.SetLineSpacing(1f, (float)label.LineSpacing);

                this.UpdateLayout();
            }
        }
    }
}