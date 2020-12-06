namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ItemsPageTests
    {
        private ItemsPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ItemsPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ItemsPage();
            Assert.That(instance, Is.Not.Null);
        }
    }
}