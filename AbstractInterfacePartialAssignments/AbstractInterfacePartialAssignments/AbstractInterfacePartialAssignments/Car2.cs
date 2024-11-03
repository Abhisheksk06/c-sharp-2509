using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    //interface
    public interface IDrive
    {
        //method
        void Drive();
    }

    public class Car2 : IDrive
    {
        //Impementing Drive method
        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }

    }

    public class Truck : IDrive
    {
        //Implementing Drive method
        public void Drive()
        {
            Console.WriteLine("The truck is driving");
        }
    }
}
