using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Nomade_Louis_Dame_Igor.Models;
using Nomade_Louis_Dame_Igor.Services;
using Xamarin.Forms;

namespace Nomade_Louis_Dame_Igor.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private string descriptionBis;
        private string temperature;
        RestService _Rs = new RestService();
        WeatherData _Wd = new WeatherData();
        public string Id { get; set; }

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

        public string DescriptionBis
        {
            get => descriptionBis;
            set => SetProperty(ref descriptionBis, value);
        }


        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public string Temperature { get => temperature; set => SetProperty(ref temperature, value); }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                DescriptionBis = item.DescriptionBis;
                _Wd = await _Rs.OnGetWeatherButtonClicked(Text);
                Temperature = _Wd.Main.Temperature.ToString();
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
