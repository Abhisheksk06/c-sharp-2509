using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Person4
    {
        // property in the base class
        public string Name { get; set; }

        public Person4(string name)
        {
            Name = name;
        }
    }

    class Studentt : Person4
    {
        // hide the Name property using new keyword
        public new string Name
        {
            get { return "Student's name is hidden"; }
            set { }
        }

        // // constructor that accepts a name and passes it to the base class constructor
        public Studentt(string name) : base(name)
        {
        }

        // method to display both properties
        public void DisplayInfo()
        {
            // access the base class's Name property
            Console.WriteLine("Base Name: " + base.Name);
            // access the derived class's hidden Name property
            Console.WriteLine("Derived Name: " + Name);
        }
    }
}





