class CreditCard : Payment
{
    // declaring variables
    public int AmountOfCredit { get; set; } // credit limit

    // default constructor
    public CreditCard() : base()
    {

    }

    // user contructor
    public CreditCard(int amountOfCredit, string cardIssuer, int cardNumber, string firstName, string lastName, string transactionID) : base (cardIssuer, cardNumber, firstName, lastName, transactionID)
    {
        AmountOfCredit = amountOfCredit;
    }

    // main method to green light user payment
    public override void ProcessPayment()
    {
        Console.WriteLine($"You can afford this!");
    }

    // basic tostring() override
    public override string ToString()
    {
        return $"{base.ToString()} | How much you have in your credit card: {AmountOfCredit}";
    }
}

/* 
interface doesn't apply to data contracts
interface by definition can be used for things like a factory pattern, or a scope service pattern
difference between knowing what things can do and how are done

a service looking at another interface can see what it does but not how
service implementations are when they become more useful
*/