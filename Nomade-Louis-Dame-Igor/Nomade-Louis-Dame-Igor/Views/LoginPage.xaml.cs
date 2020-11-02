using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nomade_Louis_Dame_Igor.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nomade_Louis_Dame_Igor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}