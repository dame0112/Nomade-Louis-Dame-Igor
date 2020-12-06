namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ItemDetailPageTests
    {
        private ItemDetailPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ItemDetailPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ItemDetailPage();
            Assert.That(instance, Is.Not.Null);
        }
    }
}