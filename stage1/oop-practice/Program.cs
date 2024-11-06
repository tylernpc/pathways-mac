using System;

// object-oriented programming practice

namespace programmingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user for manufacture
            Console.Write("Please enter a car manufacture: ");
            string manufacture = Console.ReadLine();

            // prompt user for color
            Console.Write("Please enter a color: ");
            string color = Console.ReadLine();

            // display user first vehicle
            Car vehicle1 = new Car(manufacture, color);
            Console.WriteLine(vehicle1.UserModel);
            Console.WriteLine(vehicle1.UserColor);

            // display user second vehicle
            Car vehicle2 = new Car("Honda", "Red");
            vehicle2.UserColor = "Green";
            Console.WriteLine(vehicle2.UserModel);
            Console.WriteLine(vehicle2.UserColor);
        }
    }
}