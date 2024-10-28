using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Engine
    {
        // property to store the horse power of the engine
        public int HorsePower { get; set; }

        // constructor to initialize horse power
        public Engine(int horsePower)
        {
            HorsePower = horsePower;
        }

        // method to show engine details
        public void ShowEngineDetails()
        {
            Console.WriteLine($"Engine HorsePower: {HorsePower} HP");
        }
    }

    class Carr
    {
        // property to store the model of the car
        public string Model { get; set; }

        // Car HAS-A Engine
        private Engine engine;

        // constructor to initialize the car model and engine
        public Carr(string model, int horsePower)
        {
            Model = model;
            engine = new Engine(horsePower); // create a new Engine instance
        }

        // method to show car details
        public void ShowCarDetails()
        {
            Console.WriteLine($"Car Model: {Model}");
            engine.ShowEngineDetails(); // Using the Engine object
        }
    }
}
