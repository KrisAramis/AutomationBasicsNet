﻿using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TestsforCalculator
    {
        private Calculator _calculator;

        [OneTimeSetUp]
        public void ClassInitialize()
        {
            Console.WriteLine("Class init");
        }

        [SetUp]
        public void TestInitialize()
        {
            _calculator = new Calculator();
        }

        [TestCase(3,4,7)]
        [Test]
        public void SumPositiveTest(double firstNumber, double secondNumber, double expectedSum)
        {
            var actualSum = _calculator.Add(firstNumber,secondNumber);
            Assert.AreEqual(actualSum, expectedSum);
        }

        [Test]
        [TestCase(3,0,0)]
        public void MultiplyReturnCorrectResultTest(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = _calculator.Multiply(firstNumber, secondNumber);
            Assert.AreEqual(actualResult,expectedResult);
        }

        [Test]
        public void SubNegativeTest()
        {
            double firstNumber = -3;
            double secondNumber = 3;
            double notValidResult = 6;
            double actualResult = _calculator.Sub(firstNumber, secondNumber);
            Assert.False(actualResult.Equals(notValidResult));
        }

        [Test]
        public void AbsReturnsCorrectResultTest()
        {
            double a = -11;
            double actualResult = _calculator.Abs(a);
            Assert.False(actualResult.Equals(a));
        }

        [TestCase(22, 11, 2)]
        public void DevideTest(double firstNumber, double secondNumber, double expectedQuotient)
        {
            var actualQuotient = _calculator.Divide(firstNumber, secondNumber);
            Assert.AreEqual(actualQuotient,expectedQuotient);
        }

        [Test]
        [TestCase(2,8)]
        public void PowThrowsNotFiniteNumberException(double a, double b)
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Pow(a, b));
        }
        [TestCase(4, 2)]
        public void SqrtTest(double number, double expectedSqrt)
        {
            var actualSqrt = _calculator.Sqrt(number);
            Assert.AreEqual(actualSqrt,expectedSqrt);
        }

        [TestCase(90, 0.89399666360055785)]
        public void SinTest(double angle, double expectedResult)
        {
            double actualResult = Math.Sin(angle);
            Assert.AreEqual(actualResult,expectedResult);
        }

        [Test]
        public void NegativeValueExceptionTest()
        {
            string number = "some";
            Assert.Throws<NotFiniteNumberException>(() => _calculator.isNegative(number));
        }
    }
}
