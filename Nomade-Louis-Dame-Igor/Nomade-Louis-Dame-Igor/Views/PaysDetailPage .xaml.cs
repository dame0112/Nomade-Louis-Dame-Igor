using System.ComponentModel;
using Xamarin.Forms;
using Nomade_Louis_Dame_Igor.ViewModels;

namespace Nomade_Louis_Dame_Igor.Views
{
    public partial class PaysDetailPage : ContentPage
    {
        public PaysDetailPage()
        {
            InitializeComponent();
            BindingContext = new PaysDetailViewModel();
        }
    }
}