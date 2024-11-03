using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //base class
    public class Shape
    {
        // virtual method to be overridden
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    // Derived class: Circle
    public class Circle : Shape
    {
        // override the Draw method
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class: Rectangle
    public class Rectangle : Shape
    {
        // override the Draw method
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}

