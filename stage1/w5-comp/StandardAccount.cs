public class StandardAccount : Membership, ISpecialOffer
{
    public override double CashbackRewards()
    {
        return TotalAmountOfSpend * 0.03; // 3% Cashback hard coded
    }

    public void SpecialOffer()
    {
        Console.WriteLine($"Standard Special Offer: {AnnualFee * 0.25}");
    }
}