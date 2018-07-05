using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tets2.Views
{
    public partial class TestPage : ContentPage
    {
        Order order = new Order();
        public TestPage()
        {
            InitializeComponent();
            Fin.Clicked += ToNewPage;
        }
        private async void ToNewPage(object sender, System.EventArgs e)
        {
            order.comment = Comment.Text;
            order.count = Convert.ToInt32(count.Text); 
            order.table = Convert.ToInt32(table.Text);
            order.Rest_id = PropertyHelper.GetPropertyValue<int>(PropertyEnum. IdProperty);
            order.waiter_id = PropertyHelper.GetPropertyValue<int>(PropertyEnum.WId);
            order.dish_id = PropertyHelper.GetPropertyValue<int>(PropertyEnum.DId);
            order.is_ready = false;
            order.h = DateTime.Now.Hour;
            order.m = DateTime.Now.Minute;
            order.s = DateTime.Now.Second;
            var test = order;
            await Navigation.PushAsync(new ItemsPage());
        }
    }


}
