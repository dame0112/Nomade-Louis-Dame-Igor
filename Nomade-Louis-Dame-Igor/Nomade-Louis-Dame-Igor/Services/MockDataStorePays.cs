﻿using Nomade_Louis_Dame_Igor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomade_Louis_Dame_Igor.Services
{
    public class MockDataStorePays : IDataStore<Pays>
    {

        readonly List<Pays> pays;



        public MockDataStorePays()

        {
            pays = new List<Pays>()
            {
                new Pays { Id = Guid.NewGuid().ToString(), Nom = "France" },
                new Pays { Id = Guid.NewGuid().ToString(), Nom = "Angleterre" },
                new Pays { Id = Guid.NewGuid().ToString(), Nom = "Italie" },


            };
        }

        public async Task<bool> AddItemAsync(Pays item)
        {
            pays.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = pays.Where((Pays arg) => arg.Id == id).FirstOrDefault();
            pays.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Pays> GetItemAsync(string id)
        {
            return await Task.FromResult(pays.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Pays>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(pays);
        }

        public async Task<bool> UpdateItemAsync(Pays item)
        {
            var oldItem = pays.Where((Pays arg) => arg.Id == item.Id).FirstOrDefault();
            pays.Remove(oldItem);
            pays.Add(item);

            return await Task.FromResult(true);
        }
    }
    }
