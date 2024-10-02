// accumulator problem
// prompt user for five numbers
//   validate five numbers
// add five numbers
// output five number
using System;

public class accumulatorProblem
{
    public static void Main(string[] args)
    {
        // declare variables
        double userNum;
        double totalNum = 0;

        // for loop, five times
        for (int i = 0; i < 5; i++)
        {   
            // user prompt
            do
            {
                Console.Write("Please enter a Number from 1-100: ");
                // control variable
                userNum = Convert.ToDouble(Console.ReadLine());
                if (userNum < 1 || userNum > 100)
                {
                    Console.WriteLine("Please select a number between 1 and 100");
                }   // end of if

            } while (userNum < 1 || userNum > 100);   // end of do while loop

            // accumulator process
            totalNum = totalNum + userNum;

        }   // end of for loop
        Console.WriteLine("The Total Output Is " + totalNum);
    }
}
