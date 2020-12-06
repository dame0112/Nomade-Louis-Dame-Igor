namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;
    using System.Collections.ObjectModel;
    using Nomade_Louis_Dame_Igor.Models;
    using Xamarin.Forms;
    using System.Collections.Generic;

    [TestFixture]
    public class PaysViewModelTests
    {
        private PaysViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new PaysViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new PaysViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanCallOnAppearing()
        {
            _testClass.OnAppearing();
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetItems()
        {
            Assert.That(_testClass.Items, Is.InstanceOf<ObservableCollection<Pays>>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetLoadItemsCommand()
        {
            Assert.That(_testClass.LoadItemsCommand, Is.InstanceOf<Command>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetAddItemCommand()
        {
            Assert.That(_testClass.AddItemCommand, Is.InstanceOf<Command>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetItemTapped()
        {
            Assert.That(_testClass.ItemTapped, Is.InstanceOf<Command<Pays>>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanSetAndGetSelectedPays()
        {
            _testClass.CheckProperty(x => x.SelectedPays, new Pays { Id = "96", Nom = "Test", Villes = new List<Villes>() }, new Pays { Id = "9", Nom = "Teste", Villes = new List<Villes>() });
        }
    }
}