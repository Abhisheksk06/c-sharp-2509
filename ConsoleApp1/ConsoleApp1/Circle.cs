using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative");
                }
                radius = value;
            }

        }

        //constructor
        public Circle(double initialRadius)
        {
            Radius = initialRadius;
        }

        //method to find area
        public double Area()
        {
            return Math.PI * radius * radius;
        }

        //method to find circumference
        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }


    }
}
