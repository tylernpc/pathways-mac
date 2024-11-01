namespace Comp._2__Data_Contracts;

public class PushNotificationDto
{
    public string Title { get; set; }
    public string Message { get; set; }
    public Dictionary<string, string> Data { get; set; }

    public PushNotificationDto()
    {
        Data = new Dictionary<string, string>();
    }
}