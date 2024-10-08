public class NonProfitAccount : Membership
{
    public string TypeOfNonProfitMembership { get; set; }

    public NonProfitAccount() : base ()
    {
        TypeOfNonProfitMembership = "";
    }

    public NonProfitAccount(
        string typeOfNonProfitMembership, 
        string membershipID, 
        string emailAddress, 
        string typeOfMembership, 
        int annualFee, 
        double totalAmountOfSpend) 
        : base (
            membershipID, 
            emailAddress, 
            typeOfMembership, 
            annualFee, 
            totalAmountOfSpend)
    {
        TypeOfNonProfitMembership = typeOfNonProfitMembership;
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
        return executiveCashBack;
    }
}