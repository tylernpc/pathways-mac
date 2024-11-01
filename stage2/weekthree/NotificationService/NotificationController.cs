namespace NotificationService;

public class NotificationController
{
    NotificationModel model = new NotificationModel();
    NotificationView view = new NotificationView();

    public void Start()
    {
        model.NotificationValidation(view.UserInput());
    }
}