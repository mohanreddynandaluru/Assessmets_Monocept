namespace BankMultiLevelInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========== Account ==========");
            Account a = new Account("ACC001", "Rahul", 10000);
            a.Display();
            a.Deposit(5000);
            a.Withdraw(3000);

            Console.WriteLine("\n========== Savings Account ==========");
            SavingsAccount s = new SavingsAccount("ACC002", "Priya", 20000, 5);
            s.Display();
            s.Deposit(2000);
            s.AddInterest();

            Console.WriteLine("\n========== Premium Savings ==========");
            PremiumSavings p = new PremiumSavings("ACC003", "Arjun", 50000, 7, "Platinum");
            p.Display();

            Console.WriteLine("\n--- Transaction 1: Deposit ---");
            p.Deposit(10000);

            Console.WriteLine("\n--- Transaction 2: Withdraw ---");
            p.Withdraw(5000);

            Console.WriteLine("\n--- Transaction 3: Deposit ---");
            p.Deposit(8000);

            Console.WriteLine("\n--- Transaction 4: Withdraw ---");
            p.Withdraw(2000);

            Console.WriteLine("\n--- Adding Interest ---");
            p.AddInterest();

            Console.WriteLine("\n--- Redeeming Points ---");
            p.RedeemLoyaltyPoints(30);

            Console.WriteLine("\n--- Final Details ---");
            p.Display();
        }
    }
}




//using System;

//// Level 1 - Base Class
//class Account
//{
    
//    }
//}

//// Level 2 - Inherits from Account
//class SavingsAccount : Account
//{
    
//}

//// Level 3 - Inherits from SavingsAccount
//class PremiumSavings : SavingsAccount
//{
    
//}

//// Main Program
//class Program
//{
//    static void Main(string[] args)
//    {
        
//    }
//}
//```

//---

//## Output:
//```
//========== Account ==========
//Account No  : ACC001
//Holder Name : Rahul
//Balance     : 10000
//Deposited      : 5000
//New Balance    : 15000
//Withdrawn      : 3000
//Remaining Balance: 12000

//========== Savings Account ==========
//Account No  : ACC002
//Holder Name : Priya
//Balance     : 20000
//Interest Rate : 5%
//Deposited      : 2000
//New Balance    : 22000
//Interest Added : 1100
//New Balance    : 23100

//========== Premium Savings ==========
//Account No  : ACC003
//Holder Name : Arjun
//Balance     : 50000
//Interest Rate : 7%
//Card Type      : Platinum
//Loyalty Points : 0

//--- Transaction 1: Deposit ---
//Deposited      : 10000
//New Balance    : 60000
//Points Earned  : 10 (Deposit Reward)
//Total Points   : 10

//--- Transaction 2: Withdraw ---
//Withdrawn      : 5000
//Remaining Balance: 55000
//Points Earned  : 5 (Transaction Reward)
//Total Points   : 15

//--- Transaction 3: Deposit ---
//Deposited      : 8000
//New Balance    : 63000
//Points Earned  : 10 (Deposit Reward)
//Total Points   : 25

//--- Transaction 4: Withdraw ---
//Withdrawn      : 2000
//Remaining Balance: 61000
//Points Earned  : 5 (Transaction Reward)
//Total Points   : 30

//--- Adding Interest ---
//Interest Added : 4270
//New Balance    : 65270

//--- Redeeming Points ---
//Redeemed Points : 30
//Cash Added      : Rs.15
//Remaining Points: 0
//New Balance     : 65285

//--- Final Details ---
//Account No  : ACC003
//Holder Name : Arjun
//Balance     : 65285
//Interest Rate : 7%
//Card Type      : Platinum
//Loyalty Points : 0