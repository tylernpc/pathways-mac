using Comp._2__Data_Contracts;

namespace Comp._4__Notifications;

public class SmsNotification :  NotificationBase
{
    public SmsDto Sms { get; set; }

    public SmsNotification(SmsDto sms)
    {
        Sms = sms;
    }

    public void SendSms()
    {
        Console.WriteLine($"To: {Sms.To}");
        Console.WriteLine($"From: {Sms.From}");
        Console.WriteLine($"Message: {Sms.Message}");
    }
}