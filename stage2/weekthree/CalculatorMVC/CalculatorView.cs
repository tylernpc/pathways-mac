namespace CalculatorMVC
{
    public class CalculatorView
    {
        public (double firstNum, double secondNum, string userOperation) UserPrompt()
        {
            Console.Write("Please enter a number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter another number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("What operation would you like to do: ");
            string userOperation = Console.ReadLine().ToUpper();

            return (firstNum, secondNum, userOperation);
        }
    }
}
