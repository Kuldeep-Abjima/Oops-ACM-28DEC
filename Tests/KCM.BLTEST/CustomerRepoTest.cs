using KCM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KCM.BLTEST
{
    [TestClass]
    public class CustomerRepoTest
    {
        [TestMethod]
        public void RetreieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                
                EmailAddress = "Hulk@gmail.com",
                FirstName = "Tony",
                LastName = "Stark"
            };
            //--Act
            var actual = customerRepository.Retrieve(1);
            //--Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual (expected.LastName, actual.LastName);
        }
    }
}
