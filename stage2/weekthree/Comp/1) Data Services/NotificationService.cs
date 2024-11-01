namespace Comp._1__Data_Services;

public class NotificationService : INotificationService
{
    private readonly INotificationService _notificationService;

    public NotificationService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void SendAsync(NotificationBase notification)
    {
        
    }
}