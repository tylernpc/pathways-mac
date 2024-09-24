// Cafe Review
using System;
using System.Data;
using System.Formats.Asn1;
using System.IO;
using System.Net.Mail;

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
            string file = "reviews.txt";
            bool userChoice;
            string userChoiceString;
            int rowArray = 25; // ROW, 0
            int colArray = 25; // COLUMN, 1
            string[,] mainArray = new string[rowArray, colArray];

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
                            Console.WriteLine(""); // spacer
                            string s = ""; // setting line
                            Console.WriteLine("File cuisine.txt has been loaded.");
                            // reads and processes each line
                            while ((s = sr.ReadLine()) != null && row < arrayRow)
                            {
                                // split parts based on a delimiter (-)
                                string[] parts = s.Split('-');

                                // file validation pretty much, just checks on if the parts were split
                                if (parts.Length == 3)
                                {
                                    // stores the first portion into the 0 index and the second portion into the 1 index
                                    for (int col = 0; col < s.Length && col < arrayColumn; col++)
                                    {
                                        mainArray[row, col] = parts[col];
                                    }
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
                        for (int row = 0; row < rowArray; row++)
                        {
                            // secures any blanks
                            if (!string.IsNullOrEmpty(mainArray[row, 0]))
                            {
                                // delimited save so when it writes it all down it's in the correct format
                                string s = string.Join("-", mainArray[row, 0],
                                mainArray[row, 1],
                                mainArray[row, 2],
                                mainArray[row, 3],
                                mainArray[row, 4],
                                mainArray[row, 5],
                                mainArray[row, 6],
                                mainArray[row, 7],
                                mainArray[row, 8],
                                mainArray[row, 9],
                                mainArray[row, 10],
                                mainArray[row, 11],
                                mainArray[row, 12],
                                mainArray[row, 13],
                                mainArray[row, 14],
                                mainArray[row, 15],
                                mainArray[row, 16],
                                mainArray[row, 17],
                                mainArray[row, 18],
                                mainArray[row, 19],
                                mainArray[row, 20],
                                mainArray[row, 21],
                                mainArray[row, 22],
                                mainArray[row, 23],
                                mainArray[row, 24],
                                mainArray[row, 25]);

                                // pen writing, new per line
                                writer.WriteLine(s);
                            } // end of if
                        } // end of for
                    } // end of using
                    Console.WriteLine("Save Successful.");
                }
                else if (userChoiceString == "C")
                {
                    Console.WriteLine("");
                    string newRestaurant;
                    string newCuisine;
                    string newRating;
                    bool spotAvailalbe = false;

                    for (int row = 0; row < rowArray; row++)
                    {
                        if (string.IsNullOrEmpty(mainArray[row, 0]))
                        {
                            // position found
                            spotAvailalbe = true;

                            // prompt user for new restaurant at open space
                            Console.Write("Please enter a restaurant name: ");
                            newRestaurant[row, 0] = Console.ReadLine();

                            Console.Write("Please enter a cuisine: ");
                            newCuisine[row, 1] = Console.ReadLine();

                            for (int col = 0; col <= 24; col++)
                            {
                                
                            }

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