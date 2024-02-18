using Pizza_App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            LoadData();
        }

        private ObservableCollection<PizzaItem> _pizzaItems;
        public ObservableCollection<PizzaItem> PizzaItems
        {
            get { return _pizzaItems; }
            set
            {
                if (_pizzaItems != value)
                {
                    _pizzaItems = value;
                    OnPropertyChanged();
                }
            }
        }

        private void LoadData()
        {
            PizzaItems = new ObservableCollection<PizzaItem>
            {
                new PizzaItem { Name = "Margherita", Price = "$10.99", ImageSource = "Pizza001.png" },
                new PizzaItem { Name = "Margherita", Price = "$10.99", ImageSource = "Pizza001.png" },
                new PizzaItem { Name = "Margherita", Price = "$10.99", ImageSource = "Pizza001.png" },
                new PizzaItem { Name = "Margherita", Price = "$10.99", ImageSource = "Pizza001.png" },
            };
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
    public class PizzaItem
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string ImageSource { get; set; }
    }
}
