using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
               
            };
            string expected = "Bilbo";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                
                LastName = "Baggins"
            };
            string expected = "Baggins";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void StaticTest()
        {
            //Arrange
            Customer c1 = new()
            {
                FirstName = "Bilbo"
            };

            Customer.InstanceCount += 1;

            Customer c2 = new()
            {
                FirstName = "Frodo"
            };

            Customer.InstanceCount += 1;

            Customer c3 = new()
            {
                FirstName = "Rosie"
            };

            Customer.InstanceCount += 1;

            //Act
            //Assert
            Assert.Equal(3, Customer.InstanceCount);

        }

        [Fact]
        public void ValidateValid() 
        {
            //Arrange
            Customer customer = new()
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };
            bool expected = true;
           //Act 
           bool actual = customer.Validate();
           //Assert
           Assert.Equal(expected, actual);
        }


        [Fact]
        public void ValidateMissingLastName()
        {
            //Arrange
            Customer customer = new()
            {
               
                EmailAddress = "fbaggins@hobbiton.me"
            };
            bool expected = false;
            //Act 
            bool actual = customer.Validate();
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}