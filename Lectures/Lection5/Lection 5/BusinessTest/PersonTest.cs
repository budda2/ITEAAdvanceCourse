using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void ShouldSerializeAndDeserializeXmlCorrectly()
        {
            //Arrange
            var fileWriter = new FileWriter();
            var serializeExample = new SerializeExample();
            var person = new Person
            {
                Id = Guid.NewGuid(),
                InsuranceNumber = 1,
                Name = "Mykhailo",
                Surname = "Haodeo"
            };

            //Act
            Person deserializedPerson = null;

            using (var serialized = serializeExample.SerializeToXml(person))
            {
                deserializedPerson = serializeExample.DeserializeFromXml(serialized);
            }

            //Assert
            Assert.AreEqual(person, deserializedPerson, "Deserialized person is different from the origin.");
        }

        [TestMethod]
        public void ShouldSerializeAndDeserializeJsonCorrectly()
        {
            //Arrange
            var fileWriter = new FileWriter();
            var serializeExample = new SerializeExample();
            var person = new Person
            {
                Id = Guid.NewGuid(),
                InsuranceNumber = 1,
                Name = "Mykhailo",
                Surname = "Haodeo"
            };

            //Act
            Person deserializedPerson = null;

            var serialized = serializeExample.SerializeToJson(person);
            deserializedPerson = serializeExample.DeserializeFromJson(serialized);

            //Assert
            Assert.AreEqual(person, deserializedPerson, "Deserialized person is different from the origin.");
        }
    }
}
