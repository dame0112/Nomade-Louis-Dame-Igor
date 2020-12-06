namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PaysDetailViewModelTests
    {
        private PaysDetailViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new PaysDetailViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new PaysDetailViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanCallLoadPaysId()
        {
            var PaysId = "56";
            _testClass.LoadPaysId(PaysId);
            Assert.Fail("test non reussi");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallLoadPaysIdWithInvalidPaysId(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.LoadPaysId(value));
        }

        [Test]
        public void CanSetAndGetNom()
        {
            _testClass.CheckProperty(x => x.Nom);
        }

        [Test]
        public void CanSetAndGetPaysId()
        {
            _testClass.CheckProperty(x => x.PaysId);
        }
    }
}