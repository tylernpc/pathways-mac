using Comp._2__Data_Contracts;

namespace Comp._4__Notifications;

public class EmailNotification : NotificationBase
{
    public EmailDto Email { get; set; }

    public EmailNotification(EmailDto email)
    {
        Email = email;
    }

    public void SendEmail()
    {
        Console.WriteLine($"Sending email to: {Email.To}");
        Console.WriteLine($"Subject: {Email.Subject}");
        Console.WriteLine($"Body: {Email.Body}");
    }
}