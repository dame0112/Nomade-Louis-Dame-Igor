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
            var testValue = "TestValue";
            _testClass.Text = testValue;
            Assert.That(_testClass.Text, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetId()
        {
            var test = "Test";
            _testClass.Id = test;
            Assert.That(_testClass.Id, Is.EqualTo(test));
        }

        [Test]
        public void CanSetAndGetDescription()
        {
            var testValue = "Test07";
            _testClass.Description = testValue;
            Assert.That(_testClass.Description, Is.EqualTo(testValue));
        }

       
    }
}