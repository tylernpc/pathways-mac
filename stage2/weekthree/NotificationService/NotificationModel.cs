namespace NotificationService;

public class NotificationModel
{
    public bool NotificationValidation(string typeOfNotification)
    {
        if (typeOfNotification == "EMAIL")
        {
            return true;
        } 
        else if (typeOfNotification == "SMS")
        {
            return true;
        } 
        else if (typeOfNotification == "PUSH")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}