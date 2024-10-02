namespace interfaceOOP;

class Program
{
    static void Main(string[] args)
    {
        IVehicle myCar = new Car { TopSpeed = 200, Price = 120000 };
        myCar.DisplayInfo();
    }
}