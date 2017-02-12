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
    public class MapActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MapActivity);
            WebView web_view = FindViewById<WebView>(Resource.Id.webView1);
            web_view.Settings.JavaScriptEnabled = true;
            web_view.LoadUrl("https://www.google.com/maps/d/embed?mid=1EsfRYRTl0h4YANfmb0MGKA0eKvs");
        }
    }
}