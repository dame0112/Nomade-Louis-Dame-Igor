using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Nomade_Louis_Dame_Igor.Models;
using Xamarin.Forms;

namespace Nomade_Louis_Dame_Igor.ViewModels
{
    public class NewPaysViewModel : BaseViewModel
    {
        private string Nom;
        private string Id;

        public NewPaysViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(Nom)
                && !String.IsNullOrWhiteSpace(Id);
        }

        public string nom
        {
            get => Nom;
            set => SetProperty(ref Nom, value);
        }

        public string id
        {
            get => Id;
            set => SetProperty(ref Id, value);
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
           Pays newPays = new Pays()
            {
                Id = Guid.NewGuid().ToString(),
                Nom = Nom,
               // Id = Id
            };

            await DataStorePays.AddItemAsync(newPays);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
