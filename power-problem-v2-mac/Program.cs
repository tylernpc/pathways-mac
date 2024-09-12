using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace powerProblemV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum, lowExponent, highExponent;
            
        }

        static int getValidInt()
        {
            bool isInt;
            int userExponent;

            Console.WriteLine("Please enter a valid integer: ");
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

        static bool powerMethod(int num1, int num2)
        {
            int result;
            result = (int)Math.Pow(num1, exponent)

            return result;
        }
    }
}