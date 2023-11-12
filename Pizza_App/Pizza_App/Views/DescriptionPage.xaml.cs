using Pizza_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizza_App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DescriptionPage : ContentPage
	{
        public DescriptionPage ()
		{
			InitializeComponent ();
            BindingContext = new DescriptionPageViewModel();
        }

        
    }
}