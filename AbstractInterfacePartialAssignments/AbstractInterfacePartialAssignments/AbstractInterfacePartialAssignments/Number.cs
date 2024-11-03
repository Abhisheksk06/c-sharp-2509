using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    // class to represnt a number
    public class Number
    {
        //property
        public int Value { get; set; }
        //constructor
        public Number(int value)
        {
            Value = value;
        }
    }
    //static class for extension method
    public static class NumberExtensions
    { 
        //Extension method
        public static bool IsEven(this Number number)
        {
            return number.Value % 2 == 0;
        }
    }
}
