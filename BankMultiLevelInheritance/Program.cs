namespace BankMultiLevelInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("============= Account ===========");
            Account a = new Account("ACC001", "Rahul", 10000);
            a.Display();
            a.Deposit(5000);
            a.Withdraw(3000);

            Console.WriteLine("\n=========== Savings Account ==========");
            SavingsAccount s = new SavingsAccount("ACC002", "Priya", 20000, 5);
            s.Display();
            s.Deposit(2000);
            s.AddInterest();

            Console.WriteLine("\n======== Premium Savings =========");
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

