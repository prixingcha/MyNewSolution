
using Android.App;
using Android.OS;

namespace FInal_project
{
    [Activity(Label = "LandingPageActivity")]
    public class LandingPageActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);



            SetContentView(Resource.Layout.LandingPage);

            // Get our button from the layout resource,
            // and attach an event to it

            //ActionBar.SetCustomView(Resource.Layout.MyMenu);
            //ActionBar.SetDisplayShowCustomEnabled(true);

            // Create your application here
        }
    }
}