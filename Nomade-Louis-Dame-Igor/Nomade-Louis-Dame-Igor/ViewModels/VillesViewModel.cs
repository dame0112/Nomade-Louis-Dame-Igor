using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Nomade_Louis_Dame_Igor.Models;
using Nomade_Louis_Dame_Igor.Views;

namespace Nomade_Louis_Dame_Igor.ViewModels
{
    public class VillesViewModel : BaseViewModel
    {
        private Villes _selectedVilles;

        public ObservableCollection<Villes> Villes { get; }
        public Command LoadVillesCommand { get; }
        public Command AddVillesCommand { get; }
        public Command<Villes> VillesTapped { get; }

        public VillesViewModel()
        {
            Title = "Browse";
            Villes = new ObservableCollection<Villes>();
            LoadVillesCommand = new Command(async () => await ExecuteLoadVillesCommand());

            VillesTapped = new Command<Villes>(OnVillesSelected);

            AddVillesCommand = new Command(OnAddVilles);
        }

        async Task ExecuteLoadVillesCommand()
        {
            IsBusy = true;

            try
            {
                Villes.Clear();
                var villes = await DataStoreVilles.GetVillesAsync(true);
                foreach (var ville in Villes)
                {
                    Villes.Add(ville);
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
            SelectedVilles = null;
        }

        public Villes SelectedVilles
        {
            get => _selectedVilles;
            set
            {
                SetProperty(ref _selectedVilles, value);
                OnVillesSelected(value);
            }
        }

        private async void OnAddVilles(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewVillesPage));
        }

        async void OnVillesSelected(Villes Villes)
        {
            if (Villes == null)
                return;

            // This will push the VillesDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(VillesDetailPage)}?{nameof(VillesDetailViewModel.VillesId)}={Villes.Id}");
        }
    }
}