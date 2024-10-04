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

                // prompt user for type of account, prompts the user for their ID
                Console.Write("What type of bank account do you have (Savings/Checking/CD): ");
                string userPromptAccountType = Console.ReadLine().ToUpper();
                Console.Write("Account ID: ");
                string userAccountID = Console.ReadLine();
                string userPromptOption = "";

                // checks what type of account they have, then checks if their ID matches up
                if (userPromptAccountType == "SAVINGS")
                {
                    if (accountID == userAccountID)
                    {
                        Console.Write("Would you like to Deposit, Withdraw, or just View : ");
                        userPromptOption = Console.ReadLine().ToUpper();

                        if (userPromptOption == "DEPOSIT")
                        {

                        }
                        else if (userPromptOption == "WITHDRAW")
                        {

                        }
                        else if (userPromptOption == "VIEW")
                        {
                            BankAccount savings = new SavingsAccount(0.05, 0, accountID, accountType, currentBalance);
                            Console.WriteLine(savings);
                        }
                    }

                }
                if (userPromptAccountType == "CHECKING")
                {
                    if (accountID == userAccountID)
                    {
                        Console.Write("Would you like to Deposit, Withdraw, or just View : ");
                        userPromptOption = Console.ReadLine().ToUpper();

                        if (userPromptOption == "DEPOSIT")
                        {

                        }
                        else if (userPromptOption == "WITHDRAW")
                        {

                        }
                        else if (userPromptOption == "VIEW")
                        {
                            BankAccount checking = new CheckingAccount(accountID, accountType, currentBalance);
                            Console.WriteLine(checking);
                        }
                    }

                }
                if (userPromptAccountType == "CD")
                {
                    if (accountID == userAccountID)
                    {
                        Console.Write("Would you like to Deposit, Withdraw, or just View : ");
                        userPromptOption = Console.ReadLine().ToUpper();

                        if (userPromptOption == "DEPOSIT")
                        {

                        }
                        else if (userPromptOption == "WITHDRAW")
                        {

                        }
                        else if (userPromptOption == "VIEW")
                        {
                            BankAccount cdAccounts = new CDAccount(0.05, 0.10, accountID, accountType, currentBalance);
                            accounts.Add(cdAccounts);
                        }
                    }
                }
            }
        }
    }
}