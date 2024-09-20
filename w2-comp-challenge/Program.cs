using System;
using System.Data;
using System.Formats.Asn1;
using System.IO;

namespace w2CompChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            use streamwriter to use .txt file initally
            prompt user on which operation they'd like

            declare variables
            (2x 1d arrays (max of 25))
                if statement to choose from
                l
                    load data file
                s
                    save data file no clear indexes
                c
                    find first open space
                    prompt user for creation
                r
                    read file
                u
                    prompt user for specific cuisine
                    have user update rating
                d
                    prompt user for specific cuisine
                    delete that cuisine and it's rating
                q
                    quits the program
            */

            // declaring variables
            // selecting the file
            string file = "cuisine";
            bool userChoice;
            string userChoiceString;
            int arraySize = 25;
            string[] cuisineArray = new string[arraySize];
            string[] ratingArray = new string[arraySize];

            // main do while until user quits
            do
            {
                do
                {
                    Console.WriteLine("Cuisine Rating Book");
                    Console.WriteLine("L: Load the data file into an array.\nS: Save the array to the data file.\nC: Add a name to the array.\nR: Read a name from the array.\nU: Update a name in the array.\nD: Delete a name from the array.\nQ: Quit the program.");
                    Console.Write("What operation would you like to do: ");
                    userChoiceString = Console.ReadLine().ToUpper();

                    switch (userChoiceString)
                    {
                        case "L": // done
                        case "S": // done
                        case "C": // done
                        case "R": // done
                        case "U": // done
                        case "D":
                        case "Q": // done
                            userChoice = true;
                            break;
                        default:
                            Console.WriteLine("******************************\nPlease enter a valid opiton.\n******************************");
                            userChoice = false;
                            break;
                    } // end of swtich statement
                } while (!userChoice); // end of do while

                if (userChoiceString == "L")
                {
                    try
                    {
                        int row = 0;
                        using (StreamReader sr = File.OpenText(file))
                        {
                            Console.WriteLine("");
                            string s = "";
                            Console.WriteLine("File cuisine.txt has been loaded.");
                            // reads and processes each line
                            while ((s = sr.ReadLine()) != null && row < arraySize)
                            {
                                // split parts based on a delimiter (-)
                                string[] parts = s.Split('-');

                                // file validation pretty much, just checks on if the parts were split
                                if (parts.Length == 2)
                                {
                                    // stores the first portion into the 0 index and the second portion into the 1 index
                                    cuisineArray[row] = parts[0].Trim();
                                    ratingArray[row] = parts[1].Trim();
                                }
                                else
                                {
                                    // if the file's messed up and not formatted correctly it'll let the user know
                                    Console.WriteLine("Invalid Entry");
                                } // end of if
                                row++;
                            } // end of while
                        } // end of using
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e.Message} type, e.GetType()");
                    }
                    finally
                    {
                        Console.WriteLine("Moving Forward.");
                    } // end of try catch
                }
                else if (userChoiceString == "S")
                {
                    Console.WriteLine("");
                    // overwrite portion
                    using (StreamWriter writer = new StreamWriter("cuisine"))
                    {
                        // loop through each row of the array
                        for (int row = 0; row < arraySize; row++)
                        {
                            // secures any blanks
                            if (!string.IsNullOrEmpty(cuisineArray[row]))
                            {
                                writer.WriteLine($"{cuisineArray[row]} - {ratingArray[row]}");
                            } // end of if
                        } // end of for
                    } // end of using
                    Console.WriteLine("Save Successful.");
                }
                else if (userChoiceString == "C")
                {
                    Console.WriteLine("");
                    string newCuisine;
                    string newRating;
                    bool spotAvailalbe = false;

                    for (int row = 0; row < arraySize; row++)
                    {
                        if (string.IsNullOrEmpty(cuisineArray[row]))
                        {
                            // position found
                            spotAvailalbe = true;

                            // prompt user for new cuisine at open space
                            Console.Write("Please enter a cuisine: ");
                            newCuisine = Console.ReadLine();

                            // prompts for rating
                            Console.Write("Please enter a rating from (0-5): ");
                            newRating = Console.ReadLine() + " stars";
                            
                            // creating new cuisine and rating
                            cuisineArray[row] = newCuisine;
                            ratingArray[row] = newRating;

                            break;
                        }// end of if
                    } // end of for
                    if (!spotAvailalbe)
                    {
                        Console.WriteLine("No avaiable spots exist, please delete or update a cuisine.");
                    } // end of if
                }
                else if (userChoiceString == "R")
                {
                    Console.WriteLine("");
                    // for loop that runs through every cuisine item
                    for (int row = 0; row < arraySize; row++)
                    {
                        if (!string.IsNullOrEmpty(cuisineArray[row]))
                        {
                            // displays items in this format sifting through each item
                            Console.WriteLine($"Cuisine: {cuisineArray[row]} - {ratingArray[row]}");
                        }
                        else
                        {
                            Console.WriteLine("This space is available.");
                        } // end of if
                    } // end of for
                }
                else if (userChoiceString == "U")
                {
                    Console.WriteLine("");
                    string oldCuisine;
                    string newCuisine;
                    string newRating;
                    bool cuisineFound;

                    do
                    {
                        cuisineFound = false;

                        Console.Write("Please enter a(n) old cuisine: ");
                        oldCuisine = Console.ReadLine();

                        // for loop that runs through every cuisine item
                        for (int row = 0; row < arraySize; row++)
                        {
                            // checks if it finds the description
                            if (cuisineArray[row] == oldCuisine)
                            {
                                cuisineFound = true;

                                // prompt user for new rating
                                Console.Write("Please enter a(n) new cuisine: ");
                                newCuisine = Console.ReadLine();

                                // prompt user for new rating
                                Console.Write("Please enter a rating (0-5): ");
                                newRating = Console.ReadLine() + " stars";

                                // sets new cuisine and rating
                                cuisineArray[row] = newCuisine;
                                ratingArray[row] = newRating;

                                break;
                            } // end of if
                        } // end of for
                        if (!cuisineFound)
                        {
                            Console.Write("The cuisine was not found ");
                        } // end of if
                    } while (!cuisineFound); // end of do while
                }
                else if (userChoiceString == "D")
                {
                    Console.WriteLine("");
                    string oldCuisine;
                    string blank = "";
                    bool cuisineFound;

                    do
                    {
                        cuisineFound = false;

                        Console.Write("Please enter a(n) old cuisine: ");
                        oldCuisine = Console.ReadLine();

                        // for loop that goes through each array item
                        for (int row = 0; row < arraySize; row++)
                        {
                            if (cuisineArray[row] == oldCuisine && cuisineFound == false)
                            {
                                cuisineFound = true;
                                
                                // sets both blank
                                cuisineArray[row] = blank;
                                ratingArray[row] = blank;
                            } // end of if
                        } // end of for
                        if (!cuisineFound)
                        {
                            Console.Write("The cuisine was not found ");
                        } // end of if
                    } while (cuisineFound == false); // end of do while
                }
                else if (userChoiceString == "Q")
                {
                    Console.WriteLine("Thank you for using our cuisine service!");
                } // end of if

            } while (!(userChoiceString == "Q")); // end of do while
        }
    }
}