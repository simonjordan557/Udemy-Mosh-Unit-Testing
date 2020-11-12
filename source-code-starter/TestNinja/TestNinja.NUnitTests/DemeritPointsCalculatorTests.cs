using TestNinja.Fundamentals;
using NUnit.Framework;
using System;

namespace TestNinja.NUnitTests
{
    class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calc;

        [SetUp]
        public void SetUp()
        {
            _calc = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-10)]
        [TestCase(600)]
        public void CalculateDemeritPoints_SpeedLessThanZeroOrGreaterThanMax_ShouldThrowException(int speed)
        {
            Assert.That(() => _calc.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0)]
        [TestCase(30)]
        [TestCase(65)]
        public void CalculateDemeritPoints_SpeedIsLessThanOrEqualToLimit_ShouldReturnZero(int speed)
        {
            var result = _calc.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(70, 1)]
        [TestCase(100, 7)]
        [TestCase(66, 0)]
        [TestCase(72, 1)]
        [TestCase(300, 47)]
        public void CalculateDemeritPoints_SpeedGreaterThanLimit_ShouldReturnDemeritPoints(int speed, int expectedResult)
        {
            var result = _calc.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
