using Comp._2__Data_Contracts;
namespace Comp._1__Data_Services;

public class PushService
{
    public void SendPush(PushNotificationDto push)
    {
        Console.WriteLine($"Title: {push.Title}");
        Console.WriteLine($"Message: {push.Message}");
    }
}