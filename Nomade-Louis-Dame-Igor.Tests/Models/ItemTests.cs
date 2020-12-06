namespace Nomade_Louis_Dame_Igor.Tests
{
    using Nomade_Louis_Dame_Igor.Models;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ItemTests
    {
        private Item _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Item();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Item();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetText()
        {
            var testValue = "TestValue570934495";
            _testClass.Text = testValue;
            Assert.That(_testClass.Text, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetId()
        {
            var testValue = "TestValue1893230939";
            _testClass.Id = testValue;
            Assert.That(_testClass.Id, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetDescription()
        {
            var testValue = "Test07";
            _testClass.Description = testValue;
            Assert.That(_testClass.Description, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetDescriptionBis()
        {
            var testValue = "Test6";
            _testClass.DescriptionBis = testValue;
            Assert.That(_testClass.DescriptionBis, Is.EqualTo(testValue));
        }
    }
}