using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //sealed class
    sealed class SealedClass
    {
        public void SealedMethod()
        {
            Console.WriteLine("The sealed method is invoked");
        }
    }
    ////// attempting to inherit from a sealed class
    //class Trees : SealedClass
    //{
    //    public void TreesMethod()
    //    {
    //        Console.WriteLine("The Trees Method has been invoked");
    //    }
    //}
}
