using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Item
    {
        public string Name { get; set; }
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

        public Item(string name, int stock, double price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }

        public void DisplayItem()
        {
            Console.WriteLine($"Item: {Name}, Stock: {Stock}, Price: ${Price}");
        }
    }
    public class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(string name, int stock, double price)
        {
            Item newItem = new Item(name, stock, price);
            items.Add(newItem);
            Console.WriteLine($"Added item: {name}");
        }

        public void RemoveItem(string name)
        {
            Item item = items.Find(i => i.Name == name);
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine($"Removed item: {name}");
            }
            else
            {
                Console.WriteLine($"Item '{name}' not found.");
            }
        }

        public void UpdateItem(string name, int newStock, double newPrice)
        {
            Item item = items.Find(i => i.Name == name);
            if (item != null)
            {
                item.Stock = newStock;  // stock is updated only if non-negative
                item.Price = newPrice;  // srice is updated only if non-negative
                Console.WriteLine($"Updated item: {name}");
            }
            else
            {
                Console.WriteLine($"Item '{name}' not found.");
            }
        }



        public void DisplayInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
            {
                item.DisplayItem();
            }
        }

    }
}
