namespace Comp._2__Data_Contracts;

public class SmsDto
{
    public string To { get; set; }
    public string From { get; set; }
    public string Message { get; set; }
    public bool IsUnicode { get; set; }

    public SmsDto()
    {
        IsUnicode = true;
    }
}