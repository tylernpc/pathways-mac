// main program
using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace w3Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee tylerSalary = new Employee("Le", "Tyler", "Salary", 50000);
            Console.WriteLine(tylerSalary);
        }
    }

    class Employee
    {
        // declaring base variables
        public string EmpLName { get; set; }
        public string EmpFName { get; set; }
        public string EmpType { get; set; }
        public int EmpPay { get; set; }

        // default constructor
        public Employee()
        {
            EmpLName = "";
            EmpFName = "";
            EmpType = "";
            EmpPay = 0; 
        }

        // user constructor
        public Employee(string empLName, string empFName, string empType, int empPay)
        {
            this.EmpLName = empLName;
            this.EmpFName = empFName;
            this.EmpType = empType;
            this.EmpPay = empPay;
        }

        // override method for bonus
        public virtual int CalculateBonus()
        {
            return 0;
        }

        // base override
        public override string ToString()
        {
            return $"Employee First Name: {EmpFName} / Employee Last Name: {EmpLName} / Employee Type: {EmpType} / Salary: {EmpPay}";
        }
    }

    class Hourly : Employee
    {
        // declaring base variables | hourly
        public bool IsHourly { get; set; }

        // default constructor
        public Hourly():base()
        {
            IsHourly = true; // might have to be false
        }

        // user constructor
        public Hourly(bool isHourly, string empLName, string empFName, string empType, int empPay):base(empLName, empFName, empType, empPay)
        {
            this.IsHourly = isHourly;
        }

        // override method for bonus
        public override int CalculateBonus()
        {
            return 0; // calculate bonus
        }

        // override to string
        public override string ToString()
        {
            return $"{base.ToString()} Is Hourly";
        }
    }

    class Salary : Employee
    {
        // declaring base variables | salary
        public bool IsSalary { get; set; }

        // default constructor
        public Salary():base()
        {
            IsSalary = true; // might have to be false
        }

        // user constructor
        public Salary(bool isSalary, string empLName, string empFName, string empType, int empPay):base()
        {
            this.IsSalary = isSalary;
        }

        // override method for bounus
        public override int CalculateBonus()
        {
            return 0; // calculate bonus
        }

        // override to string
        public override string ToString()
        {
            return $"{base.ToString()} Is Salary";
        }
    }
}