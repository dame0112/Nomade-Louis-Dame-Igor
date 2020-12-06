namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Views;
    using System;
    using NUnit.Framework;
    using Nomade_Louis_Dame_Igor.Models;
    using System.Collections.Generic;

    [TestFixture]
    public class NewVillesPageTests
    {
        private NewVillesPage _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new NewVillesPage();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new NewVillesPage();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetVilles()
        {
            _testClass.CheckProperty(x => x.Villes, new Villes { Id = "07", Nom = "senegal", CodePostale = "99", Pays = new List<Pays>() }, new Villes { Id = "08", Nom = "dakar", CodePostale = "999", Pays = new List<Pays>() });
        }
    }
}