using System.Formats.Asn1;

namespace w3Comp;
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
                    case "D": // done
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

                        if (empType == "Temp")
                        {
                            employee[row] = new Employee(empType, lastName, firstName, payAmt);
                        }
                        else if (empType == "Contract")
                        {
                            employee[row] = new Employee(empType, lastName, firstName, payAmt);
                        }
                        else if (empType == "Hourly")
                        {
                            employee[row] = new HourlyEmployee(payAmt, lastName, firstName);
                        }
                        else if (empType == "Salary")
                        {
                            employee[row] = new SalaryEmployee(payAmt, lastName, firstName);
                        }
                        row++;

                    }
                }
                Console.WriteLine($"{fileName} loaded successfully!");
            }
            else if (userChoiceString == "S")
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    for (row = 0; row < employee.Length; row++)
                    {
                        if (employee[row] != null)
                        {
                            // writer.WriteLine($"{employee[row].GetType().Name} : {employee[row].LastName} : {employee[row].FirstName} : {employee[row].Pay}");


                            // writer.WriteLine($"{employee[row].GetType().Name} : {employee[row].LastName} : {employee[row].FirstName} : {employee[row].Pay}");

                            if (employee[row].GetType().Name == "Employee")
                            {
                                writer.WriteLine($"Employee : {employee[row].LastName} : {employee[row].FirstName} : {employee[row].Pay}");
                            }
                            else if (employee[row].GetType().Name == "HourlyEmployee")
                            {
                                writer.WriteLine($"Hourly : {employee[row].LastName} : {employee[row].FirstName} : {employee[row].Pay}");
                            }
                            else if (employee[row].GetType().Name == "SalaryEmployee")
                            {
                                writer.WriteLine($"Salary : {employee[row].LastName} : {employee[row].FirstName} : {employee[row].Pay}");
                            }
                        }
                    }
                }
                Console.WriteLine($"{fileName} saved successfully!");
            }
            else if (userChoiceString == "C")
            {
                bool isSpotAvailable = false;

                for (row = 0; row < employee.Length; row++)
                {
                    if (employee[row] == null)
                    {
                        Console.Write("Are you Temp / Contract / Salary / Hourly: ");
                        typeOfEmployee = Console.ReadLine();

                        Console.Write("First Name: ");
                        firstName = Console.ReadLine();

                        Console.Write("Last Name: ");
                        lastName = Console.ReadLine();

                        Console.Write("Pay: ");
                        payAmt = Convert.ToDouble(Console.ReadLine());

                        if (typeOfEmployee == "Temp" || typeOfEmployee == "Contractor")
                        {
                            employee[row] = new Employee(payAmt, lastName, firstName);
                        }
                        else if (typeOfEmployee == "Hourly")
                        {
                            employee[row] = new HourlyEmployee(payAmt, lastName, firstName);
                        }
                        else if (typeOfEmployee == "Salary")
                        {
                            employee[row] = new SalaryEmployee(payAmt, lastName, firstName);
                        }

                        isSpotAvailable = true;
                        Console.WriteLine("Employee successfully added!");
                        break;
                    }
                }
                if (!isSpotAvailable)
                {
                    Console.WriteLine("There are no available spots, please delete or update");
                }
            }
            else if (userChoiceString == "R")
            {
                for (row = 0; row < employee.Length; row++)
                {
                    if (employee[row] != null)
                    {
                        Console.WriteLine(employee[row].ToString());
                    }
                }
            }
            else if (userChoiceString == "U")
            {
                bool nameFound = false;
                Console.Write("Input name that needs for user that needs to be updated: ");
                firstName = Console.ReadLine();
                for (row = 0; row < employee.Length; row++)
                {
                    if (employee[row] != null && employee[row].FirstName == firstName)
                    {
                        Console.Write("Are you Contract / Temp / Salary / Hourly: ");
                        typeOfEmployee = Console.ReadLine();

                        Console.Write("First Name: ");
                        firstName = Console.ReadLine();

                        Console.Write("Last Name: ");
                        lastName = Console.ReadLine();

                        Console.Write("Pay: ");
                        payAmt = Convert.ToDouble(Console.ReadLine());

                        if (typeOfEmployee == "Contract")
                        {
                            employee[row] = new Employee(typeOfEmployee, lastName, firstName, payAmt);
                        }
                        else if (typeOfEmployee == "Temp")
                        {
                            employee[row] = new Employee(typeOfEmployee, lastName, firstName, payAmt);
                        }
                        else if (typeOfEmployee == "Hourly")
                        {
                            employee[row] = new HourlyEmployee(payAmt, lastName, firstName);
                        }
                        else if (typeOfEmployee == "Salary")
                        {
                            employee[row] = new SalaryEmployee(payAmt, lastName, firstName);
                        }
                        else
                        {
                            employee[row] = new Employee(typeOfEmployee, lastName, firstName, payAmt);
                        }
                        Console.WriteLine("Employee details updated successfully.");
                        nameFound = true;
                        break;
                    }
                }
                if (nameFound)
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            else if (userChoiceString == "D")
            {
                bool nameFound = false;
                Console.Write("Input name that needs for user that needs to be updated: ");
                firstName = Console.ReadLine();
                for (row = 0; row < employee.Length; row++)
                {
                    if (employee[row] != null && employee[row].FirstName == firstName)
                    {
                        employee[row] = null; // delete by setting to null
                        Console.WriteLine("Employee successfully deleted.");
                        nameFound = true;
                        break;
                    }
                }
            }
            else if (userChoiceString == "Q")
            {
                Console.WriteLine("Thanks for using TylerDB");
            }
        } while (!(userChoiceString == "Q"));
    }
}
