using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;

namespace BusinessLayerTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Stephen";
            customer.LastName = "King";

            string expected = "King, Stephen";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "King";

            string expected = "King";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Stephen";

            string expected = "Stephen";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Stephen";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Jessica";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Dot";
            Customer.InstanceCount += 1;

            // Act
            int expected = 3;

            // Assert
            Assert.AreEqual(expected, Customer.InstanceCount);
        }
    }
}
