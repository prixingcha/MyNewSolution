using Android.App;
using Android.OS;

namespace TestingCustomActionBar
{
    [Activity(Label = "TestingCustomActionBar", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/CustomActionBarTheme")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //ActionBar.SetDisplayShowHomeEnabled(false);
            //ActionBar.SetDisplayShowTitleEnabled(false);
            ActionBar.SetCustomView(Resource.Layout.MyMenu);
            ActionBar.SetDisplayShowCustomEnabled(true);
            SetContentView(Resource.Layout.Main);
        }
    }
}

