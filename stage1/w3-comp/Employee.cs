class Employee
{
    // don't abbreviate unless there's a good reason
    // no need to repeat yourself
    // alphabetize everything, properties, methods
    // more complex constructors at the bottom
    // declaring base variables
    public string Type {get; set;}
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