using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAShopping
{
    public class Calculator
    {        public int Add(params int[] num)
        {
            int sum = 0;
            foreach (int i in num)
            {
                sum += i;
            }
            return sum;
        }

    }
}