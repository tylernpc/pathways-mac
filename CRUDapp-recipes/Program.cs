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
        const int arrayRow = 3;
        const int arrayColumn = 3;
        string[,] recipeArray = { {arrayRow.ToString()} , {arrayColumn.ToString()} };
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

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
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

            if (userChoiceString=="L" || userChoiceString=="l")
            { try
            {
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
                    Console.WriteLine ("Let's move on...");
            }

            }

        //  TODO: Else if the option is an S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                Console.WriteLine("In the S/s area");
            }

        //  TODO: Else if the option is a C or c then add a name to the array (if there's room there)

            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area");
            }

        //  TODO: Else if the option is an R or r then print the array

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
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

            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
            }

        //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
            }
        //  TODO: Else if the option is a Q or q then quit the program

            else 
            {
                Console.WriteLine("Good-bye!");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
    }  // end main
  }  // end program
}  // end namespace