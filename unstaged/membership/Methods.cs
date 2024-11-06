class Methods
{
    static void CreateUser()
    {
        Random rnd = new Random();
        int id  = rnd.Next(10000, 99999);
        Console.WriteLine(id);
    }
}