public class CorporateAccount : Membership
{
    public CorporateAccount(string membershipID, string emailAddress, string typeOfMembership, int annualFee, double totalAmountOfSpend) : base (membershipID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend)
    {
        annualFee = 1000;
    }
    
    public override double CashbackRewards()
    {
        var cashback = (TotalAmountOfSpend * 0.02); // 2% Cashback hard coded
        return Math.Round(cashback, 2);
    }
}