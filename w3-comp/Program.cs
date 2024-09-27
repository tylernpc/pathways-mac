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
                        string line;
                        while ((line = sr.ReadLine()) != null && row < employee.Length)
                        {
                            // split parts based on a delimiter
                            string[] parts = line.Split(':');

                            // assigning parts to rows and loops through
                            if (parts.Length == 4)
                            {
                                // split the txt file into three parts
                                string empType = parts[0];
                                lastName = parts[1];
                                firstName = parts[2];
                                payAmt = Convert.ToDouble(parts[3]);
                            }
                            // Console.WriteLine(line); Reads out things
                        }
                    }
                }


                // let's the user pass the parameters
                while (positionMet == false)
                {
                    Console.Write("Are you hourly or salary or other: ");
                    typeOfEmployee = Console.ReadLine().ToUpper();

                    if (typeOfEmployee == "SALARY")
                    {
                        positionMet = true;
                        Console.Write("What is your pay annually: ");
                        payAmt = Convert.ToDouble(Console.ReadLine());
                    }
                    else if (typeOfEmployee == "HOURLY")
                    {
                        positionMet = true;
                        Console.Write("What is your pay hourly: ");
                        payAmt = Convert.ToDouble(Console.ReadLine());
                    }
                    else if (typeOfEmployee == "OTHER")
                    {
                        positionMet = true;
                        Console.Write("What are you being paid: ");
                        payAmt = Convert.ToDouble(Console.ReadLine());
                    }
                }


                // prompt user for first and last name
                Console.Write("Please enter a first name: ");
                firstName = Console.ReadLine();

                Console.Write("Please enter a last name: ");
                lastName = Console.ReadLine();

                Employee hourlyPay = new Hourly(payAmt, lastName, firstName);
                Console.WriteLine($"{hourlyPay} with a bonus of {hourlyPay.CalculateBonus()}");

                Employee salaryPay = new Salary(payAmt, lastName, firstName);
                Console.WriteLine($"{salaryPay} with a bonus of {salaryPay.CalculateBonus()}");


            } while (!(userChoiceString == "Q"));
        }
    }
}