using Microsoft.VisualStudio.TestTools.UnitTesting;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [DataTestMethod]
        [DataRow(1, false)]
        [DataRow(2, true)]
        [DataRow(4, true)]
        [DataRow(500, true)]
        public void isEvenTest(int n, bool b)
        {
            Calculate c = new Calculate();
            bool result = c.isEven(n);
            Assert.AreEqual(b, result);
        }

        [TestMethod]
        public void TestEvenManual()
        {
            Calculate c = new Calculate();
            Assert.AreEqual(true, c.isEven(20));
            
        }
    }
}


