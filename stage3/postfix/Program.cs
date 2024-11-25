namespace postfix;

class Program
{
    static void Main(string[] strings)
    {
        var stack = new Stack<int>();
        while (true)
        {
            Console.WriteLine("Input: ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                break;

            if (input == "+")
            {
                // add top two numbers
                var first = stack.Pop();
                var second = stack.Pop();
                var add = first + second;
                Console.WriteLine($"Adding {first} and {second} result = {add}");
                stack.Push(add);
            }
            else if (input == "-")
            {
                // subtract two numbers
                var first = stack.Pop();
                var second = stack.Pop();
                var subtract = first - second;
                Console.WriteLine($"Subtracting {first} and {second} result = {subtract}");
                stack.Push(subtract);
            }
            else if (input == "*")
            {
                // multiply two numbers
                var first = stack.Pop();
                var second = stack.Pop();
                var multiply = first * second;
                Console.WriteLine($"Multiplying {first} and {second} result = {multiply}");
                stack.Push(multiply);
            }
            else if (input == "/")
            {
                // divide two numbers
                var first = stack.Pop();
                var second = stack.Pop();
                var divide = first / second;
                Console.WriteLine($"Dividing {first} and {second} result = {divide}");
                stack.Push(divide);
            }
            else
            {
                // parse input and push to stack
                stack.Push(int.Parse(input));
            }
        }
        Console.WriteLine($"Stack: {stack.Pop()}");
        // print stack by popping each element (use a while loop)
    }
}