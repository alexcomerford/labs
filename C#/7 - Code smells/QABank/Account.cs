using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class Account
    {
        private double balance;
        private string accountType;
      
        public void WithDraw(double amount)
        {
            if (amount > balance && accountType == "deposit")
                return;
            balance -= amount;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
    }
}
