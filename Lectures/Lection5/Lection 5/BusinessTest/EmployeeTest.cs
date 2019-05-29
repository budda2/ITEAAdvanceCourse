using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Test()
        {
            //Arrange
            object employee1 = new Employee();
            object employee2 = new Employee();

            //Act
            var result = employee1.Equals(employee2);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test1()
        {
            //Arrange
            var employee1 = new Employee();
            var employee2 = new Employee();

            //Act
            var result = employee1.Equals(employee2);

            //Assert
            Assert.IsTrue(result);
        }

    }
}
