using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace test03.Views
{
    public partial class page02 : ContentPage
    {
        private readonly FoodItem _item;

        public page02(FoodItem item)
        {
            InitializeComponent();
            _item = item;
        }

        //private async void OnButtonClicked(object sender, System.EventArgs e)
        //{
            //await this.DisplayAlert("Title", _item.FoodName, "Ok");
        //}
    }
}
