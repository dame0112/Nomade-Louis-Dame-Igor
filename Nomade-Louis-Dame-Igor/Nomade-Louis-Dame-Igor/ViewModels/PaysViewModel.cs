using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Nomade_Louis_Dame_Igor.Models;
using Nomade_Louis_Dame_Igor.Views;

namespace Nomade_Louis_Dame_Igor.ViewModels
{
    public class PaysViewModel : BaseViewModel
    {
        private Pays _selectedPays;

        public ObservableCollection<Pays> Pays { get; }
        public Command LoadPaysCommand { get; }
        public Command AddPaysCommand { get; }
        public Command<Pays> PaysTapped { get; }

        public PaysViewModel()
        {
            Title = "Liste des Pays";
            Pays = new ObservableCollection<Pays>();
            LoadPaysCommand = new Command(async () => await ExecuteLoadPaysCommand());

            PaysTapped = new Command<Pays>(OnPaysSelected);

            AddPaysCommand = new Command(OnAddPays);
        }

        async Task ExecuteLoadPaysCommand()
        {
            IsBusy = true;

            try
            {
                Pays.Clear();
                var pays = await DataStorePays.GetPayssAsync(true);
                foreach (var PAYS in Pays)
                {
                    Pays.Add(PAYS);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedPays = null;
        }

        public Pays SelectedPays
        {
            get => _selectedPays;
            set
            {
                SetProperty(ref _selectedPays, value);
                OnPaysSelected(value);
            }
        }

        private async void OnAddPays(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewPaysPage));
        }

        async void OnPaysSelected(Pays Pays)
        {
            if (Pays == null)
                return;

            // This will push the PaysDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(PaysDetailPage)}?{nameof(PaysDetailViewModel.PaysId)}={Pays.Id}");
        }
    }
}