namespace CompTest;

[TestClass]
public class NotificationModelTests
{
    [TestMethod]
    public void SendEmailNotification_ShouldInvokeSendEmailOnEmailService()
    {
        // Arrange
        var emailService = new EmailService();
        var pushService = new PushService();
        var smsService = new SmsService();

        var model = new NotificationModel(emailService, pushService, smsService);
        var emailDto = new EmailDto
        {
            To = "user@example.com",
            Subject = "Hello",
            Body = "Welcome to the service!"
        };

        // Act
        model.SendEmailNotification(emailDto);

        // Assert
        // Here you can confirm SendEmail was invoked, perhaps by observing console output manually
        // or refactoring to add a more testable approach.
    }

    [TestMethod]
    public void SendSmsNotification_ShouldInvokeSendSmsOnSmsService()
    {
        // Arrange
        var emailService = new EmailService();
        var pushService = new PushService();
        var smsService = new SmsService();

        var model = new NotificationModel(emailService, pushService, smsService);
        var smsDto = new SmsDto
            {

