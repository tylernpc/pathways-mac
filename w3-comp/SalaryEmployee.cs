using System;

class Salary : Employee
{
    // declaring base variables | salary
    public double SalaryPay { get; set; }

    // default constructor
    public Salary() : base()
    {
        SalaryPay = 0;
    }

    // user constructor
    public Salary(double salaryHourly, string empLName, string empFName) : base(empLName, empFName)
    {
        this.SalaryPay = salaryHourly;
    }

    // override method for bounus
    public override double CalculateBonus()
    {
        return SalaryPay * 0.10;
    }

    // override to string
    public override string ToString()
    {
        return $"{base.ToString()} is Salary";
    }
}