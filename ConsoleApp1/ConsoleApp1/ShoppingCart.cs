using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class ShoppingCart
    {
        // list that hold product objects
        public List<Product> products;

        //constructor to initialze the product lists
        public ShoppingCart()
        {
            products = new List<Product>();
        }

        // method to add a product to the cart
        public void AddProduct(string name, double price, int quantity)
        {
            products.Add(new Product(name, price, quantity));
        }

        //method to find totalprice of products
        public double CalculateTotalPrice()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price * product.Quantity;
            }
            return total;
        }

        //Nested Product Class
        public class Product
        {
            public string Name;
            public double Price;
            public int Quantity;

            //Constructor for Product Class
            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
    }
}
