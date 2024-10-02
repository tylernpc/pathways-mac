// no bodies for methods

abstract class Payment : IPayment
{
    // declaring variables
    public string CardIssuer { get; set; }
    public int CardNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TransactionID { get; set; }

    // default constructor
    public Payment()
    {
        CardIssuer = "";
        CardNumber = 0;
        FirstName = "";
        LastName = "";
        TransactionID = "";
    }

    // user constructor
    public Payment(string cardIssuer, int cardNumber, string firstName, string lastName, string transactionID)
    {
        CardIssuer = cardIssuer;
        CardNumber = cardNumber;
        FirstName = firstName;
        LastName = lastName;
        TransactionID = transactionID;
    }

    // interface use
    public abstract void ProcessPayment();

    public override string ToString()
    {
        return $"Card issuer: {CardIssuer} | Card Number: {CardNumber} | First Name: {FirstName} | Last Name: {LastName} | Transaction ID: {TransactionID}";
    }
}