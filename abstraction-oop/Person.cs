abstract class Person
{
    // declaring variables
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Pay { get; set; }
    public string Type { get; set; }

    // default constructor
    public Person()
    {
        FirstName = "";
        LastName = "";
        Pay = 0;
        Type = "";
    }

    // user constructor
    public Person(string firstName, string lastName, double pay, string type)
    {
        FirstName = firstName;
        LastName = lastName;
        Pay = pay;
        Type = type;
    }

    // override for bonus
    public abstract double CalculateBonus();

    // override ToString()
    public override string ToString()
    {
        return $"First Name - {FirstName}, Last Name - {LastName}, Pay - {Pay}, Type - {Type}";
    }
}

// Employee class for Contractors and Temps
class Employee : Person
{
    // default constructor
    public Employee() : base ()
    {

    }

    // user constructor
    public Employee(string firstName, string lastName, double pay, string type) : base (firstName, lastName, pay, type)
    {

    }

    // bonus calculation / override
    public override double CalculateBonus()
    {
        return 0;
    }

    // override ToString()
    public override string ToString()
    {
        return $"{base.ToString()}, with a bonus of {CalculateBonus}";
    }
}

// Hourly employee class
class HourlyEmployee : Person
{
    // default constructor
    public HourlyEmployee() : base ()
    {

    }

    // user constructor
    public HourlyEmployee(string firstName, string lastName, double pay, string type) : base (firstName, lastName, pay, type)
    {

    }

    // bonus calculation / override
    public override double CalculateBonus()
    {
        return Pay * 80;
    }

    // override ToString()
    public override string ToString()
    {
        return $"{base.ToString()}, with a bonus of {CalculateBonus}";
    }
}

// Salary employee class
class SalaryEmployee : Person
{
    // default constructor
    public SalaryEmployee() : base ()
    {

    }

    // user constructor
    public SalaryEmployee(string firstName, string lastName, double pay, string type) : base (firstName, lastName, pay, type)
    {

    }

    // bonus calculation / override
    public override double CalculateBonus()
    {
        return Pay * 0.10;
    }

    // override ToString()
    public override string ToString()
    {
        return $"{base.ToString()}, with a bonus of {CalculateBonus}";
    }
}