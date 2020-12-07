namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;
    using Nomade_Louis_Dame_Igor.Models;
    using System.Collections.Generic;

    [TestFixture]
    public class NewPaysPageTests
    {
        private NewPaysPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new NewPaysPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new NewPaysPage();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetPays()
        {
            _testClass.that(x => x.Pays, new Pays { Id = "08", Nom = "dakar", Villes = new List<Villes>() }, new Pays { Id = "221", Nom = "senegal", Villes = new List<Villes>() });
        }
    }
}