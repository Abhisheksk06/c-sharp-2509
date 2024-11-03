using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    //define the CarType enum
    public enum CarType
    {
        SUV,
        MiniSUV,
        CompactSUV,
        Sedan

    }
    public class Car3
    {
        //property
        public CarType Type { get; set; }

        //constructor
        public Car3(CarType type)
        {
            Type = type;
        }

        public void DisplayCarInfo()
        {
            switch(Type)
            {
                case CarType.SUV:
                    Console.WriteLine("This is a SUV");
                    break;
                case CarType.MiniSUV:
                    Console.WriteLine("This is a Mini SUV");
                    break;
                case CarType.CompactSUV:
                    Console.WriteLine("This is a Compact SUV");
                    break;
                case CarType.Sedan:
                    Console.WriteLine("This is a Sedan");
                    break;
                default:
                    Console.WriteLine("Not a CarType");
                    break;
            }
        }
    }
}
