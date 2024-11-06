namespace NotificationService;

public class PushService : INotificationService
{
    public void Send(string typeOfNotification)
    {
        Console.WriteLine($"{typeOfNotification} is the notification type");
    }

    public void SendAsync(NotificationBase notification)
    {
        var pushNotification = (PushNotification)notification;
        var foo = pushNotification.Title;
    }
}