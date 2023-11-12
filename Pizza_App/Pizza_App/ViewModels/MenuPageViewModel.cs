using Pizza_App.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pizza_App.ViewModels
{
    class MenuPageViewModel : BindableObject
    {
        public List<CardItem> CardData { get; }

        public ICommand DescriptionPageCommand { get; }
        public MenuPageViewModel()
        {
            CardData = new List<CardItem>
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

            DescriptionPageCommand = new Command(DescriptionPage);
        }

        private async void DescriptionPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DescriptionPage());
        }
    }

    public class CardItem
    {
        public string ImageSource1 { get; set; }
        public string ImageSource2 { get; set; }
    }
}
