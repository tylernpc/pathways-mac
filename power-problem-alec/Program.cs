using System;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            int aBase, anExponent, aResult;
            bool again = true;

            do
            {
                Console.WriteLine("Please enter the base");
                aBase = getValidInt();

                Console.WriteLine("Please enter the exponent");
                anExponent = getValidInt();

                Console.WriteLine("The base " + aBase + " to the power " + anExponent + " is " + Power(aBase, anExponent));

                Console.WriteLine("Again? (y/n)");
                again = (Console.ReadLine().ToUpper() == "Y");

            } while (again);
        } // end main



        static int getValidInt()
        {
            bool isInt;
            int userExponent;

            Console.WriteLine("Please enter a valid integer > 0");

            do
            {
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out userExponent);

                if (!isInt || userExponent < 1)
                {
                    Console.WriteLine("Please Enter a Valid Integer Greater than 0!");
                }

            } while (!isInt || userExponent < 1);

            return userExponent;
        }

        static int Power(int num, int exponent)
        {
            int result;
            result = (int)Math.Pow(num, exponent);

            return result;
        }

    }  // end class
}  // end namespace