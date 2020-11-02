using System;
using System.Collections.Generic;
using Nomade_Louis_Dame_Igor.ViewModels;
using Nomade_Louis_Dame_Igor.Views;
using Xamarin.Forms;

namespace Nomade_Louis_Dame_Igor
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
