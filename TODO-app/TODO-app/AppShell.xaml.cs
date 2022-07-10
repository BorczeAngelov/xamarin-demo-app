using System;
using System.Collections.Generic;
using TODO_app.ViewModels;
using TODO_app.Views;
using Xamarin.Forms;

namespace TODO_app
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
