using Comp._2__Data_Contracts;
namespace Comp._1__Data_Services;

public class SmsService : INotificationService
{
    public void SendAsync(NotificationBase notification)
    {
        var sms = notification as SmsDto;
        Console.WriteLine($"To: {sms.To}");
        Console.WriteLine($"From: {sms.From}");
        Console.WriteLine($"Message: {sms.Message}");
    }
}