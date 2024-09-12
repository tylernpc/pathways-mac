// method testing, and practice. also arrays
using System;
using System.Security.Cryptography;

public class methodPractice
{
    public static void Main(string[] args)
    {
        // declaring standard variables
        string selectedBrand;
        

        // creating a basic array, and declaring them
        string[] germanBrands = {"Porsche", "Mercedes", "Audi", "BMW"};
        string[] americanBrands = {"Ford", "Chevy", "Tesla", "Dodge",};

        // prompting the user
        Console.Write("Hello, what car brand are you interested in looking at today: ");


    }

    // method that gives the do while loop
    static void carWhileLoop()
    {
        string selectedBrand;

        do
        {
            Console.WriteLine("Are you interested in American or German cars? ");
            selectedBrand = Console.ReadLine().ToUpper();

            if (selectedBrand != "GERMAN" && selectedBrand != "AMERICAN")
            {
                Console.WriteLine("Please select either German or American");
            }
        } while (selectedBrand != "GERMAN" && selectedBrand != "AMERICAN");

        do
        {
            if (selectedBrand == "Porsche")
            {
                selectedBrand == "Thing"
            }

        } while ()
    }
}