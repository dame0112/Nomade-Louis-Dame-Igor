using Nomade_Louis_Dame_Igor.Models;
using NUnit.Framework;

namespace Nomade_Louis_Dame_Igor.Tests
{
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