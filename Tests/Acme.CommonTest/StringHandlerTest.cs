using Acme.Common;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid ()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            
            //Act 
            var actual = source.InsertSpaces();

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void InsertSpacesTestWithExistingSpace()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}