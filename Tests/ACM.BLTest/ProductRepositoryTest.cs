using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void ProductRetrieveTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers"
            };

            

            //Act
            var actual = productRepository.Retrieve(2);

            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {actual.ToString()}");
            //Assert
            Assert.Equivalent(expected, actual);

        }

        [Fact]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository=new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //Act
            var actual= productRepository.Save(updatedProduct);
            //Assert

            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName="Sunflowers",
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updatedProduct);
            //Assert
            Assert.False(actual);

        }

    }
}
