namespace PostFixParser;

class Program
{
    static void Main(string[] strings)
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
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing input: {ex.Message}");
        }
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
        // public bool IsNumber { get; private set; }
        // public int Number { get; private set; }
        // public Operator? Operator { get; private set; }

        public Node(string input)
        {
            if (input == "+")
            {
                Operator = Operator.Add;
            }
            else if (input == "-")
            {
                Operator = Operator.Subtract;
            }
            else if (input == "*")
            {
                Operator = Operator.Multiply;
            }
            else if (input == "/")
            {
                Operator = Operator.Divide;
            }
            else
            {
                IsNumber = true;
                Number = int.Parse(input);
            }
        }

        public bool IsNumber { get; private set; }
        public int Number { get; private set; }
        public Operator Operator { get; set; }

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