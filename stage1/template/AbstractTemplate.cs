public abstract class Template
{
    public string Template { get; set; }
    public int Template { get; set; }
    public double Template { get; set; }

    public Template()
    {
        Template = "";
        Template = 0;
        Template = 0;
    }

    public Template (string template, int template, double template)
    {
        Template = template
    }

    public override string ToString()
    {
        return base.ToString();
    }
}