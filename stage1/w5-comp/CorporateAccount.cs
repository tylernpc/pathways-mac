public class CorporateAccount : Membership
{
    public override double CashbackRewards()
    {
        return TotalAmountOfSpend * 0.02; // 2% Cashback hard coded
    }
}