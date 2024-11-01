namespace NotificationService;

public interface INotificationService
{
    public void Send(string typeOfNotification);
    public void SendAsync(NotificationBase notification);
}