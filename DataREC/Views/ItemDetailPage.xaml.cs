using DataREC.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DataREC.Views
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