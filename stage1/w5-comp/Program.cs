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
        string userCrudChoice;

        do
        {
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

                    Membership customer = null;
                    // places items into the list
                    if (typeOfMembership.ToUpper() == "STANDARD")
                    {
                        customer = new StandardAccount(accountID, accountEmail, typeOfMembership, annualFee, totalAmountOfSpend);
                        customers.Add(customer);
                    }
                    else if (typeOfMembership.ToUpper() == "EXECUTIVE")
                    {
                        customer = new ExecutiveAccount(accountID, accountEmail, typeOfMembership, annualFee, totalAmountOfSpend);
                        customers.Add(customer);
                    }
                    else if (typeOfMembership.ToUpper() == "NON-PROFIT")
                    {
                        string typeOfNonProfitMembership = parts[5].Trim();
                        customer = new NonProfitAccount(accountID, accountEmail, typeOfMembership, annualFee, totalAmountOfSpend, typeOfNonProfitMembership);
                        customers.Add(customer);
                    }
                    else if (typeOfMembership.ToUpper() == "COPORATE")
                    {
                        customer = new StandardAccount(accountID, accountEmail, typeOfMembership, annualFee, totalAmountOfSpend);
                        customers.Add(customer);
                    }
                }

                // CRUD operations
                Console.Write("What (C/R/U/D/Q) operation would you like to select? ");
                userCrudChoice = Console.ReadLine().ToUpper();
                if (userCrudChoice == "C")
                {
                    // user prompts for account creation
                    Console.Write("Please provide an email address: ");
                    emailAddress = Console.ReadLine();
                    Console.Write("What type of membership would you like to select: ");
                    typeOfMembership = Console.ReadLine();
                }
                else if (userCrudChoice == "R")
                {
                    foreach (var customer in customers)
                    {
                        Console.WriteLine(customer.ToString());
                    }
                }
                else if (userCrudChoice == "U")
                {

                }
                else if (userCrudChoice == "D")
                {

                }
            }
        } while (!(userCrudChoice == "Q"));
    }

    // methods below
    static string userIDGenerator()
    {
        string randomID = Guid.NewGuid().ToString("N").Substring(0, 5);
        return randomID;
    }
}