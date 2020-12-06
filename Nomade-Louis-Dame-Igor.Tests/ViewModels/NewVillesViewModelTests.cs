namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;
    using Xamarin.Forms;

    [TestFixture]
    public class NewVillesViewModelTests
    {
        private NewVillesViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new NewVillesViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new NewVillesViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetCodePostale()
        {
            _testClass.CheckProperty(x => x.CodePostale);
        }

        [Test]
        public void CanSetAndGetNom()
        {
            _testClass.CheckProperty(x => x.Nom);
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