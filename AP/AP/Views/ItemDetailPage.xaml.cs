using AP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AP.Views
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