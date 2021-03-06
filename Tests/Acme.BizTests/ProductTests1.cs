using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests1
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arange
            var currentProduct = new Product();

            //Act
            currentProduct.ProductName = "Saw";
            currentProduct.ProductId = 1;
            currentProduct.Description = "15-inch steel blade hand saw";
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";
            var actual = currentProduct.SayHello();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}