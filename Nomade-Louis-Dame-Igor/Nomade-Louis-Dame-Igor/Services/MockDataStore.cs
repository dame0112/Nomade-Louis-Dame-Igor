﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomade_Louis_Dame_Igor.Models;

namespace Nomade_Louis_Dame_Igor.Services
{
    public class MockDataStore : IDataStore<Item>

    {
        readonly List<Item> items;



        public MockDataStore()

        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Grenoble", Description="Isère", DescriptionBis ="C'est le 38 bébé" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Londres", Description="Capitale de l'Angleterre", DescriptionBis ="Frank Lampard" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Rome", Description="Capitale de l'Italie", DescriptionBis = "Francesco Totti" },
               
             
            };
        }
        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }
        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetPaysAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public Task GetVillesAsync(string villesId)
        {
            throw new NotImplementedException();
        }

        public Task GetVillesAsync(bool v)
        {
            throw new NotImplementedException();
        }
    }
}