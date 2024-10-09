﻿namespace CompChallenge;
class Program
{
    // main program
    static void Main(string[] args)
    {
        // c - incomplete
        // r - incomplete
        // u - incomplete
        // d - incomplete

        // Primary List
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

        // Load Portion
        using (StreamReader sr = File.OpenText("customers.txt"))
        {
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                // reads the delimited file, and splits them into their respective parts
                string[] parts = line.Split(',');
                string accountID = parts[0].Trim();
                string accountEmail = parts[1].Trim();
                typeOfMembership = parts[2].Trim();
                annualFee = Convert.ToInt16(parts[3].Trim());
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

       
    }

    // methods below
    static string userIDGenerator()
    {
        string randomID = Guid.NewGuid().ToString("N").Substring(0, 5);
        return randomID;
    }
}