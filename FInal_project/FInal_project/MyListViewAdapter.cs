using Android.Content;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace FInal_project
{
    class MyListViewAdapter : BaseAdapter<Person>
    {
        public List<Person> mItems;
        public Context mContext;
        public override Person this[int position]
        {
            get
            {
                return mItems[position];
            }
        }

        public MyListViewAdapter(Context context, List<Person> items)
        {
            mItems = items;
            mContext = context;

        }

        public override int Count
        {
            get
            {
                return mItems.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.listView_Row, null, false);
            }

            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.txtLastName);
            TextView txtAge = row.FindViewById<TextView>(Resource.Id.txtAge);
            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);

            txtName.Text = mItems[position].FirstName;
            txtLastName.Text = mItems[position].LastName;
            txtAge.Text = mItems[position].Age.ToString();
            txtGender.Text = mItems[position].Gender;

            return row;
        }
    }
}