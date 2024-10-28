using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Products2
    {
        // fields for the Product class
        public string Name;
        public double Price;
        public double Discount;

        //constructor that initializes only the name
        public Products2(string name)
        {
            Name = name;
            Price = 0.0;      // Default price
            Discount = 0.0;   // Default discount
        }

        // constructor that initializes the name and price
        public Products2(string name, double price)
        {
            Name = name;
            Price = price;
            Discount = 0.0;   // Default discount
        }

        // constructor that initializes the name, price, and discount
        public Products2(string name, double price, double discount)
        {
            Name = name;
            Price = price;
            Discount = discount;
        }

        // method to calculate the final price after applying the discount
        public double CalculateFinalPrice()
        {
            // Apply the discount and calculate the final price
            double finalPrice = Price - (Price * (Discount / 100));
            return finalPrice;
        }

        // method to display product details
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Discount: {Discount}%");
            Console.WriteLine($"Final Price after discount: {CalculateFinalPrice()}\n");
        }
    }
}
