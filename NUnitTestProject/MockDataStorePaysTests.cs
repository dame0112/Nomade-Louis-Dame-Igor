namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Services;
    using System;
    using NUnit.Framework;
    using Nomade_Louis_Dame_Igor.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [TestFixture]
    public class MockDataStorePaysTests
    {
        private MockDataStorePays _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new MockDataStorePays();
        }


        [Test]
        public async Task CanCallAddItemAsync()
        {
            var item = new Pays { Id = "01", Nom = "dame", Villes = new List<Villes>() };
            var result = await _testClass.AddItemAsync(item);
            Assert.Fail("test non reussi");
        }

        [Test]
        public async Task CanCallDeleteItemAsync()
        {
            var id = "02";
            var result = await _testClass.DeleteItemAsync(id);
            Assert.Fail("test non reussi");
        }


        [Test]
        public async Task CanCallGetItemAsync()
        {
            var id = "03";
            var result = await _testClass.GetItemAsync(id);
            Assert.Fail("test non reussi");
        }


        [Test]
        public async Task GetItemAsyncPerformsMapping()
        {
            var id = "04";
            var result = await _testClass.GetItemAsync(id);
            Assert.That(result.Id, Is.EqualTo(id));
        }

        [Test]
        public async Task CanCallGetItemsAsync()
        {
            var forceRefresh = false;
            var result = await _testClass.GetItemsAsync(forceRefresh);
            Assert.Fail("test non reussi");
        }

        [Test]
        public async Task CanCallUpdateItemAsync()
        {
            var item = new Pays { Id = "38", Nom = "grenoble", Villes = new List<Villes>() };
            var result = await _testClass.UpdateItemAsync(item);
            Assert.Fail("test non reussi");
        }
      
    }
}