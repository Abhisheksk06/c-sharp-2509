using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    public abstract class Bird
    {
        //abstract method
        public abstract void Fly();
    }

    interface ISwim
    {
        void Swim();
    }

    public class Duck : Bird, ISwim
    {
        //Implementing Fly method
        public override void Fly()
        {
            Console.WriteLine("The duck is flying high");

        }
        //Implementing SWim method
        public void Swim()
        {
            Console.WriteLine("The duck is swimming");
        }
    }
}
