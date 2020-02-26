using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method

            // Arrange
            double expectedTotal = num1 + num2;

            // Act
            double returnedTotal = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedTotal, returnedTotal);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Use a few pairs of values to test the Multiply method

            // Arrange
            double num1 = 0.0;
            double num2 = 15.0;
            double num3 = 2.5;
            double num4 = 1.0;
            double expectedProduct12 = num1 * num2;
            double expectedProduct23 = num2 * num3;
            double expectedProduct34 = num3 * num4;

            // Act
            double returnedProduct12 = SimpleMath.Multiply(num1, num2);
            double returnedProduct23 = SimpleMath.Multiply(num2, num3);
            double returnedProduct34 = SimpleMath.Multiply(num3, num4);

            // Assert
            Assert.AreEqual(expectedProduct12, returnedProduct12);
            Assert.AreEqual(expectedProduct23, returnedProduct23);
            Assert.AreEqual(expectedProduct34, returnedProduct34);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"

            // Arrange
            double numerator = 5.0;
            double denominator = 0.0;
            double expectedQuotient = numerator / denominator;

            // Assert => Act
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(numerator, denominator));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(50.0, 10.0)]
        [DataRow(20.0, 100.0)]
        [DataRow(-15.0, -5.0)]
        public void Divide_TwoNumbers_ReturnsQuotient(double numerator, double denominator)
        {
            // Arrange
            double expectedQuotient = numerator / denominator;

            // Act
            double returnedQuotient = SimpleMath.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(expectedQuotient, returnedQuotient);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(25.0, 25.0)]
        [DataRow(20.0, 10.0)]
        [DataRow(-10.0, -5.0)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            // Arrange
            double expectedDifference = num1 - num2;

            // Act
            double returnedDifference = SimpleMath.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedDifference, returnedDifference);
        }
    }
}