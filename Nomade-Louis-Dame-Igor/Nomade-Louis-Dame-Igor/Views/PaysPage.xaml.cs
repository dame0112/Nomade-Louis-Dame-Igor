using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Nomade_Louis_Dame_Igor.Models;
using Nomade_Louis_Dame_Igor.Views;
using Nomade_Louis_Dame_Igor.ViewModels;

namespace Nomade_Louis_Dame_Igor.Views
{
    public partial class PaysPage : ContentPage
    {
        PaysViewModel _viewModel;

        public PaysPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new PaysViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}