using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //base class
    public class Animal
    {
        //method of animal class
        public void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
    }

    //derived class
    public class Dog : Animal
    {
        //method of dog class
        public void Bark()
        {
            Console.WriteLine("The dog is barking");
        }
    }

    //derived class
    public class Puppy : Dog
    {
        //method of puppy class
        public void Weep()
        {
            Console.WriteLine("The puppy is weeping");
        }
    }


}
