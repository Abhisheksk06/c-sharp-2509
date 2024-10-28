using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //base class
    public class Person2
    {
        //properties
        public string Name;
        public int Age;

        //Parameterized constructor
        public Person2(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Person Created: Name = {Name}, Age = {Age}");
        }
    }

    //derived class
    class Employeee : Person2
    {
        //new property
        public string Department;

        //Parameterized constructor of Employee calling base class constructor
        public Employeee(string name, int age, string department) : base(name,age)
        {
            Department = department;
            Console.WriteLine($"Employee Created: Name = {Name}, Age = {Age}, Department = {Department}");
        }
    }
}
