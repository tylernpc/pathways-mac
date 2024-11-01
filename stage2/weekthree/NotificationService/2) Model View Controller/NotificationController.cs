namespace NotificationService;

public class NotificationController
{
    private NotificationModel model;
    NotificationView view = new NotificationView();

    public void Start()
    {
        model.NotificationValidation(view.UserInput());
        var notificationString = view.UserInput();
        INotificationService notificationType = notificationString switch
        {
            "EMAIL" => new EmailService(),
            // "SMS" => new SmsNotification(),
            // "PUSH" => new PushNotification(),
            _ => null
        };
        model = new NotificationModel(notificationType);
        model.Send(new EmailNotification());
    }
}