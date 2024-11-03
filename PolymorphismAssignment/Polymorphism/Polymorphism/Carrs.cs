using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Interface IMovable
    public interface IMovable
    {
        // Method to start moving
        void StartMoving();

        // Method to stop moving
        void StopMoving();
    }

    // Interface IDrawable
    public interface IDrawable
    {
        // Method to draw the object
        void Draw();
    }
    public class Carrs : IMovable, IDrawable
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        // Constructor to initialize Car properties
        public Carrs(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }

        // Implementing StartMoving method from IMovable
        public void StartMoving()
        {
            Console.WriteLine($"{Brand} car is now moving.");
        }

        // Implementing StopMoving method from IMovable
        public void StopMoving()
        {
            Console.WriteLine($"{Brand} car has stopped.");
        }

        // Implementing Draw method from IDrawable
        public void Draw()
        {
            Console.WriteLine($"{Brand} car have {Color} color");
        }
    }
}
