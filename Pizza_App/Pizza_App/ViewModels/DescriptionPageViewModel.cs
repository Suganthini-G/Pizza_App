using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pizza_App.ViewModels
{
    class DescriptionPageViewModel : BindableObject
    {
        private int count = 0;
        public int Count
        {
            get { return count; }
            set
            {
                if (count != value)
                {
                    count = value;
                    OnPropertyChanged(nameof(Count));
                }
            }
        }
        public ICommand IncreaseCommand { get; }
        public ICommand DecreaseCommand { get; }

        public DescriptionPageViewModel()
        {
            IncreaseCommand = new Command(IncreaseButton_Clicked);
            DecreaseCommand = new Command(DecreaseButton_Clicked);
        }
        private void IncreaseButton_Clicked()
        {
            Count++;
        }
        private void DecreaseButton_Clicked()
        {
            Count--;
        }

    }
}
