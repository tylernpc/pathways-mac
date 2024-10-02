namespace interfaceOOP;

class Program
{
    static void Main(string[] args)
    {
        // declaring variables
        string fileName = "Customers.txt";
        string cardIssuer = "";
        int cardNumber = 0;
        string firstName = "";
        string lastName = "";
        string choiceOfPayment = "";
        double totalPrice = 0;
        int amountOfCredit = 0;
        int amountOfDebit = 0;
        string transactionID = Guid.NewGuid().ToString();

        // creating a list of purchasers
        List<Payment> payingCustomers = new List<Payment>();

        // declaring objects
        Payment newDebit = new DebitCard();
        Payment newCredit = new CreditCard();

        // prompting customer for card details
        Console.Write("Please enter a card issuer: ");
        cardIssuer = Console.ReadLine();
        Console.Write ("Please enter a card number: ");
        cardNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter a first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter a last name: ");
        lastName = Console.ReadLine();
        Console.Write("Are you using credit or debit: ");
        choiceOfPayment = Console.ReadLine().ToUpper();
        Console.Write("What is the price of the product you want to buy? ");
        totalPrice = Convert.ToDouble(Console.ReadLine());

        // checks if debit or credit
        if (choiceOfPayment == "DEBIT")
        {
            Console.Write("How much is in your bank account: ");
            amountOfDebit = Convert.ToInt32(Console.ReadLine());
            if (amountOfDebit >= totalPrice)
            {
                newDebit.ProcessPayment();
                payingCustomers.Add(new DebitCard(amountOfDebit, cardIssuer, cardNumber, firstName, lastName, transactionID));
            }
            else
            {
                Console.WriteLine("Sorry, you can't afford this product.");
            }
        }
        if (choiceOfPayment == "CREDIT")
        {
            Console.Write("What is your total credit limit: ");
            amountOfCredit = Convert.ToInt32(Console.ReadLine());
            if (amountOfCredit >= totalPrice)
            {
                newCredit.ProcessPayment();
                payingCustomers.Add(new CreditCard(amountOfCredit, cardIssuer, cardNumber, firstName, lastName, transactionID));
            }
            else
            {
                Console.WriteLine("Sorry, you can't afford this product.");
            }
        }

        // writing new information to the text file
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (Payment customer in payingCustomers)
            {
                sw.WriteLine($"{customer.FirstName} : {customer.LastName} : {customer.TransactionID}");
            }
        }

        // looking at output
        foreach (Payment customer in payingCustomers)
        {
            Console.WriteLine(customer);
        }
    }
}