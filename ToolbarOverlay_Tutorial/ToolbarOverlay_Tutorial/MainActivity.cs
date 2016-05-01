using Android.App;
using Android.OS;
using Android.Support.V7.App;
using SupportToolBar = Android.Support.V7.Widget.Toolbar;

namespace ToolbarOverlay_Tutorial
{
    [Activity(Label = "ToolbarOverlay_Tutorial", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.MyTheme")]
    public class MainActivity : ActionBarActivity
    {
        private SupportToolBar mToolBar;
        protected override void OnCreate(Bundle bundle)
        {
            try
            {
                base.OnCreate(bundle);
                SetContentView(Resource.Layout.Main);
                mToolBar.FindViewById<SupportToolBar>(Resource.Id.toolbar);

                SetSupportActionBar(mToolBar);
            }
            catch (System.Exception ex)
            {
                string temp = "temp";
            }


        }
    }
}

