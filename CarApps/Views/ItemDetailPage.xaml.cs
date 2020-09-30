using System.ComponentModel;
using Xamarin.Forms;
using CarApps.ViewModels;

namespace CarApps.Views
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