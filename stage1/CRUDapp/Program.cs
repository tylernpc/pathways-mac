using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            bool userChoice;
            string userChoiceString;
            const int arraySize = 12;
            string[] nameArray = new string[arraySize];
            string fileName = "name.txt";

            // Repeat main loop
            do
            {

                // TODO: Get a valid input
                do
                {
                    //  Initialize variables

                    userChoice = false;

                    //  TODO: Provide the user a menu of options

                    Console.Write("What operation would you like to do? ");
                    Console.WriteLine("L: Load the data file into an array.");
                    Console.WriteLine("S: Save the array to the data file.");
                    Console.WriteLine("C: Add a name to the array.");
                    Console.WriteLine("R: Read a name from the array.");
                    Console.WriteLine("U: Update a name in the array.");
                    Console.WriteLine("D: Delete a name from the array.");
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
                        Console.WriteLine("In the L/l area");

                        int index = 0;  // index for my array
                        using (StreamReader sr = File.OpenText(fileName))
                        {
                            string s = "";
                            Console.WriteLine(" Here is the content of the file names.txt : ");
                            while ((s = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(s);
                                nameArray[index] = s;
                                index = index + 1;
                            }
                            Console.WriteLine("");
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message + " type, " + e.GetType());
                        if (e.GetType().ToString() == "System.IndexOutOfRangeException")
                        {
                            Console.WriteLine("There is a system error");
                        }
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
 
                    // updating logic, also opens a streamwriter to write data to the names.txt **will create if not exist**'
                    // if anything exists in it, it will be overwritten
                    using (StreamWriter writer = new StreamWriter("names.txt"))
                    {
                        // loops through each name of the array
                        for (int index = 0; index < nameArray.Length; index++)
                        {
                            // checks if the current index is empty or null, this makes it so there isn't any blanks
                            if (!string.IsNullOrEmpty(nameArray[index]))
                            {
                                // essentially the pen writing, new per line
                                writer.WriteLine(nameArray[index]);
                            }
                        }
                    }
                    Console.WriteLine("Information saved to file successfully");
                }

                //  TODO: Else if the option is a C or c then add a name to the array (if there's room there)

                else if (userChoiceString == "C" || userChoiceString == "c")
                {
                    Console.WriteLine("In the C/c area");
                    /*
                    for loop through each index to check if there's a(n) available spot
                    if spot exist
                        prompt for name
                        add to spot
                    else
                        sorry there's no position available
                    */

                    // used to check if thing is available
                    bool isSpotAvailable = false;

                    // for loop that goes through each index for an available space
                    for (int index = 0; index < nameArray.GetLength(0); index++)
                    {
                        // checks if the index is empty or not
                        if (string.IsNullOrEmpty(nameArray[index]))
                        {
                            // prompt user for input
                            Console.Write("Please enter a name: ");
                            string newName = Console.ReadLine();
                            // adds users name to index
                            nameArray[index] = newName;
                            isSpotAvailable = true;
                            break;
                        }
                    }
                    if (!isSpotAvailable)
                    {
                        // lets user know it's full
                        Console.WriteLine("The array is full.");
                    }
                }

                //  TODO: Else if the option is an R or r then print the array

                else if (userChoiceString == "R" || userChoiceString == "r")
                {
                    // alec generated code
                    Console.WriteLine("In the R/r area");
                    for (int index = 0; index < arraySize; index++)
                    {
                        if ((nameArray[index]) != " ")
                            Console.WriteLine(nameArray[index]);
                        else
                            Console.WriteLine("Index " + index + " is available.");
                    }
                }
                //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

                else if (userChoiceString == "U" || userChoiceString == "u")
                {
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
                        while
                    replace the name with the new name
                    */
                    // ENDED UP HAVING TO FLIP THE DO WHILE LOGIC WITH FOR

                    // declare variable
                    string oldName;
                    string newName;
                    bool nameSearch = false;

                    // prompt user for which name they want to update
                    Console.Write("Which name do you want to update: ");


                    // user validation to make sure the name is found
                    do
                    {
                        oldName = Console.ReadLine();

                        // checks if the name exists
                        for (int index = 0; index < nameArray.Length; index++)
                        {

                            if (nameArray[index] == oldName)
                            {
                                // logic to confirm name was found
                                nameSearch = true;

                                // prompts user for new name
                                Console.Write("");
                                Console.Write("What new name would you like to enter: ");
                                newName = Console.ReadLine();

                                // update the name in the array
                                nameArray[index] = newName;
                                break;
                            }
                        }
                        // logic to check if the name wasn't found
                        if (!nameSearch)
                        {
                            Console.Write("The name was not found. Please enter a valid name: ");
                        }
                    } while (!nameSearch);
                }

                //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

                else if (userChoiceString == "D" || userChoiceString == "d")
                {
                    Console.WriteLine("In the D/d area");
                    /* 
                    similar logic to before
                    prompt user for deletion option
                    do while loop for user validation
                        for loop to find it
                        prompt user to confirm
                    delete it
                    */

                    string name;
                    bool nameSearch = false;

                    Console.Write("Which name do you want to delete: ");

                    // user validation to make sure the name is found
                    do
                    {
                        name = Console.ReadLine();

                        // for loop to find the name
                        for (int index = 0; index < nameArray.Length; index++)
                        {
                            if (nameArray[index] == name)
                            {
                                // logic to confirm if name was found
                                nameSearch = true;

                                // update the name in the array to be blank
                                nameArray[index] = "";
                                break;
                            }
                        }
                        // logic to check if the name wasn't found
                        if (!nameSearch)
                        {
                            Console.Write("The name was not found. Please enter a valid name: ");
                        }
                    } while (!nameSearch);



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