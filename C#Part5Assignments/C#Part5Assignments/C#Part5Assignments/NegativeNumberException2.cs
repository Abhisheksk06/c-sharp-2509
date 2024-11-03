using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class NegativeNumberException2 : Exception
    {
        // Constructor for NegativeNumberException
        public NegativeNumberException2()
        {
            Console.WriteLine("Number cannot be negative.");
        }

        //public NegativeNumberException2(string message) : base(message) { }
    }

    // class to demonstrate the use of the custom exception
    public class NumberProcessor
    {
        // method that throws NegativeNumberException if a negative number is passed
        public void ProcessNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException2();
            }
            Console.WriteLine($"Positive number: {number}");
        }
    }
}
