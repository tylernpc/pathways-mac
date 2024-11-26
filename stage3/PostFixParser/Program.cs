namespace PostFixParser;

class Program
{
    static void Main(string[] strings)
    {

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