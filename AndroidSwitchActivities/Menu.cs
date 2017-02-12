
using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Content;
using Android.Widget;

namespace AndroidSwitchActivities
{
    [Activity(Theme = "@android:style/Theme.Holo.NoActionBar.Fullscreen")]
    public class Menu : AppCompatActivity
    {
        DrawerLayout drawerLayout;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetTheme(Resource.Style.MyTheme);
            SetContentView(Resource.Layout.MenuActivity);
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            // Init toolbar
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

            // Attach item selected handler to navigation view
            var navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;

            // Create ActionBarDrawerToggle button and add it to the toolbar
            var drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, Resource.String.openDrawer, Resource.String.closeDrawer);
            drawerLayout.SetDrawerListener(drawerToggle);
            drawerToggle.SyncState();

        }
        void NavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
            switch (e.MenuItem.ItemId)
            {
                case (Resource.Id.nav_home):
                    // React on 'Home' selection
                    Intent homeActivity = new Intent(this, typeof(Menu));
                    StartActivity(homeActivity);
                    break;
                case (Resource.Id.nav_messages):
                    // React on 'Messages' selection
                    Intent bloodActivity = new Intent(this, typeof(BloodActivity));
                    StartActivity(bloodActivity);
                    break;
                case (Resource.Id.nav_friends):
                    // React on 'Friends' selection
                    Intent accountActivity = new Intent(this, typeof(AccountActivity));
                    StartActivity(accountActivity);
                    break;
                case (Resource.Id.nav_map):
                    // React on 'Discussion' selection
                    Intent mapActivity = new Intent(this, typeof(MapActivity));
                    StartActivity(mapActivity);
                    break;
                case (Resource.Id.nav_donation):
                    // React on 'Discussion' selection
                    Intent przeActivity = new Intent(this, typeof(PrzelicznikActivity));
                    StartActivity(przeActivity);
                    break;
                case (Resource.Id.nav_logout):
                    // React on 'Discussion' selection
                    Intent mainActivity = new Intent(this, typeof(MainActivity));
                    StartActivity(mainActivity);
                    Toast.MakeText(this, "Zosta³eœ wylogowany", ToastLength.Short).Show();
                    break;
            }

            // Close drawer
            drawerLayout.CloseDrawers();
        }
    }
}