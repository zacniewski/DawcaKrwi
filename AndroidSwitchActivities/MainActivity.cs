using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace AndroidSwitchActivities
{
    [Activity(MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo.NoActionBar.Fullscreen")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //var edtName = FindViewById<EditText>(Resource.Id.edtName);
            //var edtEmail = FindViewById<EditText>(Resource.Id.edtEmail);
            var btnSend = FindViewById<Button>(Resource.Id.btnSend);
            var btnSign = FindViewById<Button>(Resource.Id.btnSignUp);
            btnSend.Click += (s, e) => {
                Intent nextActivity = new Intent(this, typeof(RecvActivity));
                StartActivity(nextActivity);
            };
            btnSign.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(RegisterActivity));
                StartActivity(nextActivity);
            };
        }
    }
}