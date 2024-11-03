using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //base class
    public class AddNumbers
    {
        // Early Binding: Method Overloading
        // overloaded Add method with different parameter types
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Late Binding: Method Overriding
        // virtual method that can be overridden by derived classes
        public virtual void DisplayOperation()
        {
            Console.WriteLine("Performing a calculation.");
        }
    }
    // Derived class for addition
    public class Addition : AddNumbers
    {
        // Overriding DisplayOperation method to demonstrate late binding
        public override void DisplayOperation()
        {
            Console.WriteLine("Performing addition operation.");
        }
    }
    // Derived class for multiplication
    public class Multiplication : AddNumbers
    {
        // Overriding DisplayOperation method to demonstrate late binding
        public override void DisplayOperation()
        {
            Console.WriteLine("Performing multiplication operation.");
        }
    }


}
