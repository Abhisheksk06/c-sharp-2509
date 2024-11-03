using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Bank
    {
        //static field--shared across all instances
        public static double InterestRate;

        //non static field
        public double Balance;

        //static constructor
        static Bank()
        {
            InterestRate = 3.8;
            Console.WriteLine("Static constructor called: Interest rate is initialized to " + InterestRate + "%");
        }

        //regular constructor
        public Bank(double Initialbalance)
        {
            Balance = Initialbalance;
            Console.WriteLine("Account created with initial balance:" + Balance);
        }

        //display account details
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Balance: {Balance}, Interest Rate: {InterestRate}%");
        }



    }
}
