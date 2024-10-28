using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Person
    {
        // fields of the class
        public string Name;
        public int Age;
        public string Address;

        // constructor to initialize fields
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        // Copy constructor to create a new object from an existing object
        public Person(Person otherPerson)
        {
            Name = otherPerson.Name;
            Age = otherPerson.Age;
            Address = otherPerson.Address;
        }

        // method to display person details
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }
}
