using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class Calculate
    {
        public bool isEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}