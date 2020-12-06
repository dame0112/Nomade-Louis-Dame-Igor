namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Services;
    using System;
    using NUnit.Framework;
    using Nomade_Louis_Dame_Igor.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [TestFixture]
    public class MockDataStoreVillesTests
    {
        private MockDataStoreVilles _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new MockDataStoreVilles();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new MockDataStoreVilles();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public async Task CanCallAddVillesAsync()
        {
            var Villes = new Villes { Id = "01", Nom = "abc", CodePostale = "38240", Pays = new List<Pays>() };
            var result = await _testClass.AddVillesAsync(Villes);
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CannotCallAddVillesAsyncWithNullVilles()
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.AddVillesAsync(default(Villes)));
        }

        [Test]
        public async Task CanCallDeleteVillesAsync()
        {
            var id = "02";
            var result = await _testClass.DeleteVillesAsync(id);
            Assert.Fail("test non reussi");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallDeleteVillesAsyncWithInvalidId(string value)
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.DeleteVillesAsync(value));
        }

        [Test]
        public async Task CanCallGetVillesAsyncWithString()
        {
            var id = "01";
            var result = await _testClass.GetVillesAsync(id);
            Assert.Fail("test non reussi");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallGetVillesAsyncWithStringWithInvalidId(string value)
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.GetVillesAsync(value));
        }

        [Test]
        public async Task GetVillesAsyncWithStringPerformsMapping()
        {
            var id = "05";
            var result = await _testClass.GetVillesAsync(id);
            Assert.That(result.Id, Is.EqualTo(id));
        }

        [Test]
        public async Task CanCallGetVillesAsyncWithForceRefresh()
        {
            var forceRefresh = false;
            var result = await _testClass.GetVillesAsync(forceRefresh);
            Assert.Fail("test non reussi");
        }

        [Test]
        public async Task CanCallUpdateVillesAsync()
        {
            var Villes = new Villes { Id = "38", Nom = "gre", CodePostale = "38000", Pays = new List<Pays>() };
            var result = await _testClass.UpdateVillesAsync(Villes);
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CannotCallUpdateVillesAsyncWithNullVilles()
        {
            Assert.ThrowsAsync<ArgumentNullException>(() => _testClass.UpdateVillesAsync(default(Villes)));
        }
    }
}