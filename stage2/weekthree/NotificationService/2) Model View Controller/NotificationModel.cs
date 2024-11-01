namespace NotificationService;

public class NotificationModel
{
    public INotificationService NotificationService;

    public NotificationModel(INotificationService notificationService)
    {
        NotificationService = notificationService;
    }
    
    public bool NotificationValidation(string typeOfNotification)
    {
        if (typeOfNotification == "EMAIL")
        {
            INotificationService service = new EmailService();
            service.Send(typeOfNotification);
            var notification = new EmailNotification();
            service.SendAsync(notification);
            return true;
        } 
        else if (typeOfNotification == "SMS")
        {
            INotificationService service = new SmsService();
            service.Send(typeOfNotification);
            return true;
        } 
        else if (typeOfNotification == "PUSH")
        {
            INotificationService service = new PushService();
            service.Send(typeOfNotification);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Send(NotificationBase notification)
    {
        NotificationService.SendAsync(notification);
    }
}


