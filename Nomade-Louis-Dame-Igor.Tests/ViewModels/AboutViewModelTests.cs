namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;
    using System.Windows.Input;

    [TestFixture]
    public class AboutViewModelTests
    {
        private AboutViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new AboutViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new AboutViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanGetOpenWebCommand()
        {
            Assert.That(_testClass.OpenWebCommand, Is.InstanceOf<ICommand>());
            Assert.Fail("test non reussi");
        }
    }
}