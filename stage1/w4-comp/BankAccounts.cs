public abstract class BankAccount
{
    public string AccountID { get; set; }
    public string AccountType { get; set; }
    public double CurrentBalance { get; set; }

    public BankAccount ()
    {
        AccountID = "";
        AccountType = "";
        CurrentBalance = 0;
    }

    public BankAccount (string accountID, string accountType, double currentBalance)
    {
        AccountID = accountID;
        AccountType = accountType;
        CurrentBalance = currentBalance;
    }

    public double Deposit(double depositAmount)
    {
        CurrentBalance += depositAmount;
        return CurrentBalance;
    }

    public abstract double Withdraw (double withdrawAmount);

    public override string ToString ()
    {
        return $"Account ID {AccountID} | Account Type: {AccountType}, Account Balance: {CurrentBalance}";
    }
}

public class SavingsAccount : BankAccount, IAnnualInterest
{
    public double AnnualInterestRate { get; set; }
    public double WithdrawAmount { get; set; }

    public SavingsAccount() : base ()
    {
        AnnualInterestRate = 0;
        AccountType = "Savings";
    }

    public SavingsAccount (
        double annualInterestRate, 
        double withdrawAmount, 
        string accountID, 
        string accountType, 
        double currentBalance) 
        : base (accountID, accountType, currentBalance)
    {
        AnnualInterestRate = annualInterestRate;
        WithdrawAmount = withdrawAmount;
    }

    public override double Withdraw(double withdrawAmount)
    {
        CurrentBalance -= withdrawAmount;
        return CurrentBalance;
    }

    public double CalculateAnnualInterest()
    {
        return CurrentBalance * AnnualInterestRate;
    }

    public override string ToString()
    {
        return $"{base.ToString()} here's how much you've made off of interest {CalculateAnnualInterest()}";
    }
}

public class CheckingAccount : BankAccount
{
    public int AnnualFee { get; set; }

    public CheckingAccount () : base ()
    {
        AnnualFee = 50;
        AccountType = "Checkings";
    }

    public CheckingAccount ( 
        string accountID, 
        string accountType, 
        double currentBalance) 
        : base (accountID, accountType, currentBalance)
    {

    }

    public override double Withdraw(double withdrawAmount)
    {
        CurrentBalance -= withdrawAmount;
        return CurrentBalance;
    }

    public override string ToString()
    {
        return $"{base.ToString()} you have an annual fee of {AnnualFee}";
    }
}

public class CDAccount : BankAccount, IAnnualInterest
{
    public double AnnualInterestRate { get; set; }
    public double EarlyWithdrawPenalty { get; set; }

    public CDAccount () : base ()
    {
        AnnualInterestRate = 0;
        EarlyWithdrawPenalty = 0.1;
        AccountType = "CD";
    }

    public CDAccount (
    double annualInterestRate, 
    double earlyWithdrawPenalty, 
    string accountID, 
    string accountType, 
    double currentBalance) 
    : base (accountID, accountType, currentBalance)
    {
        AnnualInterestRate = annualInterestRate;
        EarlyWithdrawPenalty = earlyWithdrawPenalty;
    }

    public override double Withdraw(double withdrawAmount)
    {
        CurrentBalance -= withdrawAmount;
        CurrentBalance -= withdrawAmount * EarlyWithdrawPenalty;
        return CurrentBalance;
    }

    public double CalculateAnnualInterest()
    {
        return CurrentBalance * AnnualInterestRate;
    }

    public override string ToString()
    {
        return $"{base.ToString()}";
    }
}