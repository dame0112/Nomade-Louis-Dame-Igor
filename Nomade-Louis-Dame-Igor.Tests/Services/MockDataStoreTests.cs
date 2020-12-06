namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Services;
    using System;
    using NUnit.Framework;
    using Nomade_Louis_Dame_Igor.Models;
    using System.Threading.Tasks;

    [TestFixture]
    public class MockDataStoreTests
    {
        private MockDataStore _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new MockDataStore();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new MockDataStore();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public async Task CanCallGetItemAsync()
        {
            var id = "77";
            var result = await _testClass.GetItemAsync(id);
            Assert.Fail("test non reussi");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallGetItemAsyncWithInvalidId(string value)
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.GetItemAsync(value));
        }

        [Test]
        public async Task GetItemAsyncPerformsMapping()
        {
            var id = "78";
            var result = await _testClass.GetItemAsync(id);
            Assert.That(result.Id, Is.EqualTo(id));
        }

        [Test]
        public async Task CanCallAddItemAsync()
        {
            var item = new Item { Text = "aazerty", Id = "022", Description = "qwerty",  };
            var result = await _testClass.AddItemAsync(item);
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CannotCallAddItemAsyncWithNullItem()
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.AddItemAsync(default(Item)));
        }

        [Test]
        public async Task CanCallUpdateItemAsync()
        {
            var item = new Item { Text = "abc", Id = "033", Description = "cde",  };
            var result = await _testClass.UpdateItemAsync(item);
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CannotCallUpdateItemAsyncWithNullItem()
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.UpdateItemAsync(default(Item)));
        }

        [Test]
        public async Task CanCallDeleteItemAsync()
        {
            var id = "44";
            var result = await _testClass.DeleteItemAsync(id);
            Assert.Fail("test non reussi");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallDeleteItemAsyncWithInvalidId(string value)
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.DeleteItemAsync(value));
        }

        [Test]
        public async Task CanCallGetItemsAsync()
        {
            var forceRefresh = false;
            var result = await _testClass.GetItemsAsync(forceRefresh);
            Assert.Fail("test non reussit");
        }
    }
}