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
        private string paysId;
        private string nom;
       

        public string Nom
        {
            get => nom;
            set => SetProperty(ref nom, value);
        }

      

        public string PaysId
        {
            get
            {
                return paysId;
            }
            set
            {
                paysId = value;
                LoadPaysId(value);
            }
        }

        public async void LoadPaysId(string PaysId)
        {
            try
            {
                var Pays = await DataStorePays.GetItemAsync(PaysId);
                Nom = Pays.Nom;
               
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Pays");
            }
        }
    }
}
