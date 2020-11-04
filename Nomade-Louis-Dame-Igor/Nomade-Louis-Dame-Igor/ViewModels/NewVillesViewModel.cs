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
        private string text;
        private string description;

        public NewVillesViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
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

            await DataStore.AddVillesAsync(newVilles);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
