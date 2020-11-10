using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    public class CustomerControllerTests
    {
        private CustomerController _controller;
        [SetUp]
        public void SetUp()
        {
            _controller = new CustomerController();
        }

        [Test]
        [TestCase(0)]
        public void GetCustomer_WhenIDIsZero_ReturnsNotFound(int id)
        {
            // Arrange

            // Act
            var result = _controller.GetCustomer(id);
            // Assert
            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        [TestCase(1)]
        public void GetCustomer_WhenIDIsNotZero_ReturnsOk(int id)
        {
            // Arrange

            // Act
            var result = _controller.GetCustomer(id);
            // Assert
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
