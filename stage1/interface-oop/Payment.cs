// no bodies for methods

abstract class Payment : IPayment
{
    // declare variables
    public string CardIssuer { get; set; }
    public int CardNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Payment()
    {
        CardIssuer = "";
        CardNumber = 0;
        FirstName = "";
        LastName = "";
    }

    // user constructor
    public Payment(string cardIssuer, int cardNumber, string firstName, string lastName)
    {
        CardIssuer = cardIssuer;
        CardNumber = cardNumber;
        FirstName = firstName;
        LastName = lastName;
    }

    // interface assignment
    public void ProcessPayment()
    {
        Console.WriteLine($"Card Issuer: {CardIssuer} | Card Number: {CardNumber} | First Name: {FirstName} | Last Name: {LastName}");
    }

    // base override
    public override string ToString()
    {
        return $"Card Issuer: {CardIssuer} | Card Number: {CardNumber} | First Name: {FirstName} | Last Name: {LastName}";
    }
}