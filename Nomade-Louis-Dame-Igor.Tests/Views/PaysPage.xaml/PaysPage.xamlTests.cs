namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PaysPageTests
    {
        private PaysPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new PaysPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new PaysPage();
            Assert.That(instance, Is.Not.Null);
        }
    }
}