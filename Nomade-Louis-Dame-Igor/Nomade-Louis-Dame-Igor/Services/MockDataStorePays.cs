using Nomade_Louis_Dame_Igor.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nomade_Louis_Dame_Igor.Services
{
    class MockDataStorePays : IDataStore<Pays>
    {
        public Task<bool> AddItemAsync(Pays item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Pays> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pays>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Pays item)
        {
            throw new NotImplementedException();
        }
    }
}
