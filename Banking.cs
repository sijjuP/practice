using System;
using System.Collections.Generic;

namespace BankSpace
{
    public class BankAccount
    {
        private decimal balance=100;
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
                balance -= amount;
        }
        public void Balance()
        {
            Console.WriteLine("Balance=" +balance);
        }
    }
    
}