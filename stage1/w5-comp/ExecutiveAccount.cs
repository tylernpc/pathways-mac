public class ExecutiveAccount : Membership, ISpecialOffer
{
    public ExecutiveAccount(string membershipID, string emailAddress, string typeOfMembership, int annualFee, double totalAmountOfSpend) : base (membershipID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend)
    {
        annualFee = 300;
    }

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
        return Math.Round(executiveCashBack, 2);
    }

    public void SpecialOffer()
    {
        Console.WriteLine($"Executive Special Offer: {AnnualFee * 0.50}");
    }
}