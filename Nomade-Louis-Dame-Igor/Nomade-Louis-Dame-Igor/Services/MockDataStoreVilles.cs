using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomade_Louis_Dame_Igor.Models;

namespace Nomade_Louis_Dame_Igor.Services
{
   
    public class MockDataStoreVilles : IDataStore<Villes>
    {
        public Task<bool> AddItemAsync(Villes item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Villes> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Villes>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Villes item)
        {
            throw new NotImplementedException();
        }
    }
}