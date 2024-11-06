class SalaryEmployee : Employee
{
    // declaring base variables | salary
    public double SalaryPay { get; set; }

    // default constructor
    public SalaryEmployee() : base()
    {
        SalaryPay = 0;
    }

    // user constructor
    public SalaryEmployee(double salaryHourly, string empLName, string empFName) : base(empLName, empFName)
    {
        SalaryPay = salaryHourly;
    }

    // override method for bonus
    public override double CalculateBonus()
    {
        return SalaryPay * 0.10;
    }

    // override to string
    public override string ToString()
    {
        return $"{base.ToString()}Salary Base pay is: {SalaryPay} is with a bonus of {CalculateBonus():C}";
    }
}