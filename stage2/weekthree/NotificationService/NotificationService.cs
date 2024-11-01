namespace NotificationService;

public class NotificationService : INotificationService
{
    private readonly INotificationService _notificationService;
    public NotificationService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    
    public void Email(string typeOfNotification)
    {
        _notificationService.Email(typeOfNotification);
    }
}