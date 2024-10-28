using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //interface1
    interface IMovable
    {
        void Move();
    }

    //interface2
    interface IRechargeable
    {
        void Recharge();
    }

    //Base class implementing IMovable
    public class Vehicle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }

    //Derived class ElectricCar inheriting from Vehicle and implementing IMovable, IRechargeable
    public class ElectricCar : Vehicle, IMovable, IRechargeable
    {
        //Implementing Move Method
        public new void Move()
        {
            Console.WriteLine("The electric car is moving");
        }

        //Implementing Recharge Method
        public void Recharge()
        {
            Console.WriteLine("The electric car is recharging");
        }
    }

}
