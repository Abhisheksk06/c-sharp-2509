using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    public abstract class Vehicle
    {
        //abstract method
        public abstract void StartEngine();

        //concrete method
        public void StopEngine()
        {
            Console.WriteLine("The engine is stopped");
        }
    }

    public class Car : Vehicle
    {
        //Implementing abstarct method
        public override void StartEngine()
        {
            Console.WriteLine("The car engine is starting");
        }
    }

    public class Motorcycle : Vehicle
    {
        //Implementing abstarct methd
        public override void StartEngine()
        {
            Console.WriteLine("The motorcycle engine is starting");
        }
    }
}
