using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class MathOpertations
    {
        // static field to hold the value of Pi
        public static double Pi;

        // static constructor to initialize the value of Pi
        static MathOpertations()
        {
            Pi = 3.14159; 
            Console.WriteLine("Static constructor called: Pi initialized to " + Pi);
        }

        // method to display the value of Pi
        public static void DisplayPi()
        {
            Console.WriteLine("The value of Pi is: " + Pi);
        }
    }
}
