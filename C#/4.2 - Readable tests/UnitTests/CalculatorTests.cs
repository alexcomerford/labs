using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        public CalculatorTests()
        {

        }

        ~CalculatorTests()
        {
           
        }

        [Test]
        public void SubtractWithPositiveNumber()
        {
            var calculator = new Calculator();
            int expected = 2;
            int actual = calculator.Subtract("5,3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractWithNegativeNumber()
        {
            var calculator = new Calculator();
            int expected = -8;
            int actual = calculator.Subtract("-5,3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractWithPositiveNumber2()
        {
            var calculator = new Calculator();
            int expected = 2;
            int actual = calculator.Subtract("4,2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideWithPositiveNumber()
        {
            var calculator = new Calculator();
            int expected = 5;
            int actual = calculator.Divide("10,2");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DivideWithNegativeNumber()
        {
            var calculator = new Calculator();
            int expected = -5;
            int actual = calculator.Divide("10,-2");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MultiplyWithPositiveNumber()
        {
            var calculator = new Calculator();
            int expected = 50;
            int actual = calculator.Multiply("25,2");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MultiplyWithPositiveNumber2()
        {
            var calculator = new Calculator();
            int expected = 600;
            int actual = calculator.Multiply("150,4");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideWithZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide("10,0"));
        }
    }
}
