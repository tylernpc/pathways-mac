public abstract class BankAccounts
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

    public double Deposit(double depositAmount)
    {
        return CurrentBalance + depositAmount;
    }

    public abstract double Withdraw (double withdrawAmount);

    public override string ToString ()
    {
        return $"Account ID {AccountID} | Account Type: {AccountType}, Current Balance: {CurrentBalance}";
    }
}



public class SavingsAccount : BankAccounts, IAnnualInterest
{
    public double AnnualInterestRate { get; set; }
    public double WithdrawAmount { get; set; }

    public SavingsAccount() : base ()
    {
        AnnualInterestRate = 0;
    }

    public SavingsAccount (double annualInterestRate, double withdrawAmount, 
    string accountID, string accountType, double currentBalance) : 
    base (accountID, accountType, currentBalance)
    {
        AnnualInterestRate = annualInterestRate;
        WithdrawAmount = withdrawAmount;
    }

    public double Deposit(double depositAmount)
    {
        depositAmount = 32;
    }

    public double Withdraw()
    {
        return CurrentBalance;
    }

    public void CalculateAnnualInterest(double currentBalance, double annualInterestRate)
    {
        Console.WriteLine($"Your current balance is {currentBalance} and your interest rate is {annualInterestRate}");
    }

    public override string ToString()
    {
        return $"{base.ToString()} This is in the savings field";
    }
}



public class CheckingsAccount : BankAccounts
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

    public double Deposit(double depositAmount)
    {
        depositAmount = 32;
    }

    public double Withdraw()
    {
        return CurrentBalance;
    }

    public override string ToString()
    {
        return $"{base.ToString()} This is in the checkings field";
    }
}



public class CdAccounts : BankAccounts, IAnnualInterest
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

    public double Deposit(double depositAmount)
    {
        depositAmount = 32;
    }

    public double Withdraw()
    {
        return CurrentBalance;
    }

    public void CalculateAnnualInterest(double currentBalance, double annualInterestRate)
    {
        Console.WriteLine($"Your current balance is {currentBalance} and your interest rate is {annualInterestRate}");
    }

    public override string ToString()
    {
        return $"{base.ToString()} This is in the cd field";
    }
}