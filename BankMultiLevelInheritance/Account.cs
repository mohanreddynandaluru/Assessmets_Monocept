using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMultiLevelInheritance
{
    internal class Account
    {
        public string AccountNumber;
        public string HolderName;
        public double Balance;

        public Account(string accNo, string name, double balance)
        {
            AccountNumber = accNo;
            HolderName = name;
            Balance = balance;
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited      : {amount}");
            Console.WriteLine($"New Balance    : {Balance}");
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > Balance)
                Console.WriteLine("Insufficient Balance!");
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn      : {amount}");
                Console.WriteLine($"Remaining Balance: {Balance}");
            }
        }

        public virtual void Display()
        {
            Console.WriteLine($"Account No  : {AccountNumber}");
            Console.WriteLine($"Holder Name : {HolderName}");
            Console.WriteLine($"Balance     : {Balance}");
        }
    }
}
