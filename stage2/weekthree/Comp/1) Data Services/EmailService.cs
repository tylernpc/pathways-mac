using Comp._2__Data_Contracts;
namespace Comp._1__Data_Services;

public class EmailService : INotificationService
{
    public void SendAsync(NotificationBase notification)
    {
        var email = notification as EmailDto;
        Console.WriteLine($"Sending email to: {email.To}");
        Console.WriteLine($"Subject: {email.Subject}");
        Console.WriteLine($"Body: {email.Body}");
    }
}