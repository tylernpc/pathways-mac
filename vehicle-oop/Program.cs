﻿// vehicle oop practice

namespace CarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vehicle vehicle = new Vehicle("Mercedes", "C300", "Silver", 20000);
            // Console.WriteLine(vehicle);

            Motorcycle motorcycle = new Motorcycle(true, "Ducati", "Panigale V4s", "Red", 30000);
            Console.WriteLine(motorcycle);

            Car car = new Car(true, "Mercedes", "C300", "Silver", 20000);
            Console.WriteLine(car);
        }
    }

    class Vehicle
    {
        // declaring variables
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        // default constructor
        public Vehicle()
        {
            Brand = "";
            Model = "";
            Color = "";
            Price = 0;
        }

        // constructor for user
        public Vehicle(string brand, string model, string color, int price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Price = price;
        }

        // basic override string
        public override string ToString()
        {
            return $"Brand: {Brand} | Model: {Model} | Color: {Color} | Price: {Price}";
        }
    }

    class Motorcycle : Vehicle
    {
        // declaring variables
        public bool IsMotorcycle { get; set; }

        // default constructor
        public Motorcycle():base()
        {
            IsMotorcycle = true;
        }

        // constructor for user
        public Motorcycle (bool motorcycle, string brand, string model, string color, int price):base(brand, model, color, price)
        {
            this.IsMotorcycle = motorcycle;
        }

        // basic override string
        public override string ToString()
        {
            return $"Is it a Motorcycle: {IsMotorcycle} | Brand: {Brand} | Model: {Model} | Color: {Color} | Price: {Price}";
        }
    }

    class Car : Vehicle
    {
        // declaring variables
        public bool IsCar { get; set; }

        // default constructor
        public Car():base()
        {
            IsCar = true;
        }

        // constructor for user
        public Car (bool car, string brand, string model, string color, int price):base(brand, model, color, price)
        {
            this.IsCar = car;
        }

        // basic override string
        public override string ToString()
        {
            return $"Is it a Car: {IsCar} | Brand: {Brand} | Model: {Model} | Color: {Color} | Price: {Price}";
        }
    }
}