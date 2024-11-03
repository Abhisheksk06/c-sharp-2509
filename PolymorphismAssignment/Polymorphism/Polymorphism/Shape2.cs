using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Shape2
    {
        // abstract method to calculate area
        public abstract double CalculateArea();

        // virtual method to display the shape's area
        public virtual void DisplayArea()
        {
            Console.WriteLine("Area of the shape: " + CalculateArea());
        }
    }

    // Interface IShape
    public interface IShape
    {
        // Method to display the shape type
        void DisplayShapeType();
    }

    // Derived class Circle implementing Shape (abstract class) and IShape (interface)
    public class Circlee : Shape2, IShape
    {
        public double Radius { get; set; }

        // Constructor
        public Circlee(double radius)
        {
            Radius = radius;
        }

        // Implementing abstract method from Shape
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Implementing interface method
        public void DisplayShapeType()
        {
            Console.WriteLine("Shape Type: Circle");
        }

        // overriding the DisplayArea method from Shape
        public override void DisplayArea()
        {
            Console.WriteLine("Circle Area: " + CalculateArea());
        }
    }
    // Derived class Rectangle implementing Shape and IShape
    public class Rectanglee : Shape2, IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor
        public Rectanglee(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Implementing abstract method from Shape
        public override double CalculateArea()
        {
            return Length * Width;
        }

        // Implementing interface method
        public void DisplayShapeType()
        {
            Console.WriteLine("Shape Type: Rectangle");
        }

        // overriding the DisplayArea method from Shape
        public override void DisplayArea()
        {
            Console.WriteLine("Rectangle Area: " + CalculateArea());
        }
    }
}

