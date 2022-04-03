using NUnit.Framework;

namespace FizzBuzzTest
{
    /*
     * Convert an integer to string
     * Return Fizz if divisible by 3
     * Return Buzz if divisible by 5
     * Return FizzBuzz if divisible by 3 and 5
     */
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertIntegerToString()
        {
            var sut = new FizzBuzzConverter();
            var actualResult = sut.Convert(1);
            Assert.AreEqual("1", actualResult);
        }

        [Test]
        public void ReturnFizzBuzzIfDivisibleBy5And3()
        {
            var sut = new FizzBuzzConverter();
            var actualResult = sut.Convert(15);
            Assert.AreEqual("FizzBuzz", actualResult);
        }

        [Test]
        public void ReturnFizzIfDivisibleBy3()
        {
            var sut = new FizzBuzzConverter();
            var actualResult = sut.Convert(3);
            Assert.AreEqual("Fizz", actualResult);
        }

        [Test]
        public void ReturnBuzzIfDivisibleBy5()
        {
            var sut = new FizzBuzzConverter();
            var actualResult = sut.Convert(5);
            Assert.AreEqual("Buzz", actualResult);
        }
    }
}