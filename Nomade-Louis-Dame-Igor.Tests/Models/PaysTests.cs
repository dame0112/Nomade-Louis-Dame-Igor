namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Models;
    using System;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class PaysTests
    {
        private Pays _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Pays();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Pays();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetId()
        {
            var testValue = "senegal";
            _testClass.Id = testValue;
            Assert.That(_testClass.Id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetNom()
        {
            var testValue = "ripMaradonna";
            _testClass.Nom = testValue;
            Assert.That(_testClass.Nom, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetVilles()
        {
            var testValue = new List<Villes>();
            _testClass.Villes = testValue;
            Assert.That(_testClass.Villes, Is.EqualTo(testValue));
        }
    }
}