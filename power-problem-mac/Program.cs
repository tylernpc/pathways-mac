// algorithm
/* 

Method()
{
   Exponent accumulation
}

Prompt user for base number
  User validation
Prompt user for exponent
  User validation
Prompt user to continue

*/
using System;

public class powerProblem
{
    static int powerMethod(int passedBase)
    {
        // Declaring our Returned Int
        int userExponent;
        bool isInt;

        // Approval for Exponent Logic
        do
        {
            // User Prompt for Exponent
            Console.Write("Please Provide an Exponent: ");
            string input = Console.ReadLine();
            isInt = int.TryParse(input, out userExponent);

            if (!isInt || userExponent < 1)
            {
                Console.WriteLine("Please Enter a Valid Integer Greater than 0!");
            }

        } while (!isInt || userExponent < 1);   // End of Do While

        // Returns Exponential Number
        return (int)Math.Pow(passedBase, userExponent);
    }   // End of Power Method

    public static void Main(string[] args)
    {
        // Declared Variables in the scope of main class
        int passedBase;
        int totalNum = 0;
        string keepGoing = "YES";
        bool isInt;
        
        // Loop for continuation
        do
        {
            // Approval for Base Logic
            do
            {
                // User Prompt for Base Number
                Console.Write("Please provide a valid base: ");
                string baseInput = Console.ReadLine();
                isInt = int.TryParse(baseInput, out passedBase);

                if (!isInt)
                {
                    Console.WriteLine("Please Enter a Valid Integer for Base!");
                }

            } while (!isInt);  // End of Do While

            // Call power method and add result to totalNum
            totalNum += powerMethod(passedBase);

            // Output current total
            Console.WriteLine("Current total: " + totalNum);

            // User Prompt for Continue
            Console.Write("Would you like to continue? (Yes/No): ");
            keepGoing = Console.ReadLine().ToUpper();

        } while (keepGoing == "YES");   // End of Do While  

        // Final output
        Console.WriteLine("Final total: " + totalNum);
    }   // End of Main Method
}
