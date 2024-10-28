using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //Interface1
    interface IPrintable
    {
        void Print();
    }

    //Interface2
    interface IScannable
    {
        void Scan();
    }

    //PrinterScanner class implementing both interfaces
    public class PrinterScanner : IPrintable, IScannable
    {
        //Implementing Print method from Iprintable interface
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        //Implementing Scan method from Iscannable interface
        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }
    }


}
