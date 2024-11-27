namespace PostFixParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var parserService = new ParserService();
            Console.Write("Enter a postfix expression: ");
            var input = Console.ReadLine();

            try
            {
                var nodes = parserService.Parse(input);
                Console.WriteLine("Parsed Nodes: ");
                foreach (var node in nodes)
                {
                    if (node.IsNumber)
                    {
                        Console.WriteLine($"Number: {node.Number}");
                    }
                    else
                    {
                        Console.WriteLine($"Operator: {node.Operator}");
                    }
                }

                var result = Evaluate(nodes);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing input: {ex.Message}");
            }
        }

        static int Evaluate(List<Node> nodes)
        {
            var stack = new Stack<int>();

            foreach (var node in nodes)
            {
                if (node.IsNumber)
                {
                    stack.Push(node.Number);
                }
                else
                {
                    var y = stack.Pop();
                    var x = stack.Pop();
                    var result = 0;

                    switch (node.Operator)
                    {
                        case Operator.Add:
                            result = x + y;
                            break;
                        case Operator.Subtract:
                            result = x - y;
                            break;
                        case Operator.Multiply:
                            result = x * y;
                            break;
                        case Operator.Divide:
                            result = x / y;
                            break;
                    }

                    stack.Push(result);
                }
            }

            return stack.Pop();
        }

        enum Operator
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        struct Node
        {
            public Node(string input)
            {
                IsNumber = int.TryParse(input, out var number);
                Number = IsNumber ? number : 0;
                Operator = IsNumber ? 0 : input switch
                {
                    "+" => Operator.Add,
                    "-" => Operator.Subtract,
                    "*" => Operator.Multiply,
                    "/" => Operator.Divide,
                    _ => throw new ArgumentException("Invalid operator or number")
                };
            }

            public bool IsNumber { get; }
            public int Number { get; }
            public Operator Operator { get; }
        }

        class ParserService
        {
            public List<Node> Parse(string input)
            {
                var nodes = new List<Node>();
                var split = input.Split(' ');
                foreach (var item in split)
                {
                    nodes.Add(new Node(item));
                }
                return nodes;
            }
        }
    }
}