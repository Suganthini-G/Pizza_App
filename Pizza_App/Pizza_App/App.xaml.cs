using Android.Content.Res;
using Pizza_App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizza_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
