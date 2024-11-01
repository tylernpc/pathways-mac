namespace NotificationService;

public class SmsNotification : INotificationService
{
    public void Email(string typeOfNotification)
    {
        Console.WriteLine($"{typeOfNotification} is the notification type");
    }
}