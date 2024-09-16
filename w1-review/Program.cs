using System;
using System.Net.Mail;
using System.Reflection;

namespace w1Review
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int userNum; // name method
            string myWord; // reversal method


            // arrayName method
            userNum = validInt();
            arrayName(userNum);

            // reversal method
            Console.Write("Please enter a word: ");
            myWord = Console.ReadLine();
            arrayReversal(myWord);
        }

        static void arrayName(int userNum)
        {
            string[] names = new string[4];
            // string[] names = new string[4] {"Tyler", "John", "Jane", "Tobi"};  // initial set
            names[0] = "Tyler";
            names[1] = "John";
            names[2] = "Jane";
            names[3] = "Tobi";

            Console.WriteLine(names[userNum]);            
        }

        static void arrayReversal(string userInput)
        {
            // declaring variables
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(charArray);            
        } // end of reversal method

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