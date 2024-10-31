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
        bool isValidOption = false;
        Console.WriteLine("Hello, are you here for a " +
                          "Graduation Party? Retirement Party? " +
                          "or Wedding?");
        Console.WriteLine("Graduation | Retirement | Wedding");

        do
        {
            Console.Write("Enter: ");
            string input = Console.ReadLine()?.ToUpper();

            if (input == "GRADUATION")
            {
                IEventCostCalculator eventCost = new GraduationCostCalculator();
                Console.Write("How many guest will you have? ");
                double totalPrice = eventCost.CalculateCost(Convert.ToInt32(Console.ReadLine()));
                Console.Write($"Here is your total price: {totalPrice}");
                isValidOption = true;
            }
            else if (input == "RETIREMENT")
            {
                IEventCostCalculator eventCost = new RetirementCostCalculator();
                Console.Write("How many guest will you have? ");
                double totalPrice = eventCost.CalculateCost(Convert.ToInt32(Console.ReadLine()));
                Console.Write($"Here is your total price: {totalPrice}");
                isValidOption = true;
            }
            else if (input == "WEDDING")
            {
                IEventCostCalculator eventCost = new WeddingCostCalculator();
                Console.Write("How many guest will you have? ");
                double totalPrice = eventCost.CalculateCost(Convert.ToInt32(Console.ReadLine()));
                Console.Write($"Here is your total price: {totalPrice}");
                isValidOption = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
            
        } while (!isValidOption);
    }
}