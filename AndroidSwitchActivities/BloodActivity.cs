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
using Android.Webkit;

namespace AndroidSwitchActivities
{
    [Activity]
    public class BloodActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.bloodActivity);
            WebView web_view = FindViewById<WebView>(Resource.Id.bloodWebView);
            web_view.SetWebViewClient(new WebViewClient());
            web_view.Settings.JavaScriptEnabled = true;
            web_view.LoadUrl("http://krew.info/zapasy/");
        }
    }
}