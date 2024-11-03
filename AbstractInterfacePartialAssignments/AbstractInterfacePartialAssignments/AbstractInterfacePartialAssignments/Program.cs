using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////1 Vehicle.cs
            ////car class instance
            //Car mycar = new Car();
            ////calling methods
            //mycar.StartEngine();
            //mycar.StopEngine();

            ////motorcycle class instance
            //Motorcycle motorcycle = new Motorcycle();
            ////calling methods
            //motorcycle.StartEngine();
            //motorcycle.StopEngine();
            //Console.ReadLine();

            ////2 Animal.cs
            ////dog class instance
            //Dog dog = new Dog();
            ////calling method
            //dog.MakeSound();

            ////cat class instance
            //Cat cat = new Cat();
            ////calling method
            //cat.MakeSound();
            //Console.ReadLine();



            ////3 Car2.cs
            ////Car2 class instance and method
            //Car2 car2 = new Car2();
            //car2.Drive();

            ////Truck class intsance and method
            //Truck truck = new Truck();
            //truck.Drive();
            //Console.ReadLine();


            ////4 Bird.cs
            ////instance of Duck class and calling method
            //Duck duck = new Duck();
            //duck.Fly();
            //duck.Swim();
            //Console.ReadLine();

            ////5 MathOperations.cs
            ////calling static methods using class name
            //int sum = MathOperations.Add(15, 30);
            //int product = MathOperations.Multiply(15, 30);

            ////Display
            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Product: " + product);
            //Console.ReadLine();


            //////6 Number.cs
            /////Instance 
            //Number num1 = new Number(8);
            //Number num2 = new Number(15);

            ////Using the Extension method IsEven
            //Console.WriteLine($"{num1.Value} is even : {num1.IsEven()}");
            //Console.WriteLine($"{num2.Value} is even : {num2.IsEven()}");
            //Console.ReadLine();


            ////7 PersonPart1.cs
            //PersonPart1 personPart1 = new PersonPart1();
            //personPart1.Name = "Abhishek S Kumar";
            //personPart1.ShowDetails();
            //Console.ReadLine();



            ////8 EmployeePart1.cs
            ////instance of EmployeePart1 class and calling the partial method ShowSalary();
            //EmployeePart1 emp1 = new EmployeePart1();
            //emp1.Name = "Abhishek S Kumar";
            //emp1.BaseSalary = 50000;
            //emp1.Bonus = 5000;
            //emp1.ShowSalary();
            //Console.ReadLine();


            ////9 Book.cs
            ////instance
            //Library library = new Library(3);

            ////Adding books using indexer
            //library[0] = new Book("Wings of Fire", "Dr. A P J Abdul Kalam");
            //library[1] = new Book("Othello", "William Shakespeare");
            //library[2] = new Book("Mending Wall", "Robert Frost");
            ///////library[3] = new Book("Mending Wall", "Robert Frost");

            ////display books
            //library.DisplayBooks();
            //Console.ReadLine();


            //10 DivisionCalculator.cs

            ////  instance of DivisionCalculator
            //DivisionCalculator calculator = new DivisionCalculator();

            //try
            //{
            //    Console.WriteLine("Enter the numerator:");
            //    int numerator = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the denominator:");
            //    int denominator = int.Parse(Console.ReadLine());

            //    // perform the division using the Divide method
            //    int result = calculator.Divide(numerator, denominator);
            //    Console.WriteLine("The result is: " + result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error: Exception Caught, " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Execution is complete.");
            //}
            //Console.ReadLine();

            ////11 Car3.cs
            ////creating instances of Car3 class with each CarType value
            //Car3 suv = new Car3(CarType.SUV);
            //Car3 msuv = new Car3(CarType.MiniSUV);
            //Car3 csuv = new Car3(CarType.CompactSUV);
            //Car3 sedan = new Car3(CarType.Sedan);

            ////calling methods
            //suv.DisplayCarInfo();
            //msuv.DisplayCarInfo();
            //csuv.DisplayCarInfo();
            //sedan.DisplayCarInfo();
            //Console.ReadLine();


            ////12 DeveloperAttribute.cs
            //// retrieve class attribute
            //Type type = typeof(Calculator);

            //// to get custom attributes applied to the Calculator class
            //object[] classAttributes = type.GetCustomAttributes(false);
            //foreach (DeveloperAttribute attr in classAttributes)
            //{
            //    Console.WriteLine($"Class developed by: {attr.Name}, Last modified: {attr.Date}");
            //}

            //// retrieve method attribute
            //MethodInfo methodInfo = type.GetMethod("Add");

            //// to get custom attributes applied to the Add method
            //object[] methodAttributes = methodInfo.GetCustomAttributes(false);
            //foreach (DeveloperAttribute attr in methodAttributes)
            //{
            //    Console.WriteLine($"Method developed by: {attr.Name}, Last modified: {attr.Date}");
            //}
            //Console.ReadLine();



        }
    }
}
