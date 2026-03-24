using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMultiLevelInheritance
{
    internal class SavingsAccount : Account
    {
        public double InterestRate;

        public SavingsAccount(string accNo, string name, double balance, double interest)
            : base(accNo, name, balance)
        {
            InterestRate = interest;
        }

        public void AddInterest()
        {
            double interest = Balance * InterestRate / 100;
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
