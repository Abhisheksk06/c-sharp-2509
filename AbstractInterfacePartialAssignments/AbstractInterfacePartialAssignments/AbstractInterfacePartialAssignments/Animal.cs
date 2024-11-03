using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    public class Animal
    {
        //virtual method to override in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        //overriding method
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows");
        }
    }
}