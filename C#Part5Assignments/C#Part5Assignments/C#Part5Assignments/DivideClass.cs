using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class DivideClass
    {
        //Method to divide two integers and return quo. and rem. using out parameter
        public void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
    }
}
