
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
using E85Buddy.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace E85Buddy.Droid.Views
{
    [Activity(Label = "E85CalcView", MainLauncher = true)]
    public class E85CalcView : MvxActivity<E85CalcViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.E85CalcView);
        }
    }
}
