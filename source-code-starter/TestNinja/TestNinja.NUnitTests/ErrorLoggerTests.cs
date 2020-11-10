using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    public class ErrorLoggerTests
    {
        private ErrorLogger _errorLogger;

        [SetUp]
        public void SetUp()
        {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_ShouldSetLastErrorProperty()
        {
            _errorLogger.Log("Hello");

            Assert.That(_errorLogger.LastError, Is.EqualTo("Hello"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_WhenErrorIsNullOrWhiteSpace_ThrowException(string error)
        {
           

            Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaisesErrorLoggedEvent()
        {
            var id = Guid.Empty;
            _errorLogger.ErrorLogged += (sender, args) => { id = args; };
            _errorLogger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
