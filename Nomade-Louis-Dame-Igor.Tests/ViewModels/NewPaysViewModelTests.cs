namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;
    using Xamarin.Forms;

    [TestFixture]
    public class NewPaysViewModelTests
    {
        private NewPaysViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new NewPaysViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new NewPaysViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetnom()
        {
            _testClass.CheckProperty(x => x.nom);
        }

        [Test]
        public void CanSetAndGetid()
        {
            _testClass.CheckProperty(x => x.id);
        }

        [Test]
        public void CanGetSaveCommand()
        {
            Assert.That(_testClass.SaveCommand, Is.InstanceOf<Command>());
            Assert.Fail("test non reussi");
        }

        [Test]
        public void CanGetCancelCommand()
        {
            Assert.That(_testClass.CancelCommand, Is.InstanceOf<Command>());
            Assert.Fail("test non reussi");
        }
    }
}