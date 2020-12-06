namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ItemDetailViewModelTests
    {
        private ItemDetailViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ItemDetailViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ItemDetailViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanCallLoadItemId()
        {
            var itemId = "07";
            _testClass.LoadItemId(itemId);
            Assert.Fail("test non reussi");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallLoadItemIdWithInvalidItemId(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.LoadItemId(value));
        }

        [Test]
        public void CanSetAndGetId()
        {
            _testClass.CheckProperty(x => x.Id);
        }

        [Test]
        public void CanSetAndGetText()
        {
            _testClass.CheckProperty(x => x.Text);
        }

        [Test]
        public void CanSetAndGetDescription()
        {
            _testClass.CheckProperty(x => x.Description);
        }

        [Test]
        public void CanSetAndGetDescriptionBis()
        {
            _testClass.CheckProperty(x => x.DescriptionBis);
        }

        [Test]
        public void CanSetAndGetItemId()
        {
            _testClass.CheckProperty(x => x.ItemId);
        }
    }
}