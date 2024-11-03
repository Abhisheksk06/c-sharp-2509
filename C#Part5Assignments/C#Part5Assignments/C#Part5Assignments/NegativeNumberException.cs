using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class NegativeNumberException : Exception
    {
    }

    // class containing the CheckNumber method
    public class NumberChecker
    {
        // method to check if a number is negative and throw an exception
        public void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException();
            }
            Console.WriteLine("The number is valid.");
        }
    }
}
