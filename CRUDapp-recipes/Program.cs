using System;
using System.Data;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            bool userChoice;
            string userChoiceString;
            const int arrayRow = 5;
            const int arrayColumn = 5;
            string[,] recipeArray = new string[arrayRow, arrayColumn];
            string fileName = "recipes.txt";

            // Repeat main loop
            do
            {

                // TODO: Get a valid input
                do
                {
                    //  Initialize variables

                    userChoice = false;

                    //  TODO: Provide the user a menu of options

                    Console.WriteLine("What's your pleasure? ");
                    Console.WriteLine("L: Load the data file into an array.");
                    Console.WriteLine("S: Save the array to the data file.");
                    Console.WriteLine("C: Add a recipe to the array.");
                    Console.WriteLine("R: Read a recipe from the array.");
                    Console.WriteLine("U: Update a recipe in the array.");
                    Console.WriteLine("D: Delete a recipe from the array.");
                    Console.WriteLine("Q: Quit the program.");

                    //  TODO: Get a user option (valid means its on the menu)

                    userChoiceString = Console.ReadLine();

                    userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                                userChoiceString == "S" || userChoiceString == "s" ||
                                userChoiceString == "C" || userChoiceString == "c" ||
                                userChoiceString == "R" || userChoiceString == "r" ||
                                userChoiceString == "U" || userChoiceString == "u" ||
                                userChoiceString == "D" || userChoiceString == "d" ||
                                userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                } while (!userChoice);

                //  TODO: If the option is L or l then load the text file (names.txt) into the array of strings (nameArray)

                if (userChoiceString == "L" || userChoiceString == "l")
                {
                    try
                    {
                        Console.WriteLine("");
                        Console.WriteLine("In the L/l area");

                        // row index for the array
                        int row = 0;

                        using (StreamReader sr = File.OpenText(fileName))
                        {

                            string line = "";
                            Console.WriteLine("Here is the content of the file recipes.txt : ");

                            while ((line = sr.ReadLine()) != null && row < arrayRow)
                            {
                                Console.WriteLine(line);

                                // split parts based on a delimiter
                                string[] parts = line.Split(',');

                                // assigning parts to rows
                                for (int col = 0; col < parts.Length && col < arrayColumn; col++)
                                {
                                    recipeArray[row, col] = parts[col];
                                }
                                row++;
                            }
                            Console.WriteLine("");
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Sorry that file isn't found" + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Let's move on...");
                    }

                }

                //  TODO: Else if the option is an S or s then store the array of strings into the text file

                else if (userChoiceString == "S" || userChoiceString == "s")
                {
                    Console.WriteLine("In the S/s area");

                    using (StreamWriter writer = new StreamWriter("recipes.txt"))
                    {
                        // Loop through each row of the array
                        for (int row = 0; row < arrayRow; row++)
                        {
                            if (!string.IsNullOrEmpty(recipeArray[row, 0]))
                            {
                                // delimited save so when it writes it all down it's in the right format
                                string line = string.Join(",", recipeArray[row, 0],
                                    recipeArray[row, 1],
                                    recipeArray[row, 2],
                                    recipeArray[row, 3],
                                    recipeArray[row, 4]);

                                // essentially the pen writing, new per line
                                writer.WriteLine(line);
                            }
                        }
                    }

                    Console.WriteLine("Information saved to file successfully");
                }

                //  TODO: Else if the option is a C or c then add a name to the array (if there's room there)

                else if (userChoiceString == "C" || userChoiceString == "c")
                {
                    Console.WriteLine("");
                    Console.WriteLine("In the C/c area");
                    /*
                    for loop through each column to check if there's a(n) available spot
                    if spot exist
                        prompt user for recipe name
                        prompt user for four ingredients
                    else
                        sorry there's no spaces available
                    */

                    // used to check if space is available
                    bool spaceAvailable = false;

                    for (int row = 0; row < arrayRow; row++)
                    {
                        if (string.IsNullOrEmpty(recipeArray[row, 0]))
                        {
                            // found a spot
                            spaceAvailable = true;

                            // storing the new recipe in the first available spot in position 0
                            Console.Write("Enter a recipe name: ");
                            recipeArray[row, 0] = Console.ReadLine();

                            // 
                            for (int col = 1; col <= 4; col++)
                            {
                                // storing the new ingredients to the new recipe
                                Console.WriteLine("Please enter 1-5 ingredients");
                                Console.Write($"Please enter a(n) ingredient {col}: ");
                                recipeArray[row, col] = Console.ReadLine();
                            }

                            break; // exits the loop once an empty spot is found and filled
                        }
                    }
                    // lets user know there's no space available
                    if (!spaceAvailable)
                    {
                        Console.WriteLine("Sorry, there's no space available.");
                    }
                }

                //  TODO: Else if the option is an R or r then print the array

                else if (userChoiceString == "R" || userChoiceString == "r")
                {
                    Console.WriteLine("");
                    Console.WriteLine("In the R/r area");
                    for (int row = 0; row < arrayRow; row++)
                    {
                        for (int col = 0; col < arrayColumn; col++)
                        {
                            if (!string.IsNullOrEmpty(recipeArray[row, col]))
                            {
                                Console.WriteLine($"recipeArray[{row}, {col}] = {recipeArray[row, col]}");
                            }
                            else
                            {
                                Console.WriteLine($"recipeArray[{row}, {col}] is available.");
                            }
                        }
                    }

                }
                //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

                else if (userChoiceString == "U" || userChoiceString == "u")
                {
                    Console.WriteLine("");
                    Console.WriteLine("In the U/u area");

                    /*
                    prompt user to which name they want to update
                    for loop looking through each index
                        do
                        check if match
                            if match
                                prompt user to replace
                            if no match
                                tell user there was no match
                        replace the recipe with the new recipe
                    */

                    // used to check if space is available
                    string oldRecipe;
                    string newRecipe;
                    bool recipeSearch = false;

                    // prompt user for which recipe they'd like to change
                    Console.Write("Which recipe would you like to update: ");

                    do
                    {
                        // gets old recipe name
                        oldRecipe = Console.ReadLine();

                        // accesses the array
                        for (int row = 0; row < arrayRow; row++)
                        {
                            // loops through the recipes
                            if (recipeArray[row, 0] == oldRecipe)
                            {
                                // name was found
                                recipeSearch = true;

                                // prompt user for new name
                                Console.Write("");
                                Console.Write("What new recipe would you like to enter: ");
                                newRecipe = Console.ReadLine();

                                // update the recipe in the array
                                recipeArray[row, 0] = newRecipe;
                                break;
                            }
                        }
                        // error handling
                        if (!recipeSearch)
                        {
                            Console.Write("The recipe was not found. Please enter another recipe: ");
                        }
                    } while (!recipeSearch);
                }

                //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

                else if (userChoiceString == "D" || userChoiceString == "d")
                {
                    Console.WriteLine("");
                    Console.WriteLine("In the D/d area");
                    /*
                    prompt user for a recipe
                    deletes that row
                    */

                    string oldRecipe;
                    string newRecipe = "";
                    bool recipeSearch = false;

                    // prompt user for which recipe they'd like to change
                    Console.Write("Which recipe would you like to update: ");

                    do
                    {
                        // gets old recipe name
                        oldRecipe = Console.ReadLine();

                        // accesses the array
                        for (int row = 0; row < arrayRow; row++)
                        {
                            // loops through the recipes
                            if (recipeArray[row, 0] == oldRecipe)
                            {
                                // name was found
                                recipeSearch = true;

                                // update the recipe in the array
                                recipeArray[row, 0] = newRecipe;
                                break;
                            }
                        }
                        // error handling
                        if (!recipeSearch)
                        {
                            Console.Write("The recipe was not found. Please enter another recipe: ");
                        }
                    } while (!recipeSearch);
                }
                //  TODO: Else if the option is a Q or q then quit the program

                else
                {
                    Console.WriteLine("Good-bye!");
                }
            } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));
        }  // end main
    }  // end program
}  // end namespace