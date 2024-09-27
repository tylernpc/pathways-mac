using System;

class Employee
{
    // declaring base variables
    public string EmpType {get; set;}
    public string EmpLName { get; set; }
    public string EmpFName { get; set; }
    public double EmpPay { get; set; }

    // default constructor
    public Employee()
    {
        EmpType = "";
        EmpLName = "";
        EmpFName = "";
        EmpPay = 0;
    }

    // user constructor if not salary or hourly
    public Employee(string empType, string empLName, string empFName, double empPay)
    {
        this.EmpType = empType;
        this.EmpLName = empLName;
        this.EmpFName = empFName;
        this.EmpPay = empPay;
    }

    // constructor for child classes
    public Employee(string empLName, string empFName)
    {
        this.EmpLName = empLName;
        this.EmpFName = empFName;
    }

    // override method for bonus
    public virtual double CalculateBonus()
    {
        return 0;
    }

    // base override
    public override string ToString()
    {
        return $"First Name: {EmpFName} | Last Name: {EmpLName} | Is a: {EmpType}";
    }
}