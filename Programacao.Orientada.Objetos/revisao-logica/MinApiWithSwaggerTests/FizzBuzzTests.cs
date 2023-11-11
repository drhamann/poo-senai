using Xunit;

namespace MinApiWithSwagger.Controllers.Tests
{
    public class FizzBuzzTests
    {
        [Fact()]
        public void CalculateTest()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();
            var expectedFizzBuzzResult = new List<string>()
            {
                "1","2"
            };


            //Act
            var result = fizzBuzz.Calculate(2);

            //Assert
            Assert.Equivalent(expectedFizzBuzzResult.ToArray(), result);
        }

        [Fact()]
        public void CalculateTestFizz()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();
            var expectedFizzBuzzResult = new List<string>()
            {
                "1","2","Fizz"
            };


            //Act
            var result = fizzBuzz.Calculate(3);

            //Assert
            Assert.Equivalent(expectedFizzBuzzResult.ToArray(), result);
        }

        [Fact()]
        public void CalculateTestBuzz()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();
            var expectedFizzBuzzResult = new List<string>()
            {
                "1","2","Fizz","4","Buzz"
            };


            //Act
            var result = fizzBuzz.Calculate(5);

            //Assert
            Assert.Equivalent(expectedFizzBuzzResult.ToArray(), result);
        }

        [Fact()]
        public void CalculateTestFizzBuzz()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();
            var expectedFizzBuzzResult = new List<string>()
            {
                "1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"
            };


            //Act
            var result = fizzBuzz.Calculate(15);

            //Assert
            Assert.Equivalent(expectedFizzBuzzResult.ToArray(), result);
        }
    }
}