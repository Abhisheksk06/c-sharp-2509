using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Vehicle3
    {
        // property to store the brand of the vehicle
        public string Brand { get; set; }

        // Constructor that accepts a brand
        public Vehicle3(string brand)
        {
            Brand = brand;
            Console.WriteLine("Vehicle brand: " + Brand);
        }
    }

    class Caar : Vehicle3
    {
        // constructor that accepts a brand and passes it to the base class constructor
        public Caar(string brand) : base(brand)
        {
            Console.WriteLine("Car created with brand: " + Brand);
        }
    }
}
