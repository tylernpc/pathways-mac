using Comp._1__Data_Services;
using Comp._2__Data_Contracts;

namespace CompTest
{
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

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            emailService.SendAsync(emailDto);

            // Assert
            var expectedOutput = $"Sending email to: {emailDto.To}\r\n" +
                                 $"Subject: {emailDto.Subject}\r\n" +
                                 $"Body: {emailDto.Body}\r\n";

            Assert.AreEqual(expectedOutput.Trim(), consoleOutput.ToString().Trim());

            Console.SetOut(Console.Out);
        }
    }
}