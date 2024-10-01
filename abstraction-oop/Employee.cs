class Employee
{
    // don't abbreviate unless there's a good reason
    // no need to repeat yourself
    // alphabetize everything, properties, methods
    // more complex constructors at the bottom
    // declaring base variables
    public string Type { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public double Pay { get; set; }

    // default constructor
    public Employee()
    {
        Type = "";
        LastName = "";
        FirstName = "";
        Pay = 0;
    }

    // user constructor if not salary or hourly
    public Employee(string type, string lastName, string firstName, double pay)
    {
        Type = type;
        LastName = lastName;
        FirstName = firstName;
        Pay = pay;
    }

    // constructor for main class
    public Employee(double pay, string lastName, string firstName)
    {
        Pay = pay;
        LastName = lastName;
        FirstName = firstName;
    }

    // constructor for child classes
    public Employee(string empLName, string empFName)
    {
        LastName = empLName;
        FirstName = empFName;
    }

    // override method for bonus
    public virtual double CalculateBonus()
    {
        return 0;
    }

    // base override
    public override string ToString()
    {
        return $"First Name: {FirstName}, Last Name: {LastName}, Pay Type: {Type}";
    }
}

// Hourly Employee Class
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
        return $"{base.ToString()}Hourly Base pay is: {HourlyPay} with a bonus of {CalculateBonus():C}";
    }
}

// Salary Employee Class
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