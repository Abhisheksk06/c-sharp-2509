using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Car
    {
        // fields for the car class
        public string Make;
        public string Model;
        public int Year;
        public double Price;

        // constructor that initializes only the make
        public Car(string make) 
        {
            this.Make = make;
            this.Model = "Unknown";
            this.Year = 0;
            this.Price = 0;
        }

        // constructor that initializes make and model
        public Car(string make, string model) : this(make)
        {
            this.Model=model;
        }

        // constructor that initializes make, model, and year
        public Car(string make, string model, int year) : this(make, model)
        {
            this.Year=year;
        }

        // Constructor that initializes all fields: make, model, year, and price
        public Car(string make, string model, int year, double price) : this(make,model,year)
        {
            this.Price = price;
        }

        // Method to display car details
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}");
        }
    }
}
