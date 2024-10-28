using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //base class
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //constructor
        public Person(string name, int age)
        {
            Name = name;    
            Age = age;
        }

        //display details
        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    //derived class
    class Student : Person
    {
        public string Grade { get; set; }

        //constructor
        public Student(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        //display student details
        public void DisplayStudentDetails()
        {
            DisplayPersonDetails();
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}
