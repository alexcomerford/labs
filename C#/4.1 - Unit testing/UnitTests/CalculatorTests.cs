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
        [Test]
        public void Subtract_ValidString_CalculatesResult()
        {
            Calculator c1 = new Calculator();            
            Assert.AreEqual(10, c1.Subtract("50,40"));
           
        }
        [Test]
        public void Multiply_ValidString_CalculatesResult()
        {
            Calculator c1 = new Calculator();
            Assert.AreEqual(100, c1.Multiply("10,10"));
            
        }
        [Test]
        public void Divide_ValidString_CalculatesResult()
        {
            Calculator c1 = new Calculator();
            Assert.AreEqual(5, c1.Divide("50,10"));

        }
        [Test]
        public void Divide_ByZero_CalculatesResult()
        {
            Calculator c1 = new Calculator();
            Assert.AreEqual(Expected,c1.Divide("50,0");

        }
    }
}
