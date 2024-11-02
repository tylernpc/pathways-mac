using Comp._2__Data_Contracts;
namespace Comp._1__Data_Services;

public class EmailService
{
    public EmailDto Email { get; set; }

    public EmailService(EmailDto email)
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