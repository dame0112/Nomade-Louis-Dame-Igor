using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomade_Louis_Dame_Igor.Models;

namespace Nomade_Louis_Dame_Igor.Services
{
   
    public class MockDataStoreVilles : IDataStoreVilles<Villes>
    {
        public Task<bool> AddVillesAsync(Villes Villes)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteVillesAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Villes> GetVillesAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Villes>> GetVillesAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateVillesAsync(Villes Villes)
        {
            throw new NotImplementedException();
        }
    }
}