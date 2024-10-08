public class ExecutiveAccount : Membership, ISpecialOffer
{
    public override double CashbackRewards()
    {
        double executiveCashBack = 0;
        if (TotalAmountOfSpend < 1000)
        {
            executiveCashBack = TotalAmountOfSpend * 0.05; // 5% Cashback hard coded
        }
        if (TotalAmountOfSpend > 1000)
        {
            executiveCashBack = TotalAmountOfSpend * 0.07; // 7% Cashback hard coded
        }
        return executiveCashBack;
    }

    public void SpecialOffer()
    {
        Console.WriteLine($"Executive Special Offer: {AnnualFee * 0.50}");
    }
}