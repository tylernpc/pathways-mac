/*
L | LoadData(string filePath)
S | SaveData(string filePath)
C | AddRestaurant(string name, string cuisine, string rating)
R | ReadRestaurants()
U | UpdateRestaurant(string oldName, string newName, string newCuisine, string newRating)
D | DeleteRestaurant(string name)f
*/

class RestaurantManager
{
    // row index for the array
    // file name/path
    private string fileName = "reviews.txt";

    // default constructor, just the file
    public RestaurantManager()
    {
        this.fileName = "reviews.txt";
    }

    // does a read on the file, alternative to the load portion just directly reads
    public void MainOperations(string userChoice, string[,] mainArray, int arrayRow, int arrayColumn)
    {
        while (userChoice != "Q")
        {
            // chooses this on the main class
            if (userChoice == "L")
            {
                // minor user validation
                try
                {
                    // declares row to start
                    int row = 0;

                    // operation to read/open the file
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        // states the line
                        string line;
                        while ((line = sr.ReadLine()) != null && row < arrayRow)
                        {
                            // split parts based on a delimiter
                            string[] parts = line.Split('-');

                            // assigning parts to rows and repeats them all
                            for (int col = 0; col < parts.Length && col < arrayColumn; col++)
                            {
                                mainArray[row, col] = parts[col];
                            }
                            row++;
                        }
                    }
                    Console.WriteLine("Data loaded succesfully!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message} is there error, try again.");
                }
            } // save option
            else if (userChoice == "S")
            {
                using (StreamWriter writer = new StreamWriter("reviews.txt"))
                {
                    // Loop through each row of the array
                    for (int row = 0; row < arrayRow; row++)
                    {
                        if (!string.IsNullOrEmpty(mainArray[row, 0]))
                        {
                            // delimited save so when it writes it all down it's in the right format
                            string line = string.Join(",", mainArray[row, 0],
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
                            // essentially the pen writing, new per line
                            writer.WriteLine(line);
                        }
                    }
                }
                Console.WriteLine("Information saved to file succesfully!");
            }
            else if (userChoice == "C")
            {
                bool spaceAvailable = false;

                for (int row = 0; row < arrayRow; row++)
                {
                    if (string.IsNullOrEmpty(mainArray[row, 0]))
                    {
                        // found a spot
                        spaceAvailable = true;

                        // storing the new restaurant
                        Console.Write("Please enter a restaurant name: ");
                        string restaurantName = Console.ReadLine();

                        // storing the new cuisine
                        Console.Write("Please enter a cuisine: ");
                        string cuisineType = Console.ReadLine();

                        //storing the new rating
                        Console.Write("Please enter a rating from (0-5): ");
                        int totalRating = Convert.ToInt32(Console.ReadLine());

                        Restaurant newRestaurant = new Restaurant(restaurantName, cuisineType, totalRating);

                        mainArray[row, 0] = newRestaurant.RestaurantName;
                        mainArray[row, 1] = newRestaurant.CuisineType;
                        mainArray[row, 2] = newRestaurant.TotalRating.ToString();

                        break;
                    }
                }
                if (!spaceAvailable)
                {
                    Console.WriteLine("No available space for a new restaurant.");
                }
            }
            else if (userChoice == "R")
            {
                // minor user validation
                try
                {
                    // operation to read/open the file
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        // goes line by line and just writes it out
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message} is there error, try again.");
                }
            }
            else if (userChoice == "U")
            {
                string oldRestaurantName;
                string newRestaurantName;
                bool restaurantSearch = false;

                // prompt user for which restaurant they'd like to change
                Console.Write("Which Restaurant would you like to update: ");

                do
                {
                    // gets old restaurant name
                    oldRestaurantName = Console.ReadLine();

                    // accesses the array
                    for (int row = 0; row < arrayRow; row++)
                    {
                        if (mainArray[row, 0] == oldRestaurantName)
                        {
                            // name was found
                            restaurantSearch = true;

                            // storing the new restaurant
                            Console.Write("Please enter a restaurant name: ");
                            string restaurantName = Console.ReadLine();

                            // storing the new cuisine
                            Console.Write("Please enter a cuisine: ");
                            string cuisineType = Console.ReadLine();

                            //storing the new rating
                            Console.Write("Please enter a rating from (0-5): ");
                            int totalRating = Convert.ToInt32(Console.ReadLine());

                            Restaurant newRestaurant = new Restaurant(restaurantName, cuisineType, totalRating);

                            mainArray[row, 0] = newRestaurant.RestaurantName;
                            mainArray[row, 1] = newRestaurant.CuisineType;
                            mainArray[row, 2] = newRestaurant.TotalRating.ToString();
                        }
                    }
                } while (!restaurantSearch);
            }
            else if (userChoice == "D")
            {
                string oldRestaurantName;
                string newRestaurantName;
                bool restaurantSearch = false;

                // prompt user for which restaurant they'd like to change
                Console.Write("Which Restaurant would you like to update: ");

                do
                {
                    // gets old restaurant name
                    oldRestaurantName = Console.ReadLine();

                    // accesses the array
                    for (int row = 0; row < arrayRow; row++)
                    {
                        if (mainArray[row, 0] == oldRestaurantName)
                        {
                            // name was found
                            restaurantSearch = true;

                            // storing the new restaurant
                            Console.Write("Please enter a restaurant name: ");
                            string restaurantName = "";

                            // storing the new cuisine
                            Console.Write("Please enter a cuisine: ");
                            string cuisineType = "";

                            //storing the new rating
                            Console.Write("Please enter a rating from (0-5): ");
                            int totalRating = 0;
                        }
                    }
                } while (!restaurantSearch);
            }
            else if (userChoice == "Q")
            {
                Console.WriteLine("Goodbye!");
            }

            // breaks out of loop if Q
            Console.Write("O P E R A T I O N S");
            Console.WriteLine("L: Load the data file into an array.");
            Console.WriteLine("S: Save the array to the data file.");
            Console.WriteLine("C: Add a recipe to the array.");
            Console.WriteLine("R: Read a recipe from the array.");
            Console.WriteLine("U: Update a recipe in the array.");
            Console.WriteLine("D: Delete a recipe from the array.");
            Console.WriteLine("Q: Quit the program.");
            Console.Write("Input Choice: ");
            userChoice = Console.ReadLine().ToUpper();
        }
    }
}