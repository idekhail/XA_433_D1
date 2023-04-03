using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XA_443_D1
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here

            SetContentView(Resource.Layout.activity_second);

            TextView show = FindViewById<TextView>(Resource.Id.show);
            Button back = FindViewById<Button>(Resource.Id.back);
            Button close = FindViewById<Button>(Resource.Id.close);

            show.Text = Intent.GetStringExtra("name");

            back.Click += delegate { 
                    Intent i = new Intent(this, typeof(MainActivity));
                    StartActivity(i);
            };

            close.Click += delegate { System.Environment.Exit(0); };

        }
    }
}