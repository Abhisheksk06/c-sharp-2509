using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class DeveloperAttribute : Attribute
    {
        public string Name { get; }
        public string Date { get; }

        public DeveloperAttribute(string name, string date)
        {
            Name = name;
            Date = date;
        }
    }
    [Developer("Abhishek S Kumar", "2024-10-14")]
    public class Calculator
    {
        [Developer("Arun S", "2024-10-05")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
