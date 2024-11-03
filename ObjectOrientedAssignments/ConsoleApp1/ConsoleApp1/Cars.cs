using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Cars
    {
        // static field to count the number of Car instances
        public static int carCount;

        // static constructor to initialize the counter
        static Cars()
        {
            carCount = 0; // initializing the static counter
            Console.WriteLine("Static constructor called: carCount initialized to 0");
        }

        // instance constructor that increments the car count
        public Cars()
        {
            carCount++; // increment the static field each time a new Car is created
            Console.WriteLine("A new Car object has been created. Total cars: " + carCount);
        }

        // method to display the current count of Car instances
        public static void DisplayCarCount()
        {
            Console.WriteLine("Total number of cars created: " + carCount);
        }
    }
}
