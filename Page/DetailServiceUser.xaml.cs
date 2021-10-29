using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Assignment2.Model;

namespace Assignment2.Page
{
    public partial class DetailServiceUser : ContentPage
    {
        AppManager manager;
        ServiceUser serviceUser;

        public DetailServiceUser(AppManager m, ServiceUser s)
        {
            InitializeComponent();

            manager = m;
            serviceUser = s;
            BindingContext = serviceUser;
        }

        async void Handle_Delete(System.Object sender, System.EventArgs e)
        {
            await manager.RemoveServiceUserAsync(serviceUser);

            await DisplayAlert(
                    "User deleted",
                    "User with service " + serviceUser.ServiceName + " deleted!",
                    "OK"
                );

            _ = Navigation.PopAsync();
        }

        async void Handle_Copy(System.Object sender, System.EventArgs e)
        {
            Button b = sender as Button;
            string text = b.CommandParameter as string;

            await Clipboard.SetTextAsync(text);

            await DisplayAlert(
                    "Copied to clipboard!",
                    "Text '" + text + "' copied!",
                    "OK"
                );
        }

        async void Handle_Broswer(System.Object sender, System.EventArgs e)
        {
            Button b = sender as Button;
            string uri = b.CommandParameter as string;

            if(uri == null)
            {
                await DisplayAlert(
                    "Default image!",
                    "Can not open default image",
                    "OK"
                );
            } else
            {
                try
                {
                    await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
                }
                catch (Exception)
                {
                    // An unexpected error occured. No browser may be installed on the device.
                    await DisplayAlert(
                        "No browser installed!",
                        "Please install a browser to view this image",
                        "OK"
                    );
                }
            }

        }
    }
}
