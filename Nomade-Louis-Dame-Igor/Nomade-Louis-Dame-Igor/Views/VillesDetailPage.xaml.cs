using System.ComponentModel;
using Xamarin.Forms;
using Nomade_Louis_Dame_Igor.ViewModels;

namespace Nomade_Louis_Dame_Igor.Views
{
    public partial class VillesDetailPage : ContentPage
    {
        public VillesDetailPage()
        {
            InitializeComponent();
            BindingContext = new VillesDetailViewModel();
        }
    }
}