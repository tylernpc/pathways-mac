abstract class BankAccounts
{
    public string AccountID { get; set; }
    public string AccountType { get; set; }
    public double CurrentBalance { get; set; }

    public BankAccounts ()
    {
        AccountID = "";
        AccountType = "";
        CurrentBalance = 0;
    }

    public BankAccounts (string accountID, string accountType, double currentBalance)
    {
        AccountID = accountID;
        AccountType = accountType;
        CurrentBalance = currentBalance;
    }

    public abstract double Withdraw (double withdrawAmount);

    public override string ToString ()
    {
        return $"Account ID {AccountID} | Account Type: {AccountType}, Current Balance: {CurrentBalance}";
    }
}

class SavingsAccount : BankAccounts, // interface class
{
    public double AnnualInterestRate { get; set; }

    public SavingsAccount() : base ()
    {
        AnnualInterestRate = 0;
    }

    public SavingsAccount (double annualInterestRate, string accountID, 
    string accountType, double currentBalance) : 
    base (accountID, accountType, currentBalance)
    {
        AnnualInterestRate = annualInterestRate;
    }
}

class CheckingsAccount : BankAccounts, // interface class
{
    public int AnnualFee { get; set; }

    public CheckingsAccount () : base ()
    {
        AnnualFee = 0;
    }

    public CheckingsAccount (int annualFee, string accountID, 
    string accountType, double currentBalance) : 
    base (accountID, accountType, currentBalance)
    {
        AnnualFee = annualFee;
    }
}

class CdAccounts : BankAccounts, // interface class
{
    public double AnnualInterestRate { get; set; }
    public double EarlyWithdrawPenalty { get; set; }

    public CdAccounts () : base ()
    {
        AnnualInterestRate = 0;
        EarlyWithdrawPenalty = 0;
    }

    public CdAccounts (double annualInterestRate, double earlyWithdrawPenalty, 
    string accountID, string accountType, double currentBalance) : 
    base (accountID, accountType, currentBalance)
    {
        AnnualInterestRate = annualInterestRate;
        EarlyWithdrawPenalty = earlyWithdrawPenalty;
    }
}