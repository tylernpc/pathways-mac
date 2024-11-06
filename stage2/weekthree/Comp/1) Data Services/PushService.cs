using Comp._2__Data_Contracts;
namespace Comp._1__Data_Services;

public class PushService : INotificationService
{
    public void SendAsync(NotificationBase notification)
    {
        var push = notification as PushNotificationDto;
        Console.WriteLine($"Title: {push.Title}");
        Console.WriteLine($"Message: {push.Message}");
    }
}