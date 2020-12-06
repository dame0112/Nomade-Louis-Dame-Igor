namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.ViewModels;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class VillesDetailViewModelTests
    {
        private VillesDetailViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new VillesDetailViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new VillesDetailViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanCallLoadVillesId()
        {
            var VillesId = "667";
            _testClass.LoadVillesId(VillesId);
            Assert.Fail("test non reussi");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void CannotCallLoadVillesIdWithInvalidVillesId(string value)
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.LoadVillesId(value));
        }

        [Test]
        public void CanSetAndGetid()
        {
            _testClass.CheckProperty(x => x.id);
        }

        [Test]
        public void CanSetAndGetnom()
        {
            _testClass.CheckProperty(x => x.nom);
        }

        [Test]
        public void CanSetAndGetcodePostale()
        {
            _testClass.CheckProperty(x => x.codePostale);
        }

        [Test]
        public void CanSetAndGetVillesId()
        {
            _testClass.CheckProperty(x => x.VillesId);
        }
    }
}