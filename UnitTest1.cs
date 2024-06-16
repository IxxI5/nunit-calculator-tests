using NUnit.Framework;
using CalculatorApp;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up resources if needed.
        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            // Arrange
            int a = 1, b = 2;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsDifferenceOfArguments()
        {
            // Arrange
            int a = 5, b = 3;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsProductOfArguments()
        {
            // Arrange
            int a = 4, b = 5;

            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Divide_WhenCalledWithNonZeroDenominator_ReturnsQuotient()
        {
            // Arrange
            int a = 10, b = 2;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5.0));
        }

        [Test]
        public void Divide_WhenCalledWithZeroDenominator_ThrowsDivideByZeroException()
        {
            // Arrange
            int a = 10, b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [TestCase(1, 2, 3)]
        [TestCase(-1, -2, -3)]
        [TestCase(0, 0, 0)]
        public void Add_WithMultipleInputs_ReturnsExpectedResults(int a, int b, int expectedResult)
        {
            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(5, 3, 2)]
        [TestCase(-5, -3, -2)]
        [TestCase(0, 0, 0)]
        public void Subtract_WithMultipleInputs_ReturnsExpectedResults(int a, int b, int expectedResult)
        {
            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(2, 3, 6)]
        [TestCase(-2, -3, 6)]
        [TestCase(0, 5, 0)]
        public void Multiply_WithMultipleInputs_ReturnsExpectedResults(int a, int b, int expectedResult)
        {
            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(6, 2, 3.0)]
        [TestCase(-6, -2, 3.0)]
        [TestCase(5, 2, 2.5)]
        public void Divide_WithMultipleInputs_ReturnsExpectedResults(int a, int b, double expectedResult)
        {
            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
