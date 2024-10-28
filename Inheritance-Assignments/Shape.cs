using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //base class
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape...");
        }

        //derived class
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle");
            }
        }
        //derived class
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a rectangle");
            }
        }



    }
}
