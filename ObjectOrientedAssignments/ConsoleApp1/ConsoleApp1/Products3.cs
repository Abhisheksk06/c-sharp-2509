using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Products3
    {
        // properties for the Product class
        public string Name;
        public double Price;
        public string Category;

        // constructor that initializes all properties
        public Products3(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        // constructor that provides default values
        public Products3()
        {
            Name = "Default Product";
            Price = 0;
            Category = "B Category";
        }

        // static factory method to create a Product
        public static Products3 CreateProduct(string name, double price, string category)
        {
            return new Products3(name, price, category);
        }

        // method to display product details
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Name: {Name}, Price: {Price}, Category: {Category}");
        }




    }
}
