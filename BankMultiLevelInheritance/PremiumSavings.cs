using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMultiLevelInheritance
{
    internal class PremiumSavings : SavingsAccount
    {
        public string CardType;
        public int LoyaltyPoints;

        // Points earned per transaction
        private const int PointsPerDeposit = 10;   // 10 points per deposit
        private const int PointsPerWithdraw = 5;    // 5 points per withdrawal

        public PremiumSavings(string accNo, string name, decimal balance, decimal interest, string cardType)
            : base(accNo, name, balance, interest)
        {
            CardType = cardType;
            LoyaltyPoints = 0;
        }

        // Override Deposit - earn points on every deposit
        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);
            LoyaltyPoints += PointsPerDeposit;
            Console.WriteLine($"Points Earned  : {PointsPerDeposit} (Deposit Reward)");
            Console.WriteLine($"Total Points   : {LoyaltyPoints}");
        }

        // Override Withdraw - earn points on every withdrawal
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance!");
            }
            else
            {
                base.Withdraw(amount);
                LoyaltyPoints += PointsPerWithdraw;
                Console.WriteLine($"Points Earned  : {PointsPerWithdraw} (Transaction Reward)");
                Console.WriteLine($"Total Points   : {LoyaltyPoints}");
            }
        }

        // Redeem loyalty points as cash
        public void RedeemLoyaltyPoints(int points)
        {
            if (points > LoyaltyPoints)
            {
                Console.WriteLine("Not Enough Points to Redeem!");
            }
            else
            {
                LoyaltyPoints -= points;
                decimal cashValue = points * 0.1m; // 1 point = 0.1 currency unit per point
                Balance += cashValue;
                Console.WriteLine($"Redeemed Points : {points}");
                Console.WriteLine($"Cash Added      : Rs.{cashValue}");
                Console.WriteLine($"Remaining Points: {LoyaltyPoints}");
                Console.WriteLine($"New Balance     : {Balance}");
            }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Card Type      : {CardType}");
            Console.WriteLine($"Loyalty Points : {LoyaltyPoints}");
        }
    }
}
