using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //base class
    public class Animal
    {
        // readonly property to store the name of the animal
        public readonly string Name;

        // Constructor to initialize the Name property
        public Animal(string name)
        {
            Name = name;
        }

        // Virtual method to describe the animal
        public virtual void Describe()
        {
            Console.WriteLine($"This is an animal named {Name}.");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        //constructor for the Dog class calling base class constructor
        public Dog(string name) : base(name) { }

        // overriding Describe method
        public override void Describe()
        {
            Console.WriteLine($"This is a dog named {Name}.");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        //constructor for the Cat class calling base class constructor
        public Cat(string name) : base(name) { }

        // Overriding Describe method
        public override void Describe()
        {
            Console.WriteLine($"This is a cat named {Name}.");
        }
    }
}
