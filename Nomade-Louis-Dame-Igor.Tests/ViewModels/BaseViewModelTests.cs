namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;
    using Nomade_Louis_Dame_Igor.Services;
    using Nomade_Louis_Dame_Igor.Models;

    [TestFixture]
    public class BaseViewModelTests
    {
        private BaseViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new BaseViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new BaseViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanGetDataStore()
        {
            Assert.That(_testClass.DataStore, Is.InstanceOf<IDataStore<Item>>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetDataStorePays()
        {
            Assert.That(_testClass.DataStorePays, Is.InstanceOf<IDataStore<Pays>>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetDataStoreVilles()
        {
            Assert.That(_testClass.DataStoreVilles, Is.InstanceOf<IDataStoreVilles<Villes>>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanSetAndGetIsBusy()
        {
            _testClass.CheckProperty(x => x.IsBusy);
        }

        [Test]
        public void CanSetAndGetTitle()
        {
            _testClass.CheckProperty(x => x.Title);
        }
    }
}