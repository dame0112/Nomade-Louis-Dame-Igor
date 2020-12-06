namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;
    using Xamarin.Forms;

    [TestFixture]
    public class NewItemViewModelTests
    {
        private NewItemViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new NewItemViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new NewItemViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetText()
        {
            _testClass.CheckProperty(x => x.Text);
        }

        [Test]
        public void CanSetAndGetDescription()
        {
            _testClass.CheckProperty(x => x.Description);
        }

        [Test]
        public void CanSetAndGetDescriptionBis()
        {
            _testClass.CheckProperty(x => x.DescriptionBis);
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