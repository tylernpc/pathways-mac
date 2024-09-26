using System;

class Hourly : Employee
{
    // declaring base variables | hourly
    public double HourlyPay { get; set; }

    // default constructor
    public Hourly() : base()
    {
        HourlyPay = 0;
    }

    // user constructor
    public Hourly(double hourlyPay, string empLName, string empFName) : base(empLName, empFName)
    {
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