using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //base class
    public class Person3
    {
        //base class method
        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a person.");
        }
    }

    class Employ : Person3
    {
        public override void DisplayInfo()
        {
            // Call the base class method
            base.DisplayInfo();
            Console.WriteLine("This is an employee.");
        }
    }
}
