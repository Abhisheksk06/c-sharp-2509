using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //base class
    public class Employee
    {
        //virtual method
        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }

    }

    //derived class
    public class Manager : Employee
    {
        //overriding work method
        public override void Work()
        {
            Console.WriteLine("Manager is managing the work");
        }
    }
}
