﻿using Nomade_Louis_Dame_Igor.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nomade_Louis_Dame_Igor.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        Task<T> GetItemAsync(string id);


    }
}
