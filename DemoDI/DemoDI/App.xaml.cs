using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DemoDI.Views;

namespace DemoDI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Startup.Init();
            MainPage = new NavigationPage(new PostPage());
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

