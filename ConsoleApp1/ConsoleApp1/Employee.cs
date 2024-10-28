using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Employee
    {
        private string name;
        private decimal salary;

        //public property name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public property salary
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                salary = value;
            }
        }

        //constructor
        public Employee(string employeeName, decimal initialsalary)
        {
            Name = employeeName;
            Salary = initialsalary;
        }

        // DisplayDetails()
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Salary: {Salary}");
        }

    }
}
