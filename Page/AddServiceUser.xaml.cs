using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Assignment2.Model;
using Assignment2.Service;

namespace Assignment2.Page
{
    public partial class AddServiceUser : ContentPage
    {
        AppManager manager;
        FilterData filterData = new FilterData();
        NetworkManager networkManager = new NetworkManager();

        public AddServiceUser(AppManager m)
        {
            InitializeComponent();

            manager = m;
            BindingContext = filterData;
        }

        async void Handle_Generate(object sender, System.EventArgs e)
        {
            if (serviceName.Text != "" && !filterData.Empty())
            {
                ServiceUser serviceUser = await networkManager.GetServiceUser(
                    serviceName.Text,
                    filterData);

                await manager.AddServiceUserAsync(serviceUser);

                await DisplayAlert(
                        "User created",
                        "User with service " + serviceUser.ServiceName + " generated!",
                        "OK"
                    );

                _ = Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert(
                        "Invalid input",
                        "Service name and one data field must be picked!",
                        "OK"
                    );
            }
        }
    }
}
