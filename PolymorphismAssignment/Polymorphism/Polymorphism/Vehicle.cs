using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //base class
    public class Vehicle
    {
        // virtual method that can be overridden
        public virtual void Drive()
        {
            Console.WriteLine("The vehicle is driving.");
        }
    }

    // Derived class
    public class Car2 : Vehicle
    {
        // overriding the Drive method
        public override void Drive()
        {
            Console.WriteLine("The car is driving smoothly.");
        }
    }
}
