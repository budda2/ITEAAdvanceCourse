using Buisness;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BuisnessTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var fileWriter = new FileWriter();
            var serializeExample = new SerializeExample();
            var person = new Person
            {
                Id = Guid.NewGuid,

            };
        }
    }
}
