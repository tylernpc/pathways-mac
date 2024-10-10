public class StandardAccount : Membership, ISpecialOffer
{
    public StandardAccount(string membershipID, string emailAddress, string typeOfMembership, int annualFee, double totalAmountOfSpend) : base (membershipID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend)
    {
        annualFee = 200;
    }

    public override double CashbackRewards()
    {
        var cashback = (TotalAmountOfSpend * 0.03); // 3% Cashback hard coded
        return Math.Round(cashback, 2);
    }

    public void SpecialOffer()
    {
        Console.WriteLine($"Thank you for a being a member! Our special off is {AnnualFee * 0.25} off your next annual payment!");
    }
}