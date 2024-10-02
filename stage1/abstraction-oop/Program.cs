namespace abstraction;

class Program
{
    static void Main(string[] args)
    {
        // declare variables
        string fileName = "employees.txt";
        string firstName;
        string lastName;
        double pay = 0;
        string type;

        // creating the list of employees
        List<Person> employeeList = new List<Person>();

        // prompting user for creation
        Console.Write("Please input first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please input last name: ");
        lastName = Console.ReadLine();
        Console.Write("Please input type (Hourly, Salary, Contractor, or Temp): ");
        type = Console.ReadLine().ToUpper();

        // checks the question
        if (type == "HOURLY" || type == "TEMP")
        {
            Console.Write("What is your pay Hourly?: ");
            pay = Convert.ToDouble(Console.ReadLine());
        }
        if (type == "SALARY" || type == "CONTRACTOR")
        {
            Console.Write("What is your pay Annually?: ");
            pay = Convert.ToDouble(Console.ReadLine());
        }

        // adds a new user to the text file
        if (type == "HOURLY")
        {
            employeeList.Add(new HourlyEmployee(firstName, lastName, pay, type));
        }
        else if (type == "SALARY")
        {
            employeeList.Add(new SalaryEmployee(firstName, lastName, pay, type));
        }
        else if (type == "CONTRACTOR" || type == "TEMP")
        {
            employeeList.Add(new Employee(firstName, lastName, pay, type));
        }

        // writing new information to the text file
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (Person anEmployee in employeeList)
            {
                sw.WriteLine($"{anEmployee.FirstName} : {anEmployee.LastName} : {anEmployee.Pay} : {anEmployee.Type}");
            }
        }

        // writes out the ToString()
        foreach (Person anEmployee in employeeList)
        {
            Console.WriteLine(anEmployee);
        }











        // using streamreader to load the file
        /*
        using (StreamReader sr = File.OpenText(fileName))
        {
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(':');

                string empType = parts[0].Trim();
                lastName = parts[1].Trim();
                firstName = parts[2].Trim();
                payAmt = Convert.ToDouble(parts[3].Trim());

            }
        }
        */

        /*
        // Lamda to read out which one's been added
        var foundEmployees = employeeList.Where(x => x.Type == "Hourly");


        foreach (Person anEmployee in foundEmployees)
        {
            Console.WriteLine(anEmployee);
        }
        */
    }
}