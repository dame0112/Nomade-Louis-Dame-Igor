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
        private Pays _selectedItem;

        public ObservableCollection<Pays> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddPaysCommand { get; }
        public Command<Pays> ItemTapped { get; }

        public PaysViewModel()
        {
            Title = "Liste des Pays";
            Items = new ObservableCollection<Pays>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Pays>(OnItemsSelected);

            AddPaysCommand = new Command(OnAddItems);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var pay = await DataStorePays.GetItemsAsync(true);
                foreach (var Pays in pay)
                {
                    Items.Add(Pays);
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
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemsSelected(value);
            }
        }

        private async void OnAddItems(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewPaysPage));
        }

        async void OnItemsSelected(Pays item)
        {
            if (item == null)
                return;

            // This will push the PaysDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(PaysDetailPage)}?{nameof(PaysDetailViewModel.PaysId)}={item.Id}");
        }
    }
}