namespace CarCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = GetValidStringInput("Please enter a car manufacture: ");
            car.Model = GetValidStringInput("Please enter a car model: ");
            car.Year = GetValidIntInput("Please enter a car year: ");
            car.Color = GetValidStringInput("Please enter a car color: ");
            car.Mileage = GetValidIntInput("Please enter the car mileage: ");
            car.Transmission = GetValidStringInput("Please enter a transmission type: ");
            car.Price = GetValidDoubleInput("Please enter the vehicle's price: ");
        }

        public static string GetValidStringInput(string prompt)
        {
            string input;
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                else
                {
                    Console.Write("Invalid Input. Please enter a valid string. ");
                }
            }
        }

        public static int GetValidIntInput(string prompt)
        {
            int input;
            while (true)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out input))
                {
                    return input;
                }
                else
                {
                    Console.Write("Invalid Input. Please enter a valid int. ");
                }
            }
        }

        public static double GetValidDoubleInput(string prompt)
        {
            double input;
            while (true)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();

                if (double.TryParse(userInput, out input))
                {
                    return input;
                }
                else
                {
                    Console.Write("Invalid Input. Please enter a valid double. ");
                }
            }
        }
    }
}