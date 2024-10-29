namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = false;

            do
            {
                Calculator calculator = new Calculator();

                Console.Write("Please enter a number: ");
                calculator.FirstNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter another number: ");
                calculator.SecondNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter a(n) operation ( A - Addition / S - Subtraction / M - Multiply / D - Divide ): ");
                string result = Console.ReadLine().ToUpper();
                Console.WriteLine(calculator.Operation(result));

                Console.Write("Would you like to continue? (Y/N): ");
                string userContinueChoice = Console.ReadLine().ToUpper();
                if (userContinueChoice == "Y")
                {
                    userContinue = true;
                }

            } while (!userContinue);
        }
    }
}