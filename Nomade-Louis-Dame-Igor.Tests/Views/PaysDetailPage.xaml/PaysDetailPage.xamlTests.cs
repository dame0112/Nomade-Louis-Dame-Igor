namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PaysDetailPageTests
    {
        private PaysDetailPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new PaysDetailPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new PaysDetailPage();
            Assert.That(instance, Is.Not.Null);
        }
    }
}