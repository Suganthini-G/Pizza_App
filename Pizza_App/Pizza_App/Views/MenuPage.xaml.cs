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
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            var cardData = new List<CardItem>
            {
                new CardItem
                {
                    ImageSource = "GardenVeggie.jpg"
                },
                new CardItem
                {
                    ImageSource = "pizza_sec.jpg"
                },
                new CardItem
                {
                    ImageSource = "GardenVeggie.jpg"
                }

            };

            TheCarousel.ItemsSource = cardData;
        }

        private async void DescriptionPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DescriptionPage());
        }

    }
    public class CardItem
    {
        public string ImageSource { get; set; }
       
    }
}