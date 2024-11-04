using Comp._2__Data_Contracts;
namespace Comp._3__Model_View_Controller;

public class NotificationView
{
    public EmailDto GetEmailInput()
    {
        Console.WriteLine("Enter email notification details:");
        Console.Write("To: ");
        string to = Console.ReadLine();
        Console.Write("Subject: ");
        string subject = Console.ReadLine();
        Console.Write("Body: ");
        string body = Console.ReadLine();

        return new EmailDto
        {
            To = to,
            Subject = subject,
            Body = body
        };
    }

    public PushNotificationDto GetPushNotificationInput()
    {
        Console.WriteLine("Enter push notification details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Message: ");
        string message = Console.ReadLine();

        return new PushNotificationDto
        {
            Title = title,
            Message = message
        };
    }

    public SmsDto GetSmsInput()
    {
        Console.WriteLine("Enter SMS notification details:");
        Console.Write("To: ");
        string to = Console.ReadLine();
        Console.Write("From: ");
        string from = Console.ReadLine();
        Console.Write("Message: ");
        string message = Console.ReadLine();

        return new SmsDto
        {
            To = to,
            From = from,
            Message = message
        };
    }
    
    public void DisplaySendConfirmation(string notificationType)
    {
        Console.WriteLine($"{notificationType} notification sent successfully.");
    }
}