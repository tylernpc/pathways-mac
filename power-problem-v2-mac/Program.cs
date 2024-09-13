using System;

namespace powerProblemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            loop that rights output in order
            prompts user for base number
            prompts user for low exponent
            prompts user for high exponent
            do while to check if lower is in order compared to higher
            */

            // declaring variables
            int baseNum, lowExponent, highExponent, loopAmount;
            
            // user input for base number
            Console.WriteLine("Base Number");
            baseNum = intValidation();

            // user input for low exponent
            Console.WriteLine("Low exponent");
            lowExponent = intValidation();

            // user input for the high exponent
            Console.WriteLine("High exponent");
            highExponent = intValidation();

            do
            {
                if (lowExponent > highExponent)
                {
                    Console.WriteLine("Please make sure the low exponent comes before the high");
                    lowExponent = intValidation();
                    highExponent = intValidation();
                }
            } while (lowExponent > highExponent);   // end of do while loop

            // lowExponent to highExponent
            for (int i = lowExponent; i <= highExponent; i++)
            {
                int result = powerMethod(baseNum, i);
                Console.WriteLine($"{baseNum}^{i} = {result}");
            }   // end of for loop
        }

        static int intValidation()
        {
            /*
            prompts user for a valid integer
            utilizes a do while loop that checks 
            */

            // declaring variables
            bool isInt;
            int userExponent;

            // prompts user for valid integer
            Console.Write("Please enter a valid integer: ");
            do
            {
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out userExponent);

                if (!isInt || userExponent < 1)
                {
                    Console.WriteLine("Please Enter a Valid Integer");
                }
            } while (!isInt || userExponent < 1);   // end of while loop

            return userExponent;
        }

        static int powerMethod(int num, int exponent)
        {
            int result;
            result = (int)Math.Pow(num, exponent);

            return result;
        }
    }
}