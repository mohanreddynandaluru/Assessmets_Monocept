using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofAccounts
{
    internal class Account
    {
        private string _AccountNumber;
        private string _AccountName;
        private double _Balance;
        private string _AccountType;

        public string AccountNumber
        {
            get { return _AccountNumber; }
        }

        public string AccountName
        {
            get { return _AccountName; }
        }

        public double Balance
        {
            get { return _Balance; }
        }

        public string AccountType
        {
            get { return _AccountType; }
        }

        public Account(string accountNumber, string accountName, double balance, string accountType)
        {
            _AccountNumber = accountNumber;
            _AccountName = accountName;
            _Balance = balance;
            _AccountType = accountType;
        }

        public void Deposit(double amount)
        {
            _Balance += amount;
            Console.WriteLine("Amount Deposited Successfully.");
        }

        public void Withdraw(double amount)
        {
            if (_Balance - amount < 0)
            {
                Console.WriteLine("insufficient Balance");
            }
            else
            {
                _Balance -= amount;
                Console.WriteLine("Withdrawal Successful.");
            }
        }
    }
}
