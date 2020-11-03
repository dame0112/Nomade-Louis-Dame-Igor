using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nomade_Louis_Dame_Igor.Services
{
    public interface IDataStoreVilles<V>
    {
        Task<bool> AddVillesAsync(V Villes);
        Task<bool> UpdateVillesAsync(V Villes);
        Task<bool> DeleteVillesAsync(string id);
        Task<V> GetVillesAsync(string id);
        Task<IEnumerable<V>> GetVillesAsync(bool forceRefresh = false);
    }
}
