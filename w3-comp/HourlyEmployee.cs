class HourlyEmployee : Employee
{
    // declaring base variables | hourly
    public double HourlyPay { get; set; }

    // default constructor
    public HourlyEmployee() : base()
    {
        HourlyPay = 0;
    }

    // user constructor
    public HourlyEmployee(double hourlyPay, string empLName, string empFName) : base(empLName, empFName)
    {
        HourlyPay = hourlyPay;
    }

    // override method for bonus
    public override double CalculateBonus()
    {
        return HourlyPay * 80;
    }

    // override to string
    public override string ToString()
    {
        return $"{base.ToString()} is Salary with a bonus of {CalculateBonus():C}";
    }
}