using System.ComponentModel;
using TODO_app.ViewModels;
using Xamarin.Forms;

namespace TODO_app.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}