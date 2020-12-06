namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;
    using Nomade_Louis_Dame_Igor.Models;

    [TestFixture]
    public class NewItemPageTests
    {
        private NewItemPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new NewItemPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new NewItemPage();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetItem()
        {
            _testClass.CheckProperty(x => x.Item, new Item { Text = "Test", Id = "*13", Description = "descript" }, new Item { Text = "Teste", Id = "25", Description = "descripte" });
        }
    }
}