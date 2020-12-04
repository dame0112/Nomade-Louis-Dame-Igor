using Nomade_Louis_Dame_Igor.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nomade_Louis_Dame_Igor.Services
{
    public class MockDataStorePays : IDataStorePays<Pays>
    {

        readonly List<Pays> pays;



        public MockDataStorePays()

        {
            pays = new List<Pays>()
            {
                new Pays { Id = Guid.NewGuid().ToString(), Nom = "France"},
                new Pays { Id = Guid.NewGuid().ToString(), Nom = "Angleterre"},
                new Pays { Id = Guid.NewGuid().ToString(), Nom = "Italie"},


            };
        }

        public Task<bool> AddPaysAsync(Pays Pays)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePaysAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Pays> GetPaysAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pays>> GetPayssAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePaysAsync(Pays Pays)
        {
            throw new NotImplementedException();
        }
    }
}
