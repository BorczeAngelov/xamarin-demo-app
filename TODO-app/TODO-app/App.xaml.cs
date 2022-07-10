using System;
using TODO_app.Services;
using TODO_app.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TODO_app
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
