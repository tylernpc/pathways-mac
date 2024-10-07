using System.Diagnostics.CodeAnalysis;
using System.Globalization;

public abstract class Membership
{
    public string MembershipID { get; set; }
    public string EmailAddress { get; set; }
    public string TypeOfMembership { get; set; }
    public int AnnualFee { get; set; }
    public double TotalAmountOfSpend { get; set; }

    public Membership()
    {
        MembershipID = "";
        MembershipID = "";
        MembershipID = "";
        AnnualFee = 0;
        TotalAmountOfSpend = 0;
    }

    public Membership(string membershipID, string emailAddress, string typeOfMembership, int annualFee, double totalAmountOfSpend)
    {
        MembershipID = membershipID;
        EmailAddress = emailAddress;
        TypeOfMembership = typeOfMembership;
        AnnualFee = annualFee;
        TotalAmountOfSpend = totalAmountOfSpend;
    }

    public double Purchase(double accumulatedTotal, double newPurchase)
    {
        accumulatedTotal += newPurchase;
        return accumulatedTotal;
    }

    public double Return(double accumulatedTotal, double newReturn)
    {
        accumulatedTotal -= newReturn;
        return accumulatedTotal;
    }

    public abstract double CashbackRewards();

    public override string ToString()
    {
        return $"{MembershipID}| {EmailAddress}, Type of Membership: {TypeOfMembership}, Annual Fee: {AnnualFee}, Total Spend: {TotalAmountOfSpend}";
    }
}