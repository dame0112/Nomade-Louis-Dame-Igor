namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class LoginPageTests
    {
        private LoginPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new LoginPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new LoginPage();
            Assert.That(instance, Is.Not.Null);
        }
    }
}