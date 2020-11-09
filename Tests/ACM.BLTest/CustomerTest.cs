using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void FullNameTestValid()
        {

            //--Arrange
            var customer = new Customer
            {

                FirstName = "Bilbo",
                LastName = "Baggins",


            };


            string expected = "Baggins, Bilbo";

            //--ACT
            string actual = customer.FullName;

            //--ASSERT

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange 

            var customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //--ACT
            string actual = customer.FullName;

            //--ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            var customer = new Customer
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;


            //--Act

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]

        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer
            {
                LastName="Baggins",
                EmailAdress="fbaggins@hobbiton.me"
            };

            var expected = true;
            //--ACT
            var actual = customer.Validate();

            //--ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange 
            var customer = new Customer
            {
                EmailAdress="Fbaggina=s@hobiton.me"

            };

            var expected = false;

            //--ACT
            var actual = customer.Validate();

            //ASSERT
            Assert.AreEqual(expected, actual);

        }
    }
}
