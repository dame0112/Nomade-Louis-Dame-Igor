using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Nomade_Louis_Dame_Igor.Models;
using Xamarin.Forms;

namespace Nomade_Louis_Dame_Igor.ViewModels
{
    [QueryProperty(nameof(VillesId), nameof(VillesId))]
    public class VillesDetailViewModel : BaseViewModel
    {
        private const string Message = "Failed to Load Villes";
        private string Id;
        private string Nom;
        private string CodePostale;
        public string id { get; set; }

        public string nom
        {
            get;set;
        }

        public string codePostale
        {
            get; set;
        }

        public string VillesId
        {
            get
            {
                return VillesId;
            }
            set
            {
                VillesId = value;
                LoadVillesId(value);
            }
        }

        public async void LoadVillesId(string VillesId)
        {
            try
            {
                var Villes = await DataStoreVilles.GetVillesAsync(VillesId);
                id = Villes.Id;
                nom = Villes.Nom;
                codePostale = Villes.CodePostale;
            }
            catch (Exception)
            {
                Debug.WriteLine(Message);
            }
        }
    }
}
