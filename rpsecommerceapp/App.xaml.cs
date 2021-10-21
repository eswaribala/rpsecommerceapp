using rpsecommerceapp.views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rpsecommerceapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ToolbarPage());
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
