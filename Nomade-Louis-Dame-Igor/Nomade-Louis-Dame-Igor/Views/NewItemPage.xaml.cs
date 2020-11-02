using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Nomade_Louis_Dame_Igor.Models;
using Nomade_Louis_Dame_Igor.ViewModels;

namespace Nomade_Louis_Dame_Igor.Views
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