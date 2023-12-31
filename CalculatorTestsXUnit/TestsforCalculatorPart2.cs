using System.Runtime.CompilerServices;
using CSharpCalculator;
using Xunit;
using Xunit.Sdk;

namespace CalculatorTestsXUnit
{
    public class TestsforCalculatorPart2
    {
        private Calculator _calculatorInstance;

        public TestsforCalculatorPart2()
        {
            _calculatorInstance = new Calculator();
        }

        [Fact]
        public void NotNegativeFalseTest()
        {
            object a = 4;
            bool result = _calculatorInstance.isNegative(a);
            Assert.False(result);
        }

        [Fact]
        public void PositiveCatchExceptionTest()
        {
            string a = "summer";
            Assert.Throws<NotFiniteNumberException>(() => _calculatorInstance.isPositive(a));
        }

        [Fact]
        public void AbsReturnsCorrectTest()
        {
            double expected = 3;
            object a = -3;
            double result = _calculatorInstance.Abs(a);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubReturnsCorrectTest()
        {
            double a = 0;
            double b = 3;
            double actualResult = _calculatorInstance.Sub(a, b);
            double expectedResult = -3;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void CosReturnsCorrectRusult()
        {
            double angle = -30;
            double expectedResult = Math.Cos(angle);
            double actualResult = _calculatorInstance.Cos(angle);
            Assert.True(actualResult == expectedResult);
        }

        [Theory]
        [InlineData(2, 3)]
        public void PowReturnsCorrectResultTest(int firstNumber, double secondNumber)
        {
            double expectedResult = 8;
            double actualResult = _calculatorInstance.Pow(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(2, 1)]
        public void AddReturnsCorrectResultTest(double firstNumber, double secondNumber)
        {
            double expectedResult = 3;
            double actualResult = _calculatorInstance.Add(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void CheckCosExceptionTest()
        {
            string a = "tree";
            Assert.Throws<NotFiniteNumberException>(() => _calculatorInstance.Cos(a));
        }

        [Theory]
        [InlineData(2, 3, 4)]
        public void CheckNegativeMultiplyTest(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = _calculatorInstance.Multiply(firstNumber, secondNumber);
            Assert.NotEqual(actualResult, expectedResult);
        }

        [Fact]
        public void CheckSqrtTest()
        {
            double expectedResult = 4;
            double number = 16;
            double actualResult = _calculatorInstance.Sqrt(number);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(2, 0)]
        public void DivideReturnsNotIntTest(double firstNumber, double secondNumber)
        {
            var expectedResult = _calculatorInstance.Divide(firstNumber, secondNumber);
            Assert.IsNotType<Int16>(expectedResult);
        }
    }
}