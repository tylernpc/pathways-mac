namespace CompChallenge;
class Program
{
    // main program
    static void Main(string[] args)
    {
        // c - incomplete
        // r - incomplete
        // u - incomplete∂
        // d - incomplete∂

        // create portion
        

        // declared variables
        string randomID = userIDGenerator();

        // create portion
        using (StreamWriter sw = new StreamWriter("customers.txt"))
        {
            sw.WriteLine(randomID);
        }
        
    }


    // methods below
    static string userIDGenerator()
    {
        string randomID = Guid.NewGuid().ToString("N").Substring(0, 5);
        return randomID;
    }
}