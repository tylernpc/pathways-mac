using System;

class Salary : Employee
{
    // declaring base variables | salary
    public bool IsSalary { get; set; }
    public double SalaryPay { get; set; }

    // default constructor
    public Salary() : base()
    {
        IsSalary = false; // might have to be false
        SalaryPay = 0;
    }

    // user constructor
    public Salary(bool isSalary, double salaryHourly, string empLName, string empFName, string empType) : base(empLName, empFName, empType)
    {
        this.IsSalary = isSalary;
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