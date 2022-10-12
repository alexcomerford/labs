using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    class CurrentAccount:Account
    {
        private double overdraftLimit;
        private List<Payee> directDebits = new List<Payee>();
        private List<Payee> standingOrders = new List<Payee>();

        public bool IsOverDrawn()
        {
            return false;
        }
        // used where account is current account
        public void SetOverdraftLimit(double overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;
        }
        // used where account is current account
        public void ProcessDirectDebits()
        {
            foreach (Payee payee in directDebits)
            {
            }
        }
        // used where account is current account
        public void ProcessStandingOrders()
        {
            foreach (Payee payee in standingOrders)
            {
            }
        }
    }
}
