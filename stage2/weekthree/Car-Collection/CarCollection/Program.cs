namespace CarCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = GetValidStringInput("Please enter a car manufacture: ");
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
                    Console.Write("Invalid Input. Please enter a valid value.");
                }
            }
        }

        public static int GetValidIntInput(int prompt)
        {
            int input;
            while (true)
            {
                Console.Write(prompt);
                input = Convert.ToInt32(Console.ReadLine());

                if (input >= 1885)
                {
                    return input;
                }
                else
                {
                    Console.Write("Invalid Input. Please enter a valid value.");
                }
            }
        }
    }
}