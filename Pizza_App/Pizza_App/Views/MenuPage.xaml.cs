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
                    ImageSource1 = "GardenVeggie.jpg",
                    ImageSource2 = "Supreme_pizza.jpg"
                },
                new CardItem
                {
                    ImageSource1 = "spicy_veg.jpg",
                    ImageSource2 = "prosciutto_pizza.jpg"
                }

            };

            Carousel.ItemsSource = cardData;
        }

        private async void DescriptionPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DescriptionPage());
        }

    }
    public class CardItem
    {
        public string ImageSource1 { get; set; }
        public string ImageSource2 { get; set; }
    }
}