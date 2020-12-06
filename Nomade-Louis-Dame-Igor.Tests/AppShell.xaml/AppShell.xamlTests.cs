namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AppShellTests
    {
        private AppShell _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new AppShell();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new AppShell();
            Assert.That(instance, Is.Not.Null);
        }
    }
}