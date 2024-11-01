namespace NotificationService;

public class NotificationView
{
    public string UserInput()
    {
        Console.WriteLine("NOTIFICATION TYPES");
        Console.WriteLine("Email | SMS | Push");
        Console.Write("What type of email would you like to send? ");
        string userInput = Console.ReadLine().ToUpper();
        return userInput;
    }
}