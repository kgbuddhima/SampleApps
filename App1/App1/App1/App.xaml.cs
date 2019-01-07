using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeSolidModule())
                .With(new Plugin.Iconize.Fonts.FontAwesomeRegularModule())
                .With(new Plugin.Iconize.Fonts.FontAwesomeBrandsModule());
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
