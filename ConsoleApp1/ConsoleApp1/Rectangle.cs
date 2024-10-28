using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Rectangle
    {
        public double CalculateArea(double length, double breadth)
        {
            return length * breadth;
        }

        public double CalculateArea(double side)
        {
            return side * side;
        }
    }
}
