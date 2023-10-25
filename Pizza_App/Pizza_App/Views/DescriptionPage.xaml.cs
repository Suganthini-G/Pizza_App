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
        private int count = 0;
        public DescriptionPage ()
		{
			InitializeComponent ();
		}

        private void IncreaseButton_Clicked(object sender, EventArgs e)
        {
            count++;
            UpdateCountLabel();
        }

        private void DecreaseButton_Clicked(object sender, EventArgs e)
        {
            count--;
            UpdateCountLabel();
        }

        private void UpdateCountLabel()
        {
            countLabel.Text = count.ToString();
        }
    }
}