public class StandardAccount : Membership, ISpecialOffer
{
    public StandardAccount(string membershipID, string emailAddress, string typeOfMembership, int annualFee, double totalAmountOfSpend) : base (membershipID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend)
    {
        
    }

    public override double CashbackRewards()
    {
        return TotalAmountOfSpend * 0.03; // 3% Cashback hard coded
    }

    public void SpecialOffer()
    {
        Console.WriteLine($"Standard Special Offer: {AnnualFee * 0.25}");
    }
}