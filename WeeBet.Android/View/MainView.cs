﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using WeeBet.Core.ViewModels;

namespace WeeBet.Android.View
{
     [Activity]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.main_view);
        }
    }
}