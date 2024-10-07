public class StandardAccount : Membership, ISpecialOffer
{
    public override double CashbackRewards()
    {
        return TotalAmountOfSpend * 0.03; // 3% Cashback hard coded
    }
}