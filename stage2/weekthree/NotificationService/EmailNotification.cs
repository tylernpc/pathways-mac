namespace NotificationService;

public class EmailNotification : INotificationService
{
    public void Email(string typeOfNotification)
    {
        Console.WriteLine($"{typeOfNotification} is the notification type");
    }
}