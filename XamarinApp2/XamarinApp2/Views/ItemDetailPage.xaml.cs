using System.ComponentModel;
using Xamarin.Forms;
using XamarinApp2.ViewModels;

namespace XamarinApp2.Views
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