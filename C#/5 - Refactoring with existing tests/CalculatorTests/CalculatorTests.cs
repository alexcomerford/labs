using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAShopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAShopping.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTestTwoNum()
        {
            Calculator c1 = new Calculator();
            int answer = c1.Add(23, 32);
            Assert.AreEqual(55, answer);
        }
        [TestMethod()]
        public void AddTestThreeNum()
        {
            Calculator c1 = new Calculator();
            int answer = c1.Add(23, 32, 34);
            Assert.AreEqual(89, answer);
        }
        [TestMethod()]
        public void AddTestOneNum()
        {
            Calculator c1 = new Calculator();
            int answer = c1.Add(23);
            Assert.AreEqual(23, answer);
        }
        [TestMethod()]
        public void AddTestZeroNum()
        {
            Calculator c1 = new Calculator();
            int answer = c1.Add();
            Assert.AreEqual(0, answer);
        }
    }
}