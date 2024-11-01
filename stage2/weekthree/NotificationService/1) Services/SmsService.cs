namespace NotificationService;

public class SmsService : INotificationService
{
    public void Send(string typeOfNotification)
    {
        Console.WriteLine($"{typeOfNotification} is the notification type");
    }
    
    public void SendAsync(NotificationBase notification)
    {
        var smsNotification = (SmsNotification)notification;
        var foo = smsNotification.Message;
    }
}