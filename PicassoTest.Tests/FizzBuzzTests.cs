using NUnit.Framework;

namespace PicassoTest.Tests
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup() {}

        [Test]
        public void GetOutput_DivisibleBy3_ReturnsFizz()
        {
            var number = 9;

            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_DivisibleBy5_ReturnsBuzz()
        {
            var number = 10;

            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_DivisibleBy3And5_ReturnsFizzBuzz()
        {
            var number = 15;

            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NotDivisibleBy3And5_ReturnsNumber()
        {
            var number = 14;

            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo(""+number));
        }

        [Test]
        public void GetOutput_NegativeButDivisibleBy3_ReturnsFizz()
        {
            var number = -3;

            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_NegativeButDivisibleBy5_ReturnsBuzz()
        {
            var number = -5;

            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NegativeButDivisibleBy3And5_ReturnsFizzBuzz()
        {
            var number = -15;

            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NegativeButNotDivisibleBy3And5_ReturnsNumber()
        {
            var number = -14;

            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo(""+number));
        }
    }
}
