using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;

using AndroidX.AppCompat.App;

namespace XA_443_D1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var name = FindViewById<EditText>(Resource.Id.name);
            var ok = FindViewById<Button>(Resource.Id.ok);
            var clear = FindViewById<Button>(Resource.Id.clear);
            var show = FindViewById<TextView>(Resource.Id.show);
            Button go = FindViewById<Button>(Resource.Id.go);

            ok.Click += delegate
            {
                show.Text = name.Text;
            };

            clear.Click += delegate
            {
                name.Text = "";
                show.Text = "Show";
            };

            go.Click += delegate {
                Intent i = new Intent(this, typeof(SecondActivity));
                i.PutExtra("name", name.Text);
                StartActivity(i);

            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}