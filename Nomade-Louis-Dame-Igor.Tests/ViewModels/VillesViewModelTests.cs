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
    public class VillesViewModelTests
    {
        private VillesViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new VillesViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new VillesViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanCallOnAppearing()
        {
            _testClass.OnAppearing();
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetVilles()
        {
            Assert.That(_testClass.Villes, Is.InstanceOf<ObservableCollection<Villes>>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetLoadVillesCommand()
        {
            Assert.That(_testClass.LoadVillesCommand, Is.InstanceOf<Command>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetAddVillesCommand()
        {
            Assert.That(_testClass.AddVillesCommand, Is.InstanceOf<Command>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetVillesTapped()
        {
            Assert.That(_testClass.VillesTapped, Is.InstanceOf<Command<Villes>>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanSetAndGetSelectedVilles()
        {
            _testClass.CheckProperty(x => x.SelectedVilles, new Villes { Id = "00", Nom = "jrn", CodePostale = "000", Pays = new List<Pays>() }, new Villes { Id = "01", Nom = "jrnn", CodePostale = "0000", Pays = new List<Pays>() });
        }
    }
}