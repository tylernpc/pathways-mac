namespace Comp._1__Data_Services;

public interface INotificationService
{
    public void SendAsync(NotificationBase notification);
}