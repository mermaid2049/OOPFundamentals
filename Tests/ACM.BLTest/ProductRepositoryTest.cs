using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var productRepositry = new ProductRepository();
            var expected = new Product(2)

            {
                CurrentPrice=15.96M,
                ProductDescription= "Assoreted Size set of 4 Yellow Mini Sunflowers",
                ProductName= "Sunflowers"
            };


            //Act
            var actual = productRepositry.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }
    }
}