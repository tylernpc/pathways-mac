namespace CarCollection
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public double Price { get; set; }

        public Car()
        {
            Make = "";
            Model = "";
            Year = 1885;
            Color = "";
            Mileage = 0;
            Transmission = "";
            Price = 0;
        }

        public Car(
            string make,
            string model,
            int year,
            string color,
            int mileage,
            string transmission,
            double price
            )
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
            Transmission = transmission;
            Price = price;
        }

        public override string ToString()
        {
            return $"Car Details:\n" +
                   $"Make: {Make}\n" +
                   $"Model: {Model}\n" +
                   $"Year: {Year}\n" +
                   $"Color: {Color}\n" +
                   $"Mileage: {Mileage} miles\n" +
                   $"Transmission: {Transmission}\n" +
                   $"Price: ${Price:F2}";
        }

    }
}
