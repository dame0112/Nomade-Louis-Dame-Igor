namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;
    using System.Collections.ObjectModel;
    using Nomade_Louis_Dame_Igor.Models;
    using Xamarin.Forms;

    [TestFixture]
    public class ItemsViewModelTests
    {
        private ItemsViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ItemsViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ItemsViewModel();
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
            Assert.That(_testClass.Items, Is.InstanceOf<ObservableCollection<Item>>());
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
            Assert.That(_testClass.ItemTapped, Is.InstanceOf<Command<Item>>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanSetAndGetSelectedItem()
        {
            _testClass.CheckProperty(x => x.SelectedItem, new Item { Text = "test", Id = "75", Description = "lyon", }, new Item { Text = "TestValue", Id = "70", Description = "paris" });
        }
    }
}