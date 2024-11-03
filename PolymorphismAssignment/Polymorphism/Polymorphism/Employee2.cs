using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //base class
    public class Employee2
    {
        //name property
        public string Name { get; set; }
        // array property to hold tasks of employees
        public string[] Tasks { get; set; }

        // constructor to initialize tasks
        public Employee2(string name,string[] tasks)
        {
            Name = name;
            Tasks = tasks;
        }

        // virtual method to display tasks
        public virtual void DisplayTasks()
        {
            Console.WriteLine($"Tasks assigned to {Name}");
            foreach (var task in Tasks)
            {
                Console.WriteLine("- " + task);
            }
        }
    }

    // Derived class for Manager
    public class Manaager : Employee2
    {
        // constructor to initialize name and tasks to manager
        public Manaager(string name,string[] tasks) : base(name,tasks) { }

        // overriding DisplayTasks
        public override void DisplayTasks()
        {
            Console.WriteLine($"Manager {Name} tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine("- " + task);
            }
        }
    }

    // derived class for Developer
    public class Deeveloper : Employee2
    {
        // constructor to initialize tasks to developer
        public Deeveloper(string name, string[] tasks) : base(name, tasks) { }

        // Overriding DisplayTasks
        public override void DisplayTasks()
        {
            Console.WriteLine($"Developer {Name} tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine("- " + task);
            }
        }
    }
}
