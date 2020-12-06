namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AppTests
    {
        private App _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new App();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new App();
            Assert.That(instance, Is.Not.Null);
        }
    }
}