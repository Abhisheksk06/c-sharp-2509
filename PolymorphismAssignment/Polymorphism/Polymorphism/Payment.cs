using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //base class
    public class Payment
    {
        // virtual method that can be overridden by derived classes
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing payment.");
        }
    }

    // Derived class for Credit Card Payment
    public class CreditCardPayment : Payment
    {
        // overriding the ProcessPayment method
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }

    // Derived class for PayPal Payment
    public class PayPalPayment : Payment
    {
        // ovverriding the ProcessPayment method
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment...");
        }
    }
}
