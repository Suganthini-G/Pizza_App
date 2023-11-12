using Android.Content.Res;
using Pizza_App.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pizza_App.ViewModels
{
    public class LoginPageViewModel : BindableObject
    {
        public ICommand MenuPageCommand { get; }

        public LoginPageViewModel()
        {
            MenuPageCommand = new Command(MenuPage);
        }
        private async void MenuPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MenuPage());
        }

    }
}
