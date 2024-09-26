using System;

class Hourly : Employee
{
    // declaring base variables | hourly
    public bool IsHourly { get; set; }
    public double HourlyPay { get; set; }

    // default constructor
    public Hourly() : base()
    {
        IsHourly = false; // might have to be false
        HourlyPay = 0;
    }

    // user constructor
    public Hourly(bool isHourly, double hourlyPay, string empLName, string empFName, string empType) : base(empLName, empFName, empType)
    {
        this.IsHourly = isHourly;
        this.HourlyPay = hourlyPay;
    }

    // override method for bonus
    public override double CalculateBonus()
    {
        return HourlyPay * 80;
    }

    // override to string
    public override string ToString()
    {
        return $"{base.ToString()} is Hourly";
    }
}