namespace CompChallenge;
class Program
{
    // main program
    static void Main(string[] args)
    {
        // c - incomplete
        // r - incomplete
        // u - incomplete
        // d - incomplete

        // create portion
        List<Membership> customers = new List<Membership>();


        // declared variables
        string randomID = userIDGenerator();
        string emailAddress;
        string typeOfMembership;
        int annualFee = 0;
        double monthlySpend = 0;

        // user prompts for account creation
        Console.Write("Please provide an email address: ");
        emailAddress = Console.ReadLine();
        Console.Write("What type of membership would you like to select: ");
        typeOfMembership = Console.ReadLine();
        Console.Write("");
        Console.Write("");


        
        


        using (StreamReader sr = File.OpenText("customers.txt"))
        {
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                // reads the delimited file, and splits them into their respective parts
                string[] parts = line.Split(',');
                string accountID = parts[0].Trim();
                string accountEmail = parts[1].Trim();
                string typeOfMembership = parts[2].Trim();
                string annualFee = parts[3].Trim();
                double totalAmountOfSpend = Convert.ToDouble(parts[4].Trim());

                // places items into the list
                if (typeOfMembership.ToUpper() == "STANDARD")
                {
                    Membership customer = new StandardAccount(randomID, );
                    Membership.Add(customer);
                }
                else if (typeOfMembership.ToUpper() == "EXECUTIVE")
                {
                    BankAccount checking = new CheckingAccount(accountID, accountType, currentBalance);
                    accounts.Add(checking);
                }
                else if (typeOfMembership.ToUpper() == "NON-PROFIT")
                {
                    BankAccount cdAccount = new CDAccount(0.05, 0.10, accountID, accountType, currentBalance);
                    accounts.Add(cdAccount);
                }
                else if (typeOfMembership.ToUpper() == "COPORATE")
                {

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


    // methods below
    static string userIDGenerator()
    {
        string randomID = Guid.NewGuid().ToString("N").Substring(0, 5);
        return randomID;
    }
}