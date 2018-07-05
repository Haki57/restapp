using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tets2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        bool[] roles = new bool[] { true, false };
        bool role = true, check = false;
        string[] list = new string[] {"Georgiy Pishkin", "Valeriy Teftelin"};
        int waiter_id = 2;
        public MainPage()
        {
            InitializeComponent();
            Fin.Clicked += ToNewPage;
            people.ItemsSource = list;
            PropertyHelper.SetPropertyValue(PropertyEnum.WId, waiter_id);
        }
        private void PersonSelected(object sender, SelectedItemChangedEventArgs e)
        {
            check = true;
            for (int i = 0; i < 2; i++)
            {
                if (e.SelectedItem != null)
                {
                    if (e.SelectedItem.ToString() == list[i])
                    {
                        role = roles[i];
                    }
                }
            }
        }
        private async void ToNewPage(object sender, System.EventArgs e)
        {
            if (check == true)
            {
                if (role == true)
                {
                    await Navigation.PushAsync(new ItemsPage());
                }
                else
                {
                    await Navigation.PushAsync(new P1());
                }
            }
        }
    }
}