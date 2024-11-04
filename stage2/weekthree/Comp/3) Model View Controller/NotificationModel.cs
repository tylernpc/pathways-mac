using Comp._1__Data_Services;
using Comp._2__Data_Contracts;

namespace Comp._3__Model_View_Controller;

public class NotificationModel
{
    public EmailDto EmailData { get; set; }
    public PushNotificationDto PushNotificationData { get; set; }
    public SmsDto SmsData { get; set; }
    
    private readonly EmailService _emailService;
    private readonly PushService _pushService;
    private readonly SmsService _smsService;

    public NotificationModel(EmailService emailService, PushService pushService, SmsService smsService)
    {
        _emailService = emailService;
        _pushService = pushService;
        _smsService = smsService;
    }

    public void SendEmailNotification()
    {
        if (EmailData != null)
        {
            _emailService.SendEmail(EmailData);
        }
        else
        {
            Console.WriteLine("No email data to send.");
        }
    }

    public void SendPushNotification()
    {
        if (PushNotificationData != null)
        {
            _pushService.SendPush(PushNotificationData);
        }
        else
        {
            Console.WriteLine("No push data to send.");
        }
    }

    public void SendSmsNotification()
    {
        if (SmsData != null)
        {
            _smsService.SendSms(SmsData);
        }
        else
        {
            Console.WriteLine("No sms data to send.");
        }
    }
}