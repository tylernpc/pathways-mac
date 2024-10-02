using System;
/*
step 1 : create a unit
step 2 : get user input
step 3 : produce output
*/


public class carpetLand
{
    public static void Main(string[] args)
    {
        // Standard unit is one piece of floor, which is equivalent to 4 sq. ft hence the 4 | 1 piece = 4 sq. ft
        double standardUnit = 4;

        // Input, asking the user how much sq. footage there is
        Console.Write("How much square footage do you have in total? ");
        double totalUserFeet = Convert.ToDouble(Console.ReadLine());

        // Output, giving the total amount of pieces the user needs in order to complete their project
        double totalPurchasedFeet = totalUserFeet / standardUnit;
        Console.WriteLine($"You will need {totalPurchasedFeet} pieces");
    }
}