using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    [TestFixture]
    class CalcTests
    {
        [TestCase]
        public void Add()
        {
            Test t1 = new Test();
            Assert.AreEqual(20, t1.Add(10, 10));
        }
    }
}

