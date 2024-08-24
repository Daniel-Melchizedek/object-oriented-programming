using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerRepositorTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //Arrange
            CustomerRepository customerRepository = new();
            Customer expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            //Act
            var actual = customerRepository.Retrieve(1);
            //Assert
            Assert.Equivalent(expected, actual);

        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            //Arrange
            CustomerRepository customerRepository = new();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
            {
                new Address(1) {
                AddressType = 1,
                StreetLine1="Bag End",
                StreetLine2="Bagshot row",
                City="Hobbiton",
                State="Shire",
                Country="Middle Earth",
                PostalCode="144"
                },
                new Address(2) {
               AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
                }
            }

            };
            //Act
            var actual = customerRepository.Retrieve(1);
            
            //Assert
            Assert.Equivalent(expected, actual);



    }
    }
}
