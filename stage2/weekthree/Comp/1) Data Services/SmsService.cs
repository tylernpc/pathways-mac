using Comp._2__Data_Contracts;
namespace Comp._1__Data_Services;

public class SmsService : NotificationBase
{
    public SmsDto Sms { get; set; }

    public SmsService(SmsDto sms)
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