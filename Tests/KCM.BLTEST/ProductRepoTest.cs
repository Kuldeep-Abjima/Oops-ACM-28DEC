using KCM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KCM.BLTEST
{
    [TestClass]
    public class ProductRepoTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size set of 4 bright yellow mini sunflowers",
                ProductName = "Sunflower",
            };
            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription,actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }
    }
}
