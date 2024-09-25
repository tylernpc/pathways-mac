// car oop practice

namespace CarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }

    class Car
    {
        // declaring variables
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        // default constructor
        public Car()
        {
            Brand = "";
            Model = "";
            Color = "";
            Price = 0;
        }

        // constructor for user
        public Car(string brand, string model, string color, int price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Price = price;
        }
    }
}