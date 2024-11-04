using Comp._1__Data_Services;
using Comp._3__Model_View_Controller;

namespace Comp;

class Program
{
    static void Main(string[] args)
    {
        EmailService emailService = new EmailService();
        PushService pushService = new PushService();
        SmsService smsService = new SmsService();
        
        NotificationModel notificationModel = new NotificationModel(emailService, pushService, smsService);
        NotificationView notificationView = new NotificationView();
        NotificationController notificationController = new NotificationController(notificationModel, notificationView);
        
        notificationController.Start();
    }
}