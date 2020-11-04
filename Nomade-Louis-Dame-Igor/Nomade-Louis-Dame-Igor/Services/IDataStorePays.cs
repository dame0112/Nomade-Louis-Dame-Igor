using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nomade_Louis_Dame_Igor.Services
{
    public interface IDataStorePays<P>
    {
        Task<bool> AddPaysAsync(P Pays);
        Task<bool> UpdatePaysAsync(P Pays);
        Task<bool> DeletePaysAsync(string id);
        Task<P> GetPaysAsync(string id);
        Task<IEnumerable<P>> GetPayssAsync(bool forceRefresh = false);
       // Task GetPaysAsync(string paysId);
    }
}
