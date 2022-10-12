using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    class DepositAccount:Account
    {
        private double balance;
        public void AddInterestToAccount()
        { 
            balance += balance * 0.0001;
        }
    }
}
