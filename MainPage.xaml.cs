using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Assignment2.Model;
using Assignment2.Page;

namespace Assignment2
{
    public partial class MainPage : ContentPage
    {
        AppManager manager = new AppManager();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = manager;
        }

        protected async override void OnAppearing()
        {
            // Initialize service users
            await manager.InitServiceUser();
            userList.ItemsSource = manager.serviceUsers;

            base.OnAppearing();
        }

        async void Handle_Add(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddServiceUser(manager));
        }

        async void Handle_Detail(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItem != null)
            {
                ServiceUser sv = lv.SelectedItem as ServiceUser;
                lv.SelectedItem = null;
                await Navigation.PushAsync(new DetailServiceUser(manager, sv));
            }
        }
    }
}
