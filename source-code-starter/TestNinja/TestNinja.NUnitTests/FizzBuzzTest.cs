using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    class FizzBuzzTest
    {
        [Test]
        public void GetOutput_WhenNumberIsDivisibleBy3And5_ReturnsFizzBuzz()
        {
            string result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_WhenNumberIsDivisibleBy3ButNot5_ReturnsFizz()
        {
            string result = FizzBuzz.GetOutput(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_WhenNumberIsDivisibleBy5ButNot3_ReturnsBuzz()
        {
            string result = FizzBuzz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_WhenNumberIsDivisibleByNeither3Nor5_ReturnNumberAsString()
        {
            string result = FizzBuzz.GetOutput(7);

            Assert.That(result, Is.EqualTo("7"));
        }
    }
}
