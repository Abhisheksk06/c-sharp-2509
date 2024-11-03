using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //base class
    public class Employee
    {
        // static field to keep track of the total number of employees
        protected static int employeeCount = 0;

        // constructor to increment the employee count
        public Employee()
        {
            employeeCount++;
        }

        // static method to display the total number of employees
        public static void DisplayEmployeeCount()
        {
            Console.WriteLine("Total number of employees: " + employeeCount);
        }

        // virtual method to get the role of the employee
        public virtual void GetRole()
        {
            Console.WriteLine("Employee role not specified.");
        }
    }

    // Derived class: Manager
    public class Manager : Employee
    {
        // overriding the GetRole method
        public override void GetRole()
        {
            Console.WriteLine("Role: Manager");
        }
    }

    // Derived class: Developer
    public class Developer : Employee
    {
        // overriding the GetRole method
        public override void GetRole()
        {
            Console.WriteLine("Role: Developer");
        }
    }
}
