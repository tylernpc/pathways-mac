public class CorporateAccount : Membership
{
    public CorporateAccount(string membershipID, string emailAddress, string typeOfMembership, int annualFee, double totalAmountOfSpend) : base (membershipID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend)
    {

    }
    
    public override double CashbackRewards()
    {
        return TotalAmountOfSpend * 0.02; // 2% Cashback hard coded
    }
}