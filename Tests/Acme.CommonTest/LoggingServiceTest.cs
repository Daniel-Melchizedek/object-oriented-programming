using ACM.BL;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CommonTest
{
    public class LoggingServiceTest
    {
        [Fact]
        public void WriteToFile_Test()
        {
            //Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);
            
            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert
            //Noting here to assert.
            
        }
    }
}
