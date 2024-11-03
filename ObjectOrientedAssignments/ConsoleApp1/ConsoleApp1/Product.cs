using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Product
    {
        public string Name { get; set; }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Price cannot be negative");
            }
        }

        private int stock;
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                    stock = value;
                else
                    Console.WriteLine("Stock cannot be negative");
            }
        }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Stock: {Stock}");
        }

        public bool ReduceStock(int quantity)
        {
            if (quantity > Stock)
            {
                Console.WriteLine($"Not enough stock for {Name}. Available stock: {Stock}");
                return false;
            }
            else
            {
                Stock -= quantity;
                Console.WriteLine($"{quantity} {Name} ordered. New stock: {Stock}");
                return true;
            }

        }

        public class Order
        {
            public List<(Product, int)> OrderedItems { get; set; } = new List<(Product, int)>();
            public double TotalAmount { get; set; }

            public void AddToOrder(Product product, int quantity)
            {
                if (product.ReduceStock(quantity))
                {
                    OrderedItems.Add((product, quantity));
                    TotalAmount += product.Price * quantity;
                    Console.WriteLine($"{quantity} {product.Name} added to the order");
                }
            }

            public void DisplayOrder()
            {
                Console.WriteLine("Order Summary:");
                foreach (var (product, quantity) in OrderedItems)
                {
                    Console.WriteLine($"Product: {product.Name}, Quantity: {quantity}, Price: {product.Price}");
                }
                Console.WriteLine($"Total Amount: {TotalAmount}");
            }




        }
    }
}
