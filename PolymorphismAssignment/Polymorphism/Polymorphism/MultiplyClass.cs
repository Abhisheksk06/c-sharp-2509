using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MultiplyClass
    {
        // Multiply with two int parameters
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Multiply with three int parameters
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        // Multiply with two double parameters
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Multiply with int and double parameters (different order)
        public double Multiply(int a, double b)
        {
            return a * b;
        }

        // Multiply with double and int parameters (different order)
        public double Multiply(double a, int b)
        {
            return a * b;
        }
    }
}
