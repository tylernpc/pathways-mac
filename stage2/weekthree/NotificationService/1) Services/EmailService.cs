namespace NotificationService;

public class EmailService : INotificationService
{
    public void Send(string typeOfNotification)
    {
        Console.WriteLine($"{typeOfNotification} is the notification type");
    }

    public void SendAsync(NotificationBase notification)
    {
        var emailNotification = (EmailNotification)notification;
        var foo = emailNotification.Subject;
    }
}