using Comp._2__Data_Contracts;
namespace Comp._1__Data_Services;

public class PushServices
{
    public PushNotificationDto Push { get; set; }

    public PushServices(PushNotificationDto push)
    {
        Push = push;
    }

    public void SendPush()
    {
        Console.WriteLine($"Title: {Push.Title}");
        Console.WriteLine($"Message: {Push.Message}");
    }
}