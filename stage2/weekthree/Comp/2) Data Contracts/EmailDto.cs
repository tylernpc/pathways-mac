namespace Comp._2__Data_Contracts;

public class EmailDto
{
    public string To { get; set; }
    public string From { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public List<string> Cc { get; set; }
    public List<string> Bcc { get; set; }
    public List<string> Attachments { get; set; }

    public EmailDto()
    {
        Cc = new List<string>();
        Bcc = new List<string>();
        Attachments = new List<string>();
    }
}