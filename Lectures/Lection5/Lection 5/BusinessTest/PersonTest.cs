using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessTest
{
    [TestClass]
    public class PersonTest
    {
        SerializeExample _serializer;
        Person _person;

        [TestInitialize]
        public void TestInitialize()
        {
            //here we write initialization that is commot for all the tests.
            _serializer = new SerializeExample();
            _person = new Person
            {
                Id = Guid.NewGuid(),
                InsuranceNumber = 1,
                Name = "Mykhailo",
                Surname = "Haodeo"
            };
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            //here we would write initialization code that would be executed ony once for all the tests inside this class
        }

        [TestMethod]
        public void ShouldSerializeAndDeserializeXmlCorrectly()
        {
            //Arrange

            //Act
            Person deserializedPerson = null;

            using (var serialized = _serializer.SerializeToXml(_person))
            {
                deserializedPerson = _serializer.DeserializeFromXml(serialized);
            }

            //Assert
            Assert.AreEqual(_person, deserializedPerson, "Deserialized person is different from the origin.");
        }

        [TestMethod]
        public void ShouldSerializeAndDeserializeJsonCorrectly()
        {
            //Arrange
            //Act
            Person deserializedPerson = null;

            var serialized = _serializer.SerializeToJson(_person);
            deserializedPerson = _serializer.DeserializeFromJson(serialized);

            //Assert
            Assert.AreEqual(_person, deserializedPerson, "Deserialized person is different from the origin.");
        }
    }
}
