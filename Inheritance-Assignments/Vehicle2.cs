using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //abstract class
    abstract class Vehicle2
    {
        //abstract method drive
        public abstract void Drive();
    }

    //derived class
    class Car : Vehicle2
    {
        //Implementing abstract method
        public override void Drive()
        {
            Console.WriteLine("The car is driving by me");
        }
    }

    //derived class
    class  Bike : Vehicle2
    {
        //Implementing abstract method
        public override void Drive()
        {
            Console.WriteLine("The bike is riding by me");
        }
    }
}
