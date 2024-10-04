using System.Security.Principal;

namespace w4comp;

class Program
{
    static void Main(string[] args)
    {
        string accountID = "TL22";
        SavingsAccount savingsAccount = new SavingsAccount();
        Console.WriteLine(savingsAccount);

        CheckingsAccount checkingsAccount = new CheckingsAccount();
        Console.WriteLine(checkingsAccount);

        CdAccounts cdAccounts = new CdAccounts();
        Console.WriteLine(cdAccounts);
    }
}