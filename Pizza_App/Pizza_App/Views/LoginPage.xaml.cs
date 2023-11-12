using Pizza_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Pizza_App.Views
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
            
        }
       

    }
}