using System;

class Employee
{
    // declaring base variables
    public string EmpLName { get; set; }
    public string EmpFName { get; set; }
    public string EmpType { get; set; }
    public double EmpPay { get; set; }

    // default constructor
    public Employee()
    {
        EmpLName = "";
        EmpFName = "";
        EmpType = "";
        EmpPay = 0;
    }

    // user constructor
    public Employee(string empLName, string empFName, string empType, double empPay)
    {
        this.EmpLName = empLName;
        this.EmpFName = empFName;
        this.EmpType = empType;
        this.EmpPay = empPay;
    }

    // constructor for child classes
    public Employee(string empLName, string empFName, string empType)
    {
        this.EmpLName = empLName;
        this.EmpFName = empFName;
        this.EmpType = empType;
    }

    // override method for bonus
    public virtual double CalculateBonus()
    {
        return 0;
    }

    // base override
    public override string ToString()
    {
        return $"Employee First Name: {EmpFName} / Employee Last Name: {EmpLName}";
    }
}