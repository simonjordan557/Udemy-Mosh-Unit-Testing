using NUnit.Framework;
using System.Collections;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
   
    public class MathTests
    {
        private Math _math;
        int a;
        int b;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Testing the ignore attribute.")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            // Arrange
            

            // Act
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnsGreater(int a, int b, int expectedResult)
        {
            // Arrange

            // Act
            var result = _math.Max(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(5)]
        [TestCase(8)]
        public void GetOddNumbers_WhenCalled_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit(int limit)
        {
            // Arrange

            // Act
            var result = _math.GetOddNumbers(limit);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Does.Contain(1));
            if (limit % 2 != 0)
            {
                Assert.That(result.Last, Is.EqualTo(limit));
            }
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void GetOddNumbers_WhenCalled_LimitIsLessThanOrEqualToZero_ReturnEmptyCollection(int limit)
        {
            // Arrange

            // Act
            var result = _math.GetOddNumbers(limit);

            // Assert
            Assert.That(result, Is.Empty);
        }

    }
}
