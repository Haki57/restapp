using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;

namespace test03.Views
{
    public partial class page01 : ContentPage
    {
        public ObservableCollection<FoodItem> FoodItems { get; set; }

        public page01()
        {
            BindingContext = this;

            InitializeComponent();
            FoodItems = new ObservableCollection<FoodItem>
            {
                new FoodItem
                {
                    FoodName = "Name1",
                    DetailName = "Комментарий"
                },
                new FoodItem
                {
                    FoodName = "Name2",
                    DetailName = "Комментарий"
                },
                new FoodItem
                {
                    FoodName = "Name3",
                    DetailName = "Комментарий"
                },
                new FoodItem
                {
                    FoodName = "Name4",
                    DetailName = "Комментарий"
                },
                new FoodItem
                {
                    FoodName = "Name5",
                    DetailName = "Комментарий"
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

                    await Navigation.PushAsync(new page02(item));
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
