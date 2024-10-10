namespace CompChallenge;
class Program
{
    // main program
    static void Main(string[] args)
    {
        string userChoice;
        do
        {
            Console.Write("Are you a manager or customer? ");
            userChoice = Console.ReadLine().ToUpper();
        } while (userChoice != "MANAGER" && userChoice != "CUSTOMER");

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
                else if (typeOfMembership.ToUpper() == "CORPORATE")
                {
                    customer = new CorporateAccount(accountID, accountEmail, typeOfMembership, annualFee, totalAmountOfSpend);
                }

                if (customer != null)
                {
                    customers.Add(customer); // Add customer to the list here
                }
            }
        }

        if (userChoice == "MANAGER")
        {
            do
            {
                // CRUD operations
                Console.Write("What (C/R/U/D/Q/S) operation would you like to select? ");
                userCrudChoice = Console.ReadLine().ToUpper();
                if (userCrudChoice == "C")
                {
                    CreateCustomer(customers);
                }
                else if (userCrudChoice == "R")
                {
                    DisplayCustomers(customers);
                }
                else if (userCrudChoice == "U")
                {
                    DisplayCustomers(customers);

                    Console.Write("Please enter a User ID: ");
                    accountID = Console.ReadLine().ToUpper();

                    Membership foundCustomer = null;
                    foreach (var customer in customers)
                    {
                        if (customer.MembershipID.ToUpper() == accountID)
                        {
                            foundCustomer = customer;
                            break;
                        }
                    }

                    if (foundCustomer != null)
                    {

                        CreateCustomer(customers);
                    }
                    else
                    {
                        Console.WriteLine("Customer not found");
                    }
                }
                else if (userCrudChoice == "D")
                {
                    DisplayCustomers(customers);

                    Console.Write("Please enter a User ID to delete: ");
                    accountID = Console.ReadLine().ToUpper();

                    Membership customerToDelete = null;
                    foreach (var customer in customers)
                    {
                        if (customer.MembershipID.ToUpper() == accountID)
                        {
                            customerToDelete = customer;
                            break;
                        }
                    }

                    if (customerToDelete != null)
                    {
                        customers.Remove(customerToDelete);
                        Console.WriteLine("Customer deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Customer not found.");
                    }
                }
                else if (userCrudChoice == "S")
                {
                    using (StreamWriter sw = new StreamWriter("customers.txt"))
                    {
                        foreach (var customer in customers)
                        {
                            string line;
                            if (customer is NonProfitAccount nonProfitCustomer)
                            {
                                line = $"{customer.MembershipID},{customer.EmailAddress},{customer.TypeOfMembership},{customer.AnnualFee},{customer.TotalAmountOfSpend},{nonProfitCustomer.TypeOfNonProfitMembership}";
                            }
                            else
                            {
                                line = $"{customer.MembershipID},{customer.EmailAddress},{customer.TypeOfMembership},{customer.AnnualFee},{customer.TotalAmountOfSpend}";
                            }
                            sw.WriteLine(line);
                        }
                    }
                    Console.WriteLine("Save Successful.");
                }
            } while (!(userCrudChoice == "Q"));
        }
        if (userChoice == "CUSTOMER")
        {
            // the read out would ideally never be there for someone but since we're demoing I left it in
            DisplayCustomers(customers);

            Console.Write("Please enter your ID: ");
            accountID = Console.ReadLine().Trim().ToUpper();

            Membership foundCustomer = null;
            foreach (var customer in customers)
            {
                if (customer.MembershipID.ToUpper() == accountID)
                {
                    foundCustomer = customer;
                    break;
                }
            }

            if (foundCustomer != null)
            {
                do
                {
                    Console.Write("Would you like to (L/P/T/A/Q) ");
                    userChoice = Console.ReadLine().ToUpper();
                } while (userChoice != "L" && userChoice != "P" && userChoice != "T" && userChoice != "A" && userChoice != "Q");

                if (userChoice == "L")
                {
                    //  ignore for now
                }
                else if (userChoice == "P")
                {
                    Console.Write("Enter the amount you would like to purchase: ");
                    double purchaseAmount;

                    while (!double.TryParse(Console.ReadLine(), out purchaseAmount) || purchaseAmount <= 0)
                    {
                        Console.Write("Please enter a valid purchase greater than zero: ");
                    }

                    foundCustomer.TotalAmountOfSpend = foundCustomer.Purchase(foundCustomer.TotalAmountOfSpend, purchaseAmount);
                    Console.WriteLine("Purchase Successful.");
                }
                else if (userChoice == "T")
                {

                }
                else if (userChoice == "A")
                {

                }
                else if (userChoice == "Q")
                {

                }
            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }
    }

    // methods below
    static string userIDGenerator()
    {
        string randomID = Guid.NewGuid().ToString("N").Substring(0, 5);
        return randomID;
    }

    static void CreateCustomer(List<Membership> customers)
    {
        string randomID = userIDGenerator();
        string emailAddress;
        string typeOfMembership;
        int annualFee = 0;
        double totalAmountOfSpend = 0;

        Membership customer = null;

        // user prompts for account creation
        Console.Write("Please provide an email address: ");
        emailAddress = Console.ReadLine();
        Console.Write("What type of membership would you like to select (Standard/Executive/Nonprofit/Corporate): ");
        typeOfMembership = Console.ReadLine().ToUpper();

        if (typeOfMembership == "STANDARD")
        {
            customers.Add(new StandardAccount(randomID, emailAddress, "Standard", 200, totalAmountOfSpend));
        }
        else if (typeOfMembership == "EXECUTIVE")
        {
            customers.Add(new ExecutiveAccount(randomID, emailAddress, "Executive", 300, totalAmountOfSpend));
        }
        else if (typeOfMembership == "NONPROFIT")
        {
            string typeOfNonProfitMembershipSet;
            // user validation for nonprofit
            do
            {
                Console.Write("Is this nonprofit Educational, Military, or Neither? ");
                string typeOfNonProfitMembership = Console.ReadLine().ToUpper();

                if (typeOfNonProfitMembership == "EDUCATIONAL")
                {
                    typeOfNonProfitMembershipSet = "Educational";
                    break;
                }
                else if (typeOfNonProfitMembership == "MILITARY")
                {
                    typeOfNonProfitMembershipSet = "Military";
                    break;
                }
                else if (typeOfNonProfitMembership == "NEITHER")
                {
                    typeOfNonProfitMembershipSet = "Neither";
                    break;
                }
                else
                {
                    Console.Write("Please enter a valid option: Educational or Military. ");
                }
            } while (true);

            customers.Add(new NonProfitAccount(randomID, emailAddress, "Nonprofit", 50, totalAmountOfSpend, typeOfNonProfitMembershipSet));
        }
        else if (typeOfMembership == "CORPORATE")
        {
            customers.Add(new CorporateAccount(randomID, emailAddress, "Corporate", 1000, totalAmountOfSpend));
        }
    }

    static void DisplayCustomers(List<Membership> customers)
    {
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.ToString());
        }
    }
}