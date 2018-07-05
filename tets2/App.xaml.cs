using System;
using Xamarin.Forms;
using tets2.Views;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace tets2
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new NewItemPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
    class Order
    {
        public int Rest_id, order_id, dish_id, count, h, s, m, table, waiter_id, chef_id;
        public string comment;
        public  bool is_ready;
    }
}
