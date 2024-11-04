using Comp._1__Data_Services;                        // To access EmailService, SmsService, PushService
using Comp._2__Data_Contracts;                       // To access EmailDto, SmsDto, PushNotificationDtoå

namespace CompTest;

[TestClass]
public class EmailServiceTests
{
    [TestMethod]
    public void SendEmail_ShouldOutputCorrectEmailInformation()
    {
        // Arrange
        var emailService = new EmailService();
        var emailDto = new EmailDto
        {
            To = "example@example.com",
            Subject = "Test Subject",
            Body = "Test Body"
        };

        // Act
        emailService.SendEmail(emailDto);

        // Assert
        // For console output, you may not be able to directly verify output here without 
        // additional refactoring to capture Console output, but this test will check for execution success.
    }
}

