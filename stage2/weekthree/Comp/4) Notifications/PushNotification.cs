using Comp._2__Data_Contracts;

namespace Comp._4__Notifications;

public class PushNotification : NotificationBase
{
    public PushNotificationDto Push { get; set; }

    public PushNotification(PushNotificationDto push)
    {
        Push = push;
    }

    public void SendPush()
    {
        Console.WriteLine($"Title: {Push.Title}");
        Console.WriteLine($"Message: {Push.Message}");
    }
}