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
                Console.WriteLine("Adding " + first + " and " + second + " result = " + add);
                stack.Push(add);
            }
            else
            {
                // parse input and push to stack
                stack.Push(int.Parse(input));
            }
        }
        Console.WriteLine("Stack: ");
        // print stack by popping each element (use a while loop)
    }
}