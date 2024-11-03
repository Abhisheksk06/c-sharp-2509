using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    public partial class EmployeePart1
    {
        public decimal totalSalary;

        //Implementation of partial method
        partial void CalculateSalary()
        {
            totalSalary = BaseSalary + Bonus;
            Console.WriteLine($"Total Salary for {Name}: {totalSalary}");
        }
    }
}
