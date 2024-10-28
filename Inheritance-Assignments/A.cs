using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //base interfaceA
    interface InterfaceA
    {
        void Method1();
        void Method2();
    }

    //derived interface
    interface InterfaceB : InterfaceA
    {
        void Method3();
    }

    //Implementing InterfaceB in Class A
    public class A : InterfaceB
    {
        //Implementing Method1 from InterfaceA
        public void Method1()
        {
            Console.WriteLine("Method1 is invoked");
        }

        //Implementing Method2 from InterfaceA
        public void Method2()
        {
            Console.WriteLine("Method2 is invoked");

        }

        //Implementing Method3 from InterfaceB
        public void Method3()
        {
            Console.WriteLine("Method3 is invoked");
        }

    }
}
