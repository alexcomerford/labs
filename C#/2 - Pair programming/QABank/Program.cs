using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("Alex Comerford",10, 100.50);

            BankAccount b2 = new BankAccount("James Smith", 500.50);

            BankAccount b3 = new BankAccount("Holly Hope", 2500);
            b1.Display();
            b2.Display();
            b3.Display();
            Console.ReadLine();
        }
    }

    class BankAccount
    {
        string Customer;
        public int AccountNumber = 100000;
        double Balance;

        public BankAccount(string customer, int accountnumber, double balance)
        {
            Customer = customer;
            AccountNumber = accountnumber;
            Balance = balance;
        }
        public BankAccount(string customer, double balance)
        {
            Customer = customer;
            AccountNumber++;
            Balance = balance;
        }

        public int Deposit(int amount)
        {
            return (int)(Balance + amount);
        }

        public int Withdraw(int amount)
        {
            return (int)(Balance - amount);
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Customer + " Account Number: " + AccountNumber + " Balance: " + Balance);
        }
    }

}
