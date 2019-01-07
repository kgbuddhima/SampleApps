
using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.OS;
using CarouselView.FormsPlugin.Android;
using FFImageLoading.Forms.Droid;
using System.Reflection;

namespace App1.Droid
{
    [Activity(Label = "App1", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            CarouselViewRenderer.Init();
            CachedImageRenderer.Init(true);

            var cv = typeof(Xamarin.Forms.CarouselView);
            var assembly = Assembly.Load(cv.FullName);
            Plugin.Iconize.Iconize.Init(ToolbarResource, TabLayoutResource);

            LoadApplication(new App());
        }
    }
}