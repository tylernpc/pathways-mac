namespace CompChallenge;
class Program
{
    // main program
    static void Main(string[] args)
    {
        // c - complete
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
        string accountID;
        string accountEmail;
        double totalAmountOfSpend = 0;

        using (StreamReader sr = File.OpenText("customers.txt"))
        {
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                // reads the delimited file, and splits them into their respective parts
                string[] parts = line.Split(',');
                accountID = parts[0].Trim();
                accountEmail = parts[1].Trim();
                typeOfMembership = parts[2].Trim();
                annualFee = Convert.ToInt16(parts[3].Trim());
                totalAmountOfSpend = Convert.ToDouble(parts[4].Trim());

                Membership customer = null;
                // places items into the list
                if (typeOfMembership.ToUpper() == "STANDARD")
                {
                    customer = new StandardAccount(accountID, accountEmail, typeOfMembership, annualFee, totalAmountOfSpend);
                }
                else if (typeOfMembership.ToUpper() == "EXECUTIVE")
                {
                    customer = new ExecutiveAccount(accountID, accountEmail, typeOfMembership, annualFee, totalAmountOfSpend);
                }
                else if (typeOfMembership.ToUpper() == "NONPROFIT")
                {
                    string typeOfNonProfitMembership = parts[5].Trim();
                    customer = new NonProfitAccount(accountID, accountEmail, typeOfMembership, annualFee, totalAmountOfSpend, typeOfNonProfitMembership);
                }
                else if (typeOfMembership.ToUpper() == "COPORATE")
                {
                    customer = new StandardAccount(accountID, accountEmail, typeOfMembership, annualFee, totalAmountOfSpend);
                }

                if (customer != null)
                {

                }
            }
        }

        do
        {
            // CRUD operations
            Console.Write("What (C/R/U/D/Q) operation would you like to select? ");
            userCrudChoice = Console.ReadLine().ToUpper();
            if (userCrudChoice == "C")
            {
                Membership customer = null;
                // user prompts for account creation
                Console.Write("Please provide an email address: ");
                emailAddress = Console.ReadLine();
                Console.Write("What type of membership would you like to select (Standard/Executive/NonProfit/Corporate): ");
                typeOfMembership = Console.ReadLine().ToUpper();

                if (typeOfMembership == "STANDARD")
                {
                    customers.Add(new StandardAccount(randomID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend));
                }
                else if (typeOfMembership == "EXECUTIVE")
                {
                    customers.Add(new ExecutiveAccount(randomID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend));
                }
                else if (typeOfMembership == "NONPROFIT")
                {
                    string typeOfNonProfitMembershipSet;
                    // user validation for nonprofit type
                    do
                    {
                        Console.Write("Is this non-profit Educational, Military, or Neither? ");
                        string typeOfNonProfitMembership = Console.ReadLine().ToUpper();

                        if (typeOfNonProfitMembership == "EDUCATIONAL")
                        {
                            typeOfNonProfitMembershipSet = "Educational";
                        }
                        else if (typeOfNonProfitMembership == "MILITARY")
                        {
                            typeOfNonProfitMembershipSet = "Military";
                        }
                        else if (typeOfNonProfitMembership == "NEITHER")
                        {
                            typeOfNonProfitMembershipSet = "Neither";
                        }
                        else
                        {
                            Console.Write("Please enter a valid option: Educational or Military. ");
                        }
                    } while (true);

                    customers.Add(new NonProfitAccount(randomID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend, typeOfNonProfitMembershipSet));
                }
                else if (typeOfMembership == "CORPORATE")
                {
                    customers.Add(new CorporateAccount(randomID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend));
                }
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
        } while (!(userCrudChoice == "Q"));
    }

    // methods below
    static string userIDGenerator()
    {
        string randomID = Guid.NewGuid().ToString("N").Substring(0, 5);
        return randomID;
    }
}