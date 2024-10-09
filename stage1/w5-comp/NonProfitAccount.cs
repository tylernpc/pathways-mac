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
        double nonProfitCashBack = 0;

        if (TypeOfNonProfitMembership == "MILITARY")
        {
            nonProfitCashBack = TotalAmountOfSpend * 0.02; // doubled cashback hard coded, if Military or Educational Non-Profit
        }
        else if (TypeOfNonProfitMembership == "EDUCATIONAL")
        {
            nonProfitCashBack = TotalAmountOfSpend * 0.02; // doubled cashback hard coded, if Military or Educational Non-Profit
        }
        else
        {
            nonProfitCashBack = TotalAmountOfSpend * 0.01; // 1% cashback hard coded
        }
        
        return nonProfitCashBack;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, {TypeOfNonProfitMembership}";
    }
}