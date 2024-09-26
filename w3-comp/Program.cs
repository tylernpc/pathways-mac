// main program
using System;
using System.Reflection.Metadata.Ecma335;

namespace w3Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Le", "Tyler", "FullTime");
            Console.WriteLine(emp);
        }
    }

    class Employee
    {
        // declaring base variables
        public string EmpLName { get; set; }
        public string EmpFName { get; set; }
        public string EmpType { get; set; }

        // default constructor
        public Employee()
        {
            EmpLName = "";
            EmpFName = "";
            EmpType = "";
        }

        // user constructor
        public Employee(string empLName, string empFName, string empType)
        {
            this.EmpLName = empLName;
            this.EmpFName = empFName;
            this.EmpType = empType;
        }

        // base override
        public override string ToString()
        {
            return $"Employee First Name: {EmpFName} / Employee Last Name: {EmpLName} / Employee Type: {EmpType}";
        }
    }
}