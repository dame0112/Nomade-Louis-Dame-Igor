namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class VillesDetailPageTests
    {
        private VillesDetailPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new VillesDetailPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new VillesDetailPage();
            Assert.That(instance, Is.Not.Null);
        }
    }
}