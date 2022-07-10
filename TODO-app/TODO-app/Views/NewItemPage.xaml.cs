using System;
using System.Collections.Generic;
using System.ComponentModel;
using TODO_app.Models;
using TODO_app.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TODO_app.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}