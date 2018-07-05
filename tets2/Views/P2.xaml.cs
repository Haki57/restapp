using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace tets2.Views
{
    public partial class P2 : ContentPage
    {
        private readonly FoodItem _item;

        public P2(FoodItem item)
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
