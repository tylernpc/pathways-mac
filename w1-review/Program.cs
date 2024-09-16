using System;
using System.Net.Mail;
using System.Reflection;

namespace w1Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(validInt());

        }

        static void arrayTest()
        {
            string[] names = new string[4];
            // string[] names = new string[4] {"Tyler", "John", "Jane", "Tobi"};  // initial set
            names[0] = "Tyler";
            names[1] = "John";
            names[2] = "Jane";
            names[3] = "Tobi";
        }

        static int validInt()
        {
            // variable decloration
            bool result; // this will check if the num is a(n) int
            int userNum; // this will be the users num and will be checked
            string userInput; // this is the userInput

            Console.Write("Please provide a(n) whole number: ");
            do
            {
                // prompt user for valid number (logic)
                userInput = Console.ReadLine();
                result = int.TryParse(userInput, out userNum);

                if (!result || userNum < 1)
                {
                    Console.Write("Please enter a valid whole number: ");
                } // end of if
            
            } while (!result || userNum < 1); // end of do while

            return userNum;
        } // end of if




    }
}