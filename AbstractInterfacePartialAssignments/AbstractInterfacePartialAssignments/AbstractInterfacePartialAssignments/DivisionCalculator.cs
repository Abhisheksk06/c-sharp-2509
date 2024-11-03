using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    public class DivisionCalculator
    {
        // method to perform division and throw an exception if division by zero
        public int Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return numerator / denominator;
        }
    }
}
