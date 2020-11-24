using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Nomade_Louis_Dame_Igor.Models;
using Xamarin.Forms;

namespace Nomade_Louis_Dame_Igor.ViewModels
{
    public class NewVillesViewModel : BaseViewModel
    {
        private string nom;
        private string codepostale;

        public NewVillesViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nom)
                && !String.IsNullOrWhiteSpace(codepostale);
        }

        public string CodePostale
        {
            get => codepostale;
            set => SetProperty(ref codepostale, value);
        }

        public string Nom
        {
            get => nom;
            set => SetProperty(ref nom, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Villes newVilles = new Villes()
            {
                Id = Guid.NewGuid().ToString(),
                Nom = Nom,
               CodePostale = CodePostale
            };

            await DataStoreVilles.AddVillesAsync(newVilles);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
