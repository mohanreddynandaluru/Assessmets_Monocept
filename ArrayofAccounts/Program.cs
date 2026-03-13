namespace ArrayofAccounts
{
    class Program
    {

        public static string GenerateAccountNummber(Account[] Accounts,int n)
        {
            Random rd = new Random();

            string accountNumber;

            while (true)
            {
                accountNumber = "IDBI1000" + rd.Next(100000, 999999);

                bool exists = false;

                for(int i=0;i<n; i++)
                {
                    if(Accounts[i] != null && Accounts[i].AccountNumber == accountNumber)
                    {
                        exists = true;
                        break;
                    }
                }

                if(!exists)
                {
                    return accountNumber;
                }
            }
        }

        public static Account FindAccount(Account[] accounts, string accountNumber,int n)
        {
            for(int i=0; i<n; i++)
            {
                if(accounts[i] != null && accounts[i].AccountNumber == accountNumber)
                {
                    return accounts[i];
                }
            }
            return null;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Account[] accounts = new Account[3];
            int NoOfAccounts = 0;
            bool next = false;

            do
            {
                Console.WriteLine("\n1. Create Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (NoOfAccounts >= 3)
                        {
                            Console.WriteLine("Account storage full.");
                            break;
                        }
                        Console.WriteLine("Enter Account Holder Name");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter the Type of Account (saving/current)");
                        string AccountType = Console.ReadLine();

                        if(AccountType.ToLower() != "savings" && AccountType.ToLower() != "current")
                        {
                            Console.WriteLine("Invalid Account Type");
                            break;
                        }

                        Console.Write("Enter Initial Balance: ");
                        double bal = Convert.ToDouble(Console.ReadLine());

                        if (bal < 0)
                        {
                            Console.WriteLine("Initial balance cannot be negative.");
                            break;
                        }

                        string AccountNumber = GenerateAccountNummber(accounts, NoOfAccounts);

                        accounts[NoOfAccounts] = new Account(AccountNumber, name, bal, AccountType);

                        NoOfAccounts++;

                        Console.WriteLine("Account Created Successfully");
                        Console.WriteLine("Your Account Number is {0}", AccountNumber);

                        break;

                    case 2:
                        Console.WriteLine("Enter Account Number");
                        string acc = Console.ReadLine();

                        Account accObj = FindAccount(accounts, acc, NoOfAccounts);

                        if (accObj != null)
                        {
                            Console.WriteLine($"Balance: {accObj.Balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Account not Found");
                        }
                        break;
                    case 3:
                        Console.Write("Enter Account Number: ");
                        acc = Console.ReadLine();

                        accObj = FindAccount(accounts, acc, NoOfAccounts );

                        if (accObj != null)
                        {
                            Console.Write("Enter Deposit Amount: ");
                            double amt = Convert.ToDouble(Console.ReadLine());
                            accObj.Deposit(amt);
                        }
                        else
                            Console.WriteLine("Account not found.");

                        break;
                    case 4:
                        Console.Write("Enter Account Number: ");
                        acc = Console.ReadLine();
                        accObj = FindAccount(accounts, acc, NoOfAccounts);
                        if (accObj != null)
                        {
                            Console.Write("Enter Withdraw Amount: ");
                            double amt = Convert.ToDouble(Console.ReadLine());
                            accObj.Withdraw(amt);
                        }
                        else
                            Console.WriteLine("Account not found.");
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        next = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }



            } while (!next);

        }
    }
}