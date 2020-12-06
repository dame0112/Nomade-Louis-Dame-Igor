namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AboutPageTests
    {
        private AboutPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new AboutPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new AboutPage();
            Assert.That(instance, Is.Not.Null);
        }
    }
}