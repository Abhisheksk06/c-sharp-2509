using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    public partial class EmployeePart1
    {
        //properties
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }


        //partial method definition
        partial void CalculateSalary();

        //method to display salary info
        public void ShowSalary()
        {
            //Calling partial method
            CalculateSalary();
        }
            
    }
}
