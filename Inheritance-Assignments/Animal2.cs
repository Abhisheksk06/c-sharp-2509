using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceAssignments
{
    public class Animal2
    {
        // property to store the name of the animal
        public string Name { get; set; }

        // constructor to initialize the animal's name
        public Animal2(string name)
        {
            Name = name;
        }

        // method for the animal to eat
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Dog IS-A Animal
    class Dogg : Animal2
    {
        // constructor that passes the name to the base class constructor
        public Dogg(string name) : base(name) { }

        // method for the dog to bark
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

}
