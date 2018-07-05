using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;

namespace tets2.Views
{
    public partial class P1 : ContentPage
    {
        public ObservableCollection<FoodItem> FoodItems { get; set; }

        public P1()
        {
            BindingContext = this;

            InitializeComponent();
            FoodItems = new ObservableCollection<FoodItem>
            {
                new FoodItem
                {
                    FoodName = "борщ",
                    DetailName = "со сметаной"
                },
                new FoodItem
                {
                    FoodName = "стейк",
                    DetailName = "вел дан"
                },
                new FoodItem
                {
                    FoodName = "чай",
                    DetailName = "чёрный"
                },
                new FoodItem
                {
                    FoodName = "стейк",
                    DetailName = "мидиум рээр"
                },
                new FoodItem
                {
                    FoodName = "чай",
                    DetailName = "зелёный"
                }
            };
            OnPropertyChanged(nameof(FoodItems));
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (sender is ListView list)
            {
                if (list.SelectedItem is FoodItem item)
                {
                    FoodItems = new ObservableCollection<FoodItem>(FoodItems.Where(x => x != item).ToList());

                    OnPropertyChanged(nameof(FoodItems));

                    await Navigation.PushAsync(new P2(item));
                }
                list.SelectedItem = null;
            }
        }
    }

    public class FoodItem
    {
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public int RestId { get; set; }
        public int VaiterId { get; set; }
        public int TableId { get; set; }
        public string FoodName { get; set; }
        public string DetailName { get; set; }
        public DateTime Time { get; set; }
        //ООП => Инкапсуляция Полиморфизм Наследование
    }
}
