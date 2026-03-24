using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMultiLevelInheritance
{
    internal class SavingsAccount : Account
    {
        public decimal InterestRate;

        public SavingsAccount(string accNo, string name, decimal balance, decimal interest)
            : base(accNo, name, balance)
        {
            InterestRate = interest;
        }

        public void AddInterest()
        {
            decimal interest = Balance * InterestRate / 100;
            Balance += interest;
            Console.WriteLine($"Interest Added : {interest}");
            Console.WriteLine($"New Balance    : {Balance}");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Interest Rate : {InterestRate}%");
        }
    }
}
