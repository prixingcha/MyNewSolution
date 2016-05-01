
using Android.App;
using Android.OS;
using Android.Widget;
using System.Collections.Generic;

namespace FInal_project
{
    [Activity(Label = "DetailListViewActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class DetailListViewActivity : Activity
    {

        private List<Person> mItems;
        private ListView myListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DetailListView);
            mItems = new List<Person>();

            mItems.Add(new Person { FirstName = "Pratik", Gender = "Male", Age = 30, LastName = "Singh" });
            mItems.Add(new Person { FirstName = "BOB", Gender = "Male", Age = 33, LastName = "Scott" });
            mItems.Add(new Person { FirstName = "Tom", Gender = "Female", Age = 52, LastName = "Roth" });
            mItems.Add(new Person { FirstName = "Jim", Gender = "Female", Age = 100, LastName = "Mandel" });
            myListView = FindViewById<ListView>(Resource.Id.myListView);


            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);
            //string indexerTest = adapter.mItems[1];
            myListView.Adapter = adapter;
        }
    }
}