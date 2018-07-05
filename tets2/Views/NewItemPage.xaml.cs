using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using tets2.Models;

namespace tets2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        bool check = false;
        string[] list = new string[] { "Pelmennaya u Goshi", "Stolovaya Soblazn" };
        int Rest_Id = 1;
        public NewItemPage()
        {
            InitializeComponent();
            Fin.Clicked += ToNewPage;
            Restaurants.ItemsSource = list;
            PropertyHelper.SetPropertyValue(PropertyEnum.IdProperty, Rest_Id);
        }
        private void RestSelected(object sender, SelectedItemChangedEventArgs e)
        {
            check = true;
            for (int i = 0; i < 2; i++)
            {

                if (e.SelectedItem != null)
                {
                    if (e.SelectedItem.ToString() == list[i])
                    {

                    }
                }
            }
        }
        private async void ToNewPage(object sender, System.EventArgs e)
        {
            if (check == true)
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}