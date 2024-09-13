using System;
using System.Numerics;

public class feet2inches
{
    public static void Main(string[] args)
    {
        // declare variables
        double totalFeet = 0;

        do
        {
            // Basic Feet to Inches Program | Tyler Le | 9.9.24
            Console.Write ("How many feet? ");
            totalFeet = Convert.ToDouble(Console.ReadLine());
            if (totalFeet < 0)
            {
                Console.WriteLine("Please input a real number");
            }   // end of if

        } 
        while (totalFeet < 0);   // end of do while

        // basic conversion, and output
        double totalInches = totalFeet * 12;
        Console.WriteLine("You have " + totalInches + " inches in total");
    }
}