namespace NotificationService;

class Program
{
    static void Main(string[] args)
    {
        NotificationController main = new NotificationController();
        main.Start();
    }
}