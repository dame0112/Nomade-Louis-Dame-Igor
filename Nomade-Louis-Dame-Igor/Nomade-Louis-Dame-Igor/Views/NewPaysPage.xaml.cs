using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Nomade_Louis_Dame_Igor.Models;
using Nomade_Louis_Dame_Igor.ViewModels;

namespace Nomade_Louis_Dame_Igor.Views
{
    public partial class NewPaysPage : ContentPage
    {
        public Pays Pays { get; set; }

        public NewPaysPage()
        {
            InitializeComponent();
            BindingContext = new NewPaysViewModel();
        }
    }
}