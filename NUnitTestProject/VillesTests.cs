namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Models;
    using System;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class VillesTests
    {
        private Villes _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Villes();
        }

       

        [Test]
        public void CanSetAndGetId()
        {
            var testValue = "grenoble";
            _testClass.Id = testValue;
            Assert.That(_testClass.Id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetNom()
        {
            var testValue = "lyon";
            _testClass.Nom = testValue;
            Assert.That(_testClass.Nom, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCodePostale()
        {
            var testValue = "paris";
            _testClass.CodePostale = testValue;
            Assert.That(_testClass.CodePostale, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetPays()
        {
            var testValue = new List<Pays>();
            _testClass.Pays = testValue;
            Assert.That(_testClass.Pays, Is.EqualTo(testValue));
        }
    }
}