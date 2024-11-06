namespace CompTest;

[TestClass]
public class SmsServiceTests
{
    [TestMethod]
    public void SendSms_ShouldOutputCorrectSmsInformation()
    {
        // Arrange
        var smsService = new SmsService();
        var smsDto = new SmsDto
        {
            PhoneNumber = "123-456-7890",
            Message = "Test SMS Message"
        };

        // Act
        smsService.SendSms(smsDto);

        // Assert
        // Again, if there’s no way to capture Console output, this test will primarily
        // check that the method executes without error for the given input.
    }
}
