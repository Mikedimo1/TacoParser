using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.22997, -86.805275, Taco Bell Alabaste...", -86.805275)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...", -84.10353)]
        [InlineData("34.280205, -86.217115, Taco Bell Albertvill...", -86.217115)]
        [InlineData("34.071477, -84.296345, Taco Bell Alpharett...", -84.296345)]
        [InlineData("34.047374, -84.223918, Taco Bell Alpharetta...", -84.223918)]

        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location
            
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);
            var longitude = actual.Location.Longitude;

            //Assert
            Assert.Equal(expected, longitude);
        }

        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.22997, -86.805275, Taco Bell Alabaste...", 33.22997)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...", 31.570771)]
        [InlineData("34.280205, -86.217115, Taco Bell Albertvill...", 34.280205)]
        [InlineData("34.071477, -84.296345, Taco Bell Alpharett...", 34.071477)]
        [InlineData("34.047374, -84.223918, Taco Bell Alpharetta...", 34.047374)]
        public void ShouldParseLatitude(string line, double expected)
        {
           //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);
            var latitude = actual.Location.Latitude;

            //Assert
            Assert.Equal(expected, latitude);
        }
       

    }
}
