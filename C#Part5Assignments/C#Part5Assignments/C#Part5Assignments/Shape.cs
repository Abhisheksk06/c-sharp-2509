using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public struct Circle
    {
        //properties
        public double Radius { get; set; }

        //Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public class Shape
    {
        public double Length { get; set; } //lengthh of the shape;
        public double Breadth { get; set; } //Breadth of the shape

        //constructor
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }
}
