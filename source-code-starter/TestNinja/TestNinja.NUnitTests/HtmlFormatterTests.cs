using NUnit.Framework;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    class HtmlFormatterTests
    {
        private HtmlFormatter _formatter;
        string testString;

        [SetUp]
        public void SetUp()
        {
            _formatter = new HtmlFormatter();
        }

        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseArgumentInStrongElement()
        {
            // Arrange
            testString = "test";

            // Act
            var result = _formatter.FormatAsBold(testString);
            // Assert
            Assert.That(result, Is.EqualTo($"<strong>{testString}</strong>").IgnoreCase);
            
        }

    }
}
