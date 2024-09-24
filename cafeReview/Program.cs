// cafeReview
using System;
using System.Runtime.InteropServices;

// Main Program this.isNotAMonolithicProgram
// Tyler Le

namespace CafeReview
{
    class Progarm
    {
        static void Main(string[] args)
        {
            /*
            I think i'm going to have a decent chunk of logic on here but hopefully just the necessary stuff
            */

            const int arrayRow = 25;
            const int arrayColumn = 25;
            string[,] mainArray = new string[arrayRow, arrayColumn];

            Console.Write("O P E R A T I O N S");
            Console.WriteLine("L: Load the data file into an array.");
            Console.WriteLine("S: Save the array to the data file.");
            Console.WriteLine("C: Add a recipe to the array.");
            Console.WriteLine("R: Read a recipe from the array.");
            Console.WriteLine("U: Update a recipe in the array.");
            Console.WriteLine("D: Delete a recipe from the array.");
            Console.WriteLine("Q: Quit the program.");
            Console.Write("Input Choice: ");
            string userChoice = Console.ReadLine().ToUpper();




            // FileManager fileManager = new FileManager();
            // fileManager.ReadReviews(userChoice);

            RestaurantManager restaurantManager = new RestaurantManager();
            restaurantManager.MainOperations(userChoice, mainArray, arrayRow, arrayColumn);


        }
    }
}