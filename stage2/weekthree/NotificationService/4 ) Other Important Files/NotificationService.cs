namespace NotificationService;

public class NotificationService : INotificationService
{
    private readonly INotificationService _notificationService;
    public NotificationService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    
    public void Send(string typeOfNotification)
    {
        _notificationService.Send(typeOfNotification);
    }

    public void SendAsync(NotificationBase notification)
    {
        _notificationService.Send("");
    }
}