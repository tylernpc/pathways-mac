public class NonProfitAccount : Membership
{
    public string TypeOfNonProfitMembership { get; set; }

    public NonProfitAccount(string membershipID, string emailAddress, string typeOfMembership, int annualFee, double totalAmountOfSpend) : base (membershipID, emailAddress, typeOfMembership, annualFee, totalAmountOfSpend)
    {
        annualFee = 50;
        TypeOfNonProfitMembership = "";
    }

    public NonProfitAccount( 
        string membershipID, 
        string emailAddress, 
        string typeOfMembership, 
        int annualFee, 
        double totalAmountOfSpend,
        string typeOfNonProfitMembership) 
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
        if (TypeOfNonProfitMembership == "Military")
        {
            nonProfitCashBack = TotalAmountOfSpend * 0.02; // doubled cashback hard coded, if Military or Educational Non-Profit
        }
        else if (TypeOfNonProfitMembership == "Educational")
        {
            nonProfitCashBack = TotalAmountOfSpend * 0.02; // doubled cashback hard coded, if Military or Educational Non-Profit
        }
        else if (TypeOfNonProfitMembership == "Neither")
        {
            nonProfitCashBack = TotalAmountOfSpend * 0.01; // 1% cashback hard coded
        }
        return Math.Round(nonProfitCashBack);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, {TypeOfNonProfitMembership}";
    }
}