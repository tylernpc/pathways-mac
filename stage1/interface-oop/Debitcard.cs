class DebitCard : Payment, IPayment
{
    // declaring variables
    public int AmountOfDebit { get; set; } // amount user has in debit account

    // default constructor
    public DebitCard() : base()
    {

    }

    // user contructor
    public DebitCard(int amountOfDebit, string cardIssuer, int cardNumber, string firstName, string lastName, string transactionID) : base(cardIssuer, cardNumber, firstName, lastName, transactionID)
    {
        AmountOfDebit = amountOfDebit;
    }

    // main method to green light user payment
    public void ProcessPayment()
    {
        Console.WriteLine($"You can afford this!");
    }

    // basic tostring() override
    public override string ToString()
    {
        return $"{base.ToString()} | How much you have in your debit card: {AmountOfDebit}";
    }
}