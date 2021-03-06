using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarTextColor = Color.FromHex("#FFFFFF"),
                BarBackgroundColor = Color.FromHex("#344955")
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
