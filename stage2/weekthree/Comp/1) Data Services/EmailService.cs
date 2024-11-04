using Comp._2__Data_Contracts;
namespace Comp._1__Data_Services;

public class EmailService
{
    public void SendEmail(EmailDto email)
    {
        Console.WriteLine($"Sending email to: {email.To}");
        Console.WriteLine($"Subject: {email.Subject}");
        Console.WriteLine($"Body: {email.Body}");
    }
}