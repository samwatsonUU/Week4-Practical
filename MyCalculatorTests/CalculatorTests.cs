using MyTestLibrary;
using System.Security.AccessControl;

namespace MyCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 20;

            // Act
            double result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 20;
            double b = 10;

            // Act
            double result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(10, result);


        }

        [TestMethod]
        public void Multiply_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 5;

            // Act
            double result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(50, result);


        }

        [TestMethod]
        public void Divide_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Division_DivideByNegativeNumber()
        {
            // Arrange
            var calculator = new Calculator();
            double a = -10;
            double b = -2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Division_DividePositiveByNegative()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = -2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(-5, result);
        }

        /*      //Check solution!

        [TestMethod]
        public void Division_DivideByZero()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 0;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.ThrowsException<DivideByZeroException>(() => result);
            
        }

        */

        [TestMethod]
        public void Add_LargeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = double.MaxValue;
            double b = double.MaxValue;

            // Act
            double result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(double.MaxValue*2, result);
        }

        [TestMethod]
        public void Divide_SmallNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = double.MinValue;
            double b = double.MinValue;

            // Act
            double result = calculator.Divide(a, b);

            // Assert#
            Assert.AreEqual(double.MinValue/ double.MinValue, result);
        }

        [TestMethod]
        public void Subtract_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = -5;
            double b = -5;

            // Act
            double result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_MixedSignNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = +20;
            double b = -43;

            // Act
            double result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(-860, result);
        }



    }
}