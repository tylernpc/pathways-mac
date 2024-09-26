// main program
using System;
using System.ComponentModel;

namespace w3Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfPay;
            string payAmt;
            string lastName;
            string firstName;
            

            Console.WriteLine("Are you hourly or salary? ");
            
            Employee hourlyPay = new Hourly(true, 25, "Le", "Tyler", "Hourly");
            Console.WriteLine($"{hourlyPay} with a bonus of {hourlyPay.CalculateBonus()}");

            Employee salaryPay = new Salary(true, 60000, "Le", "Tyler", "Hourly");
            Console.WriteLine($"{salaryPay} with a bonus of {salaryPay.CalculateBonus()}");
        }
    }    
}