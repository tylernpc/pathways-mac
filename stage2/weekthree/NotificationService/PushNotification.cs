namespace NotificationService;

public class PushNotification : INotificationService
{
    public void Email(string typeOfNotification)
    {
        Console.WriteLine($"{typeOfNotification} is the notification type");
    }
}