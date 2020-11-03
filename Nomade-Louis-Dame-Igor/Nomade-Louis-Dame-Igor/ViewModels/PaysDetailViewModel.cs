using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Nomade_Louis_Dame_Igor.Models;
using Xamarin.Forms;

namespace Nomade_Louis_Dame_Igor.ViewModels
{
    [QueryProperty(nameof(PaysId), nameof(PaysId))]
    public class PaysDetailViewModel : BaseViewModel
    {
        private string Id;
        private string Nom;
       
        public string id { get; set; }

        public string nom
        {
            get => Nom;
            set => SetProperty(ref Nom, value);
        }

      

        public string PaysId
        {
            get
            {
                return PaysId;
            }
            set
            {
                PaysId = value;
                LoadPaysId(value);
            }
        }

        public async void LoadPaysId(string PaysId)
        {
            try
            {
                var Pays = await DataStore.GetPaysAsync(PaysId);
                id = Pays.Id;
                nom = Pays.Nom;
               
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Pays");
            }
        }
    }
}
