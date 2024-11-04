using Comp._2__Data_Contracts;

namespace Comp._3__Model_View_Controller;

public class NotificationController
{ 
    private readonly NotificationModel _notificationModel;
    private readonly NotificationView _notificationView;

    public NotificationController(NotificationModel notificationModel, NotificationView notificationView)
    {
        _notificationModel = notificationModel;
        _notificationView = notificationView;
    }
    
    public void Start()
    {
        NotificationView view = new NotificationView();

        if (view.UserChoice() == "EMAIL")
        {
            EmailDto emailData = _notificationView.GetEmailInput();
            _notificationModel.EmailData = emailData;
            _notificationModel.SendEmailNotification(); 
        } 
        else if (view.UserChoice() == "PUSH")
        {
            PushNotificationDto pushData = _notificationView.GetPushNotificationInput();
            _notificationModel.PushNotificationData = pushData;
            _notificationModel.SendPushNotification();
        }
        else if (view.UserChoice() == "SMS")
        {
            SmsDto smsData = _notificationView.GetSmsInput();
            _notificationModel.SmsData = smsData; 
            _notificationModel.SendSmsNotification(); 
        }
        
        _notificationView.DisplaySendConfirmation("Email");
        _notificationView.DisplaySendConfirmation("Push");
        _notificationView.DisplaySendConfirmation("SMS");
    }
}