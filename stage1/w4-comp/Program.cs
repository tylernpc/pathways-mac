using System.Data;

namespace w4comp;

class Program
{
    static void Main(string[] args)
    {
        // creates the list of accounts
        List<BankAccount> accounts = new List<BankAccount>();
        using (StreamReader sr = File.OpenText("accounts.txt"))
        {
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                // reads the delimited file, and splits them into their respective parts
                string[] parts = line.Split(',');
                string accountID = parts[0].Trim();
                string accountType = parts[1].Trim();
                double currentBalance = Convert.ToDouble(parts[2]);

                if (accountType.ToUpper() == "SAVINGS")
                {
                    BankAccount savings = new SavingsAccount(0.05, 0, accountID, accountType, currentBalance);
                    accounts.Add(savings);
                }
                else if (accountType.ToUpper() == "CHECKING")
                {
                    BankAccount checking = new CheckingAccount(accountID, accountType, currentBalance);
                    accounts.Add(checking);
                }
                else if (accountType.ToUpper() == "CD")
                {
                    BankAccount cdAccount = new CDAccount(0.05, 0.10, accountID, accountType, currentBalance);
                    accounts.Add(cdAccount);
                }

                // prompt user for type of account, prompts the user for their ID
                Console.Write("What type of bank account do you have (Savings/Checking/CD): ");
                string userPromptAccountType = Console.ReadLine().ToUpper();
                Console.Write("Account ID: ");
                string userAccountID = Console.ReadLine();
                string userPromptOption = "";

                // checks if account exists
                if (accountID == userAccountID)
                {
                    Console.Write("Would you like to Deposit, Withdraw, or just View: ");
                    userPromptOption = Console.ReadLine().ToUpper();

                    if (userPromptOption == "DEPOSIT")
                    {
                        Console.Write("Enter deposit amount: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());

                        if (userPromptAccountType == "SAVINGS")
                        {
                            BankAccount savings = new SavingsAccount(0.05, 0, accountID, accountType, currentBalance);
                            savings.Deposit(depositAmount);
                            Console.WriteLine($"New balance: {savings.CurrentBalance}");
                        }
                        else if (userPromptAccountType == "CHECKING")
                        {
                            BankAccount checking = new CheckingAccount(accountID, accountType, currentBalance);
                            checking.Deposit(depositAmount);
                            Console.WriteLine($"New balance: {checking.CurrentBalance}");
                        }
                        else if (userPromptAccountType == "CD")
                        {
                            BankAccount cdAccount = new CDAccount(0.05, 0.10, accountID, accountType, currentBalance);
                            cdAccount.Deposit(depositAmount);
                            Console.WriteLine($"New balance: {cdAccount.CurrentBalance}");
                        }
                    }
                    else if (userPromptOption == "WITHDRAW")
                    {
                        Console.Write("Enter withdrawal amount: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                        if (userPromptAccountType == "SAVINGS")
                        {
                            BankAccount savings = new SavingsAccount(0.05, 0, accountID, accountType, currentBalance);
                            savings.Withdraw(withdrawAmount);
                            Console.WriteLine($"New balance: {savings.CurrentBalance}");
                        }
                        else if (userPromptAccountType == "CHECKING")
                        {
                            BankAccount checking = new CheckingAccount(accountID, accountType, currentBalance);
                            checking.Withdraw(withdrawAmount);
                            Console.WriteLine($"New balance: {checking.CurrentBalance}");
                        }
                        else if (userPromptAccountType == "CD")
                        {
                            BankAccount cdAccount = new CDAccount(0.05, 0.10, accountID, accountType, currentBalance);
                            cdAccount.Withdraw(withdrawAmount);
                            Console.WriteLine($"New balance: {cdAccount.CurrentBalance}");
                        }
                    }
                    else if (userPromptOption == "VIEW")
                    {
                        if (userPromptAccountType == "SAVINGS")
                        {
                            BankAccount savings = new SavingsAccount(0.05, 0, accountID, accountType, currentBalance);
                            Console.WriteLine(savings);
                        }
                        else if (userPromptAccountType == "CHECKING")
                        {
                            BankAccount checking = new CheckingAccount(accountID, accountType, currentBalance);
                            Console.WriteLine(checking);
                        }
                        else if (userPromptAccountType == "CD")
                        {
                            BankAccount cdAccount = new CDAccount(0.05, 0.10, accountID, accountType, currentBalance);
                            Console.WriteLine(cdAccount);
                        }
                    }
                }
            }
        }
    }
}