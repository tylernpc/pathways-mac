interface IVehicle
{
    // declaring variables
    int TopSpeed { get; set; }
    double Price { get; set; }


    // way to display the information
    void DisplayInfo();
}

class Car : IVehicle
{
    public int TopSpeed { get; set; }
    public double Price { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Top Speed {TopSpeed}, Price {Price}");
    }
}