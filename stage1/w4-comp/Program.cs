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

                // places items into the list
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
            }
        }

        // prompt user for type of account, prompts the user for their ID
        Console.Write("What type of bank account do you have (Savings/Checking/CD): ");
        string userPromptAccountType = Console.ReadLine().ToUpper();
        Console.Write("Account ID: ");
        string userAccountID = Console.ReadLine();
        string userPromptOption = "";
        bool accountFound = false;

        // checks if account exists while iterating over all accounts
        foreach (var account in accounts)
        {
            if (account.AccountID == userAccountID && account.AccountType.ToUpper() == userPromptAccountType)
            {
                accountFound = true;

                Console.Write("Would you like to Deposit, Withdraw, or just View: ");
                userPromptOption = Console.ReadLine().ToUpper();

                if (userPromptOption == "DEPOSIT")
                {
                    Console.Write("Enter deposit amount: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    if (depositAmount <= 0)
                    {
                        Console.WriteLine("Please enter a valid deposit amount greater than 0.");
                    }
                    else
                    {
                        account.Deposit(depositAmount);
                        Console.WriteLine($"New balance: {account.CurrentBalance}");
                    }
                }
                else if (userPromptOption == "WITHDRAW")
                {
                    Console.Write("Enter withdrawal amount: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                    if (withdrawAmount <= 0)
                    {
                        Console.WriteLine("Please enter a valid withdrawal amount greater than 0.");
                    }
                    else
                    {
                        if (account is SavingsAccount savingsAccount)
                        {
                            if (withdrawAmount > savingsAccount.CurrentBalance)
                            {
                                Console.WriteLine("Insufficient funds for withdrawal.");
                            }
                            else
                            {
                                savingsAccount.Withdraw(withdrawAmount);
                                Console.WriteLine($"New balance: {savingsAccount.CurrentBalance}");
                            }
                        }
                        else if (account is CheckingAccount checkingAccount)
                        {
                            double maximumWithdrawal = checkingAccount.CurrentBalance * 0.5;
                            if (withdrawAmount > maximumWithdrawal)
                            {
                                Console.WriteLine("Withdrawal amount exceeds the 50% limit.");
                            }
                            else
                            {
                                checkingAccount.Withdraw(withdrawAmount);
                                Console.WriteLine($"New balance: {checkingAccount.CurrentBalance}");
                            }
                        }
                        else if (account is CDAccount cdAccount)
                        {
                            double totalWithdrawalAmount = withdrawAmount + (withdrawAmount * cdAccount.EarlyWithdrawPenalty);
                            if (totalWithdrawalAmount > cdAccount.CurrentBalance)
                            {
                                Console.WriteLine("Insufficient funds for withdrawal considering the early withdrawal penalty.");
                            }
                            else
                            {
                                cdAccount.Withdraw(withdrawAmount);
                                Console.WriteLine($"New balance: {cdAccount.CurrentBalance}");
                            }
                        }
                    }
                }
                else if (userPromptOption == "VIEW")
                {
                    Console.WriteLine(account);
                }

                break;
            }
        }
        if (!accountFound)
        {
            Console.WriteLine("Account not found.");
        }
    }
}