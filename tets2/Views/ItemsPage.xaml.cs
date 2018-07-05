using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using tets2.Models;
using tets2.Views;
using tets2.ViewModels;

namespace tets2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        string[] list = new string[] { "Kotletki", "Pureshka", "Kompot", "Makaroshki", "Belyashi", "Grechka", "Ovsyanka", "Solyanka", "Teftely", "Borsh", "Blinchiki", "Pelmeny", "Kartoshaka" };
        public ItemsPage()
        {
            InitializeComponent();
            Fin.Clicked += ToNewPage;
            meals.ItemsSource = new string[] {"Kotletki", "Pureshka", "Kompot", "Makaroshki", "Belyashi", "Grechka", "Ovsyanka", "Solyanka", "Teftely", "Borsh", "Blinchiki", "Pelmeny", "Kartoshaka"};
        }
        private void MealTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                for (int i = 0; i < 13; i++)
                {
                    if (e.Item.ToString() == list[i])
                    {
                        PropertyHelper.SetPropertyValue(PropertyEnum.DId, i + 1);
                        Navigation.PushAsync(new TestPage());
                    }
                }
            }               
        }
        private void SE_TextChanged(object sender, System.EventArgs e)
        {
            List<string> sr = new List<string>();
            for (int i = 0; i < 13; i++)
            {
                if (SE.Text.Length <= list[i].Length && SE.Text.ToLower() == list[i].Substring(0, SE.Text.Length).ToLower())
                {
                    sr.Add(list[i]);
                }
            }
            if (sr.Count > 0)
            {
                meals.ItemsSource = sr;
            }
        }
        private async void ToNewPage(object sender, System.EventArgs e)
        {
            
                await Navigation.PushAsync(new Page());
        }
    }
}