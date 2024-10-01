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
        Console.Write("Please input first name: ");
        lastName = Console.ReadLine();
        Console.Write("Please input pay (hourly or salaried amount): ");
        pay = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input type (hourly, salary, contractor, or temp): ");
        type = Console.ReadLine().ToUpper();



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