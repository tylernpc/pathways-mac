using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace w3Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            string typeOfEmployee;
            double payAmt = 0;
            string lastName;
            string firstName;
            bool positionMet = false; // this breaks the loop if one of the three options are chosen
            bool userChoice = false;
            string userChoiceString;
            Employee[] employee = new Employee[25];
            string fileName = "Employees.txt";
            int row = 0;


            do
            {
                do
                {
                    // initial prompt for lscrudq operations
                    Console.WriteLine("Employee Database");
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
                    }
                } while (!userChoice);


                if (userChoiceString == "L")
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string line = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(':');

                            string empType = parts[0].Trim();
                            lastName = parts[1].Trim();
                            firstName = parts[2].Trim();
                            payAmt = Convert.ToDouble(parts[3].Trim());

                            employee[row] = new Employee(empType, lastName, firstName, payAmt);
                            row++;
                        }
                    }
                }
                else if (userChoiceString == "S")
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        // loop through each row of the array
                        for (row = 0; row < employee.Length; row++)
                        {
                            if (!string.IsNullOrEmpty(employee.Length.ToString()))
                            {
                                writer.WriteLine($"{employee.Length} ");
                            }
                        }
                    }
                }
                else if (userChoiceString == "C")
                {
                    bool isSpotAvailable = false;

                    for (row = 0; row < employee.Length; row++)
                    {
                        if (string.IsNullOrEmpty(employee))
                        {
                            Console.Write("Are you Contract / Temp / Salary / Hourly: ");
                            typeOfEmployee = Console.ReadLine();

                            Console.Write("First Name: ");
                            firstName = Console.ReadLine();

                            Console.Write("Last Name: ");
                            lastName = Console.ReadLine();

                            Console.Write("Pay: ");
                            payAmt = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                }
                else if (userChoiceString == "R")
                {
                    for (row = 0; row < employee.Length; row++)
                    {
                        if (!string.IsNullOrEmpty(Convert.ToString(employee.Length)))
                        {
                            Console.WriteLine(employee[row]);
                        }
                        else
                        {
                            Console.WriteLine("This space is available.");
                        }
                    }
                }
                else if (userChoiceString == "U")
                {

                }
                else if (userChoiceString == "D")
                {

                }
                else if (userChoiceString == "Q")
                {
                    Console.WriteLine("Thanks for using TylerDB");
                }
            } while (!(userChoiceString == "Q"));
        }
    }
}