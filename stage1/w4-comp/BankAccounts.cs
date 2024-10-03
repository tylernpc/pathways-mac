using System.Security.Cryptography.X509Certificates;

abstract class BankAccounts
{
    public string AccountID { get; set; }
    public string AccountType { get; set; }
    public double CurrentBalance { get; set; }

    public BankAccounts()
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

    public abstract double Deposit(double depositAmount);

    public abstract double Withdraw(double withdrawAmount);
}

class SavingsAccount : BankAccounts, // interface class
{
    public double AnnualInterestRate { get; set; }

    public SavingsAccount() : base ()
    {
        AnnualInterestRate = 0;
    }

    public SavingsAccount(double annualInterestRate, string accountID, string accountType, double currentBalance) : base (accountID, accountType, currentBalance)
    {
        AnnualInterestRate = annualInterestRate;
    }
}

class CheckingsAccount : BankAccounts, // interface class
{
    public int AnnualFee { get; set; }

    public CheckingsAccount() : base ()
    {
        AnnualFee = 0;
    }

    public CheckingsAccount(int annualFee, string accountID, string accountType, double currentBalance) : base (accountID, accountType, currentBalance)
    {
        AnnualFee = annualFee;
    }
}

class CdAccounts : BankAccounts, // interface class
{
    public CdAccounts() : base ()
    {

    }

    public CdAccounts(string accountID, string accountType, double currentBalance) : base (accountID, accountType, currentBalance)
    {

    }
}