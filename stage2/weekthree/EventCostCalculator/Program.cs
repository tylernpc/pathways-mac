namespace EventCostCalculator;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Three Events
         * 1 | Graduation 10%
         * 2 | Retirement 20%
         * 3 | Wedding
         */
        string userInputString = "hello()";
        Console.WriteLine("Hello, are you here for a " +
                          "Graduation Party? Retirement Party? " +
                          "or Wedding?");
        if (Console.ReadLine() == "Graduation Party")
        {
            
        }
        
        IEventCostCalculator eventCost = new userInputString;
        
    }
}