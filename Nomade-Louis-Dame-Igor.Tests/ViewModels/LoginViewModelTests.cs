namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;
    using Xamarin.Forms;

    [TestFixture]
    public class LoginViewModelTests
    {
        private LoginViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new LoginViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new LoginViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanGetLoginCommand()
        {
            Assert.That(_testClass.LoginCommand, Is.InstanceOf<Command>());
            Assert.Fail("test non reussi");
        }
    }
}