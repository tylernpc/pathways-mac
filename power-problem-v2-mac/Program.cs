using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.Security;

namespace powerProblemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompts user to input a number
                // checked if valid (with method)

            // declaring variables
            int baseNum, lowExponent, highExponent, loopAmount;
            
            // user input for base number
            Console.Write("Please enter the base number: ");
            baseNum = intValidation();

            // user input for low exponent
            Console.Write("Please enter the low exponent: ");
            lowExponent = intValidation();

            // user input for the high exponent
            Console.Write("Please enter the high exponent: ");
            highExponent = intValidation();

            do
            {
                if (lowExponent > highExponent)
                {
                    Console.WriteLine("Please make sure the low exponent comes before the high");
                    lowExponent = intValidation();
                    highExponent = intValidation();
                }
            } while (lowExponent > highExponent);

            // lowExponent to highExponent
            for (int i = lowExponent; i <= highExponent; i++)
            {
                int result = powerMethod(baseNum, i);
                Console.WriteLine($"{baseNum}^{i} = {result}");
            }
        }

        static int intValidation()
        {
            bool isInt;
            int userExponent;

            Console.Write("Please enter a valid integer: ");
            do
            {
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out userExponent);

                if (!isInt || userExponent < 1)
                {
                    Console.WriteLine("Please Enter a Valid Integer");
                }
            } while (!isInt || userExponent < 1);

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