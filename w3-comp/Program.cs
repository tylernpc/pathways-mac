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
            double payAmt = 0; // kind of redundant but this gets user pay
            string lastName;
            string firstName;
            bool positionMet = false; // this breaks the loop if one of the three options are chosen

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
        }
    }
}