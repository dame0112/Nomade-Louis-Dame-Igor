namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class VillesPageTests
    {
        private VillesPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new VillesPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new VillesPage();
            Assert.That(instance, Is.Not.Null);
        }
    }
}