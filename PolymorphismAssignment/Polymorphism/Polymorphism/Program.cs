using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {

            //////1 Shape.cs
            //Circle circle = new Circle();
            //circle.Draw();
            //Console.WriteLine();

            //Rectangle rectangle = new Rectangle();
            //rectangle.Draw();
            //Console.ReadLine();



            ////2 Multiply.cs
            //// creating an instance
            //MultiplyClass multiplyClass = new MultiplyClass();

            //// Calling Multiply with different parameter types, numbers, and order
            //Console.WriteLine("Multiply(2, 3): " + multiplyClass.Multiply(2, 3));                  
            //Console.WriteLine("Multiply(2, 3, 4): " + multiplyClass.Multiply(2, 3, 4));           
            //Console.WriteLine("Multiply(2.5, 3.5): " + multiplyClass.Multiply(2.5, 3.5));         
            //Console.WriteLine("Multiply(2, 3.5): " + multiplyClass.Multiply(2, 3.5));             
            //Console.WriteLine("Multiply(2.5, 3): " + multiplyClass.Multiply(2.5, 3));
            //Console.ReadLine();


            ////3 Vehicle.cs
            //// Creating an instance of the base class
            //Vehicle myVehicle = new Vehicle();
            //myVehicle.Drive(); // calls the Vehicle's Drive method

            //// Creating an instance of the derived class
            //Car2 myCar = new Car2();
            //myCar.Drive(); // calls the Car's overridden Drive method
            //Console.ReadLine();


            ////4 Payment.cs
            //// Creating instances of each payment type
            //CreditCardPayment payment1 = new CreditCardPayment();
            //PayPalPayment payment2 = new PayPalPayment();

            //// Calling ProcessPayment method on each payment type
            //payment1.ProcessPayment();
            //payment2.ProcessPayment();
            //Console.ReadLine();



            ////5 Employee.cs
            //// Creating instances of Manager and Developer
            //Manager emp1 = new Manager();
            //Developer emp2 = new Developer();
            //Developer emp3 = new Developer();

            //// Demonstrating polymorphism with overridden GetRole method
            //emp1.GetRole();
            //emp2.GetRole();
            //emp3.GetRole();

            //// Displaying the total number of employees
            //Employee.DisplayEmployeeCount();
            //Console.ReadLine();


            ////6 Employee2.cs
            //// array of tasks for each type of employee
            //string[] managerTasks = { "Monitor Team", "Provide resources", "Conduct meetings" };
            //string[] developerTasks = { "Write code", "Fix bugs", "Attend meetings" };

            //// Creating instances of Manager and Developer
            //Manaager manager = new Manaager("Abhishek", managerTasks);
            //Deeveloper developer = new Deeveloper("Ananthu", developerTasks);


            //// Array of Employee references
            //Employee2[] employees = { manager, developer };

            //// Displaying tasks for each employee in the array
            //foreach (var employee in employees)
            //{
            //    employee.DisplayTasks();
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            ////7 AddNumbers.cs
            //// Early Binding: Compile-Time Polymorphism using Method Overloading
            //AddNumbers calc = new AddNumbers();
            //Console.WriteLine("Early Binding (Method Overloading):");
            //Console.WriteLine("Add(5, 3): " + calc.Add(5, 3));
            //Console.WriteLine("Add(4.5, 2.3): " + calc.Add(4.5, 2.3));
            //Console.WriteLine("Add(1, 2, 3): " + calc.Add(1, 2, 3));
            //Console.WriteLine();

            //// Late Binding: Runtime Polymorphism using Method Overriding
            //Console.WriteLine("Late Binding (Method Overriding):");
            //Addition additionCalc = new Addition();
            //Multiplication multiplicationCalc = new Multiplication();

            //additionCalc.DisplayOperation();
            //multiplicationCalc.DisplayOperation();
            //Console.ReadLine();

            ////8 Shape2.cs
            //// Creating instances of Circlee and Rectanglee
            //Circlee circle = new Circlee(5);
            //Rectanglee rectangle = new Rectanglee(4, 6);

            //// Demonstrating runtime polymorphism with abstract class 
            //circle.DisplayArea();
            //rectangle.DisplayArea();
            //Console.WriteLine();

            //// Demonstrating runtime polymorphism with interface IShape
            //IShape circleShape = new Circlee(5);
            //IShape rectangleShape = new Rectanglee(4, 6);

            //circleShape.DisplayShapeType();
            //rectangleShape.DisplayShapeType();

            //Console.ReadLine();

            ////9 Carrs.cs
            //// Creating an instance of Car
            //Carrs myCar = new Carrs("Benz", "Red");

            //// Using IMovable methods
            //myCar.StartMoving();
            //myCar.StopMoving();

            //Console.WriteLine();

            //// Using IDrawable method
            //myCar.Draw();
            //Console.ReadLine();

            ////10 Animal.cs
            //// Creating an instance ofAnimal, Dog and Cat class
            //Animal animal = new Animal("Dog");
            //Dog mydog = new Dog("Bruno");
            //Cat mycat = new Cat("Dune");
            //Dog mydog2 = new Dog("Hulk");

            ////Demonstrating polymorphism with Describe method
            //animal.Describe();
            //mydog.Describe();
            //mycat.Describe();
            //mydog2.Describe();


            //////Attempting to modify the readonly property (this will result in an error)
            ////mydog.Name = "NewName";
            //Console.ReadLine();




        }
    }
}
