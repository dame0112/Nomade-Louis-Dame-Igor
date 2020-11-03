using Nomade_Louis_Dame_Igor.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nomade_Louis_Dame_Igor.Services
{
    class MockDataStorePays : IDataStorePays<Pays>
    {
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
