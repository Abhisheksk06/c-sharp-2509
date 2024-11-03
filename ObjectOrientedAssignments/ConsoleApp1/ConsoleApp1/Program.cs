using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {

            ////1
            //try
            //{
            //    Circle circle = new Circle(5);
            //    Console.WriteLine($"Radius: {circle.Radius}");
            //    Console.WriteLine($"Area : {circle.Area()}");
            //    Console.WriteLine($"Circumference: {circle.Circumference()}");

            //    circle.Radius = -10;
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadLine();
            //}


            ////2
            //try
            //{
            //    Employee employee = new Employee("John James", 50000);
            //    employee.DisplayDetails();

            //    employee.Salary = -3000;
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadLine();
            //}


            ////3
            ////creating new library 
            //Library library = new Library();

            ////add books to library
            //library.Addbook(new Book("Wings Of Fire", "Dr. A P J Abdul Kalam", "78443989843"));
            //library.Addbook(new Book("Othello", "William Shakespeare", "78763737443"));
            //library.Addbook(new Book("Mending wall", "Robert Frost", "7477999292"));
            //Console.WriteLine();

            ////display all books
            //library.DisplayAllBooks();
            //Console.WriteLine();

            ////remove a book by isbn
            //library.Removebook("78763737443");
            //Console.WriteLine();

            ////display all books after removal
            //library.DisplayAllBooks();
            //Console.ReadLine();


            ////4
            //BankAccount bankAccount = new BankAccount("123456789", "John James", 100000);
            //bankAccount.DisplayAccountDetails();
            //Console.WriteLine();

            //bankAccount.Deposit(500);
            //bankAccount.DisplayAccountDetails();
            //Console.WriteLine();

            //bankAccount.Withdraw(1500);
            //bankAccount.DisplayAccountDetails();
            //Console.WriteLine();

            //bankAccount.Withdraw(200000);
            //Console.ReadLine();


            ////5
            //Student student1 = new Student("John James", 100);
            //Console.WriteLine();

            //student1.AddGrade(86);
            //student1.AddGrade(91);
            //student1.AddGrade(79);
            //Console.WriteLine();

            //student1.DisplayStudentDetails();
            //Console.ReadLine();


            ////6
            //Inventory storeInventory = new Inventory();

            //storeInventory.AddItem("Laptop", 10, 899);
            //storeInventory.AddItem("Phone", 26, 499);
            //Console.WriteLine();

            //storeInventory.DisplayInventory();
            //Console.WriteLine();

            //storeInventory.UpdateItem("Phone", 30, 479);
            //storeInventory.DisplayInventory();
            //Console.WriteLine();


            //storeInventory.RemoveItem("Laptop");
            //Console.WriteLine();

            //storeInventory.DisplayInventory();

            //Console.ReadLine();


            ////7
            //Product laptop = new Product("Laptop", 1300, 12);
            //Product phone = new Product("Phone", 700, 26);

            //laptop.DisplayProduct();
            //Console.WriteLine();
            //phone.DisplayProduct();
            //Console.WriteLine();

            //Product.Order order = new Product.Order();

            //order.AddToOrder(laptop, 2);
            //order.AddToOrder(phone, 1);
            //Console.WriteLine();

            //order.DisplayOrder();
            //Console.WriteLine();


            //laptop.DisplayProduct();
            //phone.DisplayProduct();
            //Console.ReadLine(); 


            ////8
            //Print print = new Print();

            //print.PrintData("Abhishek");
            //print.PrintData(22);
            //print.PrintData(new int[] { 1, 2, 3, 4, 5, 6, });
            //Console.ReadLine();


            ////9
            //Rectangle rectangle = new Rectangle();

            //double rectangleArea = rectangle.CalculateArea(10, 20);
            //Console.WriteLine($"Area of the rectangle: {rectangleArea}");

            //double squareArea = rectangle.CalculateArea(5);
            //Console.WriteLine($"Area of the square: {squareArea}");

            //Console.ReadLine();


            ////10
            //Time time = new Time();

            //time.SetTime(10, 45);
            //time.DisplayTime();

            //Console.WriteLine($"{time.hours} hours, {time.minutes} minutes");
            //Console.WriteLine();


            //time.SetTime(35000);
            //time.DisplayTime();

            //Console.ReadLine();

            ////11
            //Bank account1 = new Bank(1000);
            //account1.DisplayAccountInfo();

            //Bank account2 = new Bank(5000);
            //account2.DisplayAccountInfo();

            //Console.WriteLine($"Static Interest Rate: {Bank.InterestRate}%");
            //Console.ReadLine();

            ////12
            //Cars car1 = new Cars();
            //Cars car2 = new Cars();
            //Cars car3 = new Cars();


            //Cars.DisplayCarCount();
            //Console.ReadLine();

            ////13
            //MathOpertations.DisplayPi();
            //Console.ReadLine();

            ////14
            //Configuration.DisplaySystemSettings();
            //Console.WriteLine();

            //Configuration user1 = new Configuration("Dark", "English");
            //Configuration user2 = new Configuration("Light", "Spanish");
            //Console.WriteLine();



            //user1.DisplayUserPreferences();
            //user2.DisplayUserPreferences();
            //Console.ReadLine();

            ////15
            //// Creating an original person object
            //Person person1 = new Person("Abhishek S Kumar", 22, "Alappuzha");
            //Console.WriteLine("Original Person:");
            //person1.DisplayPersonInfo();

            //// Creating a new person object using the copy constructor
            //Person person2 = new Person(person1);
            //Console.WriteLine("\nCopied Person (using Copy Constructor):");
            //person2.DisplayPersonInfo();

            //// Creating a new person object by direct assignment
            //Person person3 = person1;
            //Console.WriteLine("\nPerson Created by Direct Assignment");
            //person3.DisplayPersonInfo();

            //// Modify the name of the person3 to see the effect on person1
            //person3.Name = "Ananthu P";

            //Console.WriteLine("\nAfter Modifying the Name of Person3 (Direct Assignment):");
            //Console.WriteLine("Person1:");
            //person1.DisplayPersonInfo(); // person1 is also modified because person3 is a reference to person1
            //Console.WriteLine("Person2:");
            //person2.DisplayPersonInfo(); // person2 remains unchanged because it is a deep copy
            //Console.WriteLine("Person3:");
            //person3.DisplayPersonInfo(); // person3 reflects the modified name
            //Console.ReadLine();



            ////16
            // Car with only the make initialized
            //Car car1 = new Car("Toyota");
            //car1.DisplayCarInfo();

            //// Car with make and model initialized
            //Car car2 = new Car("Honda", "Civic");
            //car2.DisplayCarInfo();

            //// Car with make, model, and year initialized
            //Car car3 = new Car("Ford", "Mustang", 2020);
            //car3.DisplayCarInfo();

            //// Car with all fields initialized
            //Car car4 = new Car("BMW", "X5", 2021, 50000);
            //car4.DisplayCarInfo();
            //Console.ReadLine();

            ////17
            // Product with only the name initialized
            //Products2 product1 = new Products2("Laptop");
            //product1.DisplayProductInfo();

            //// Product with name and price initialized
            //Products2 product2 = new Products2("Smartphone", 500);
            //product2.DisplayProductInfo();

            //// Product with name, price, and discount initialized
            //Products2 product3 = new Products2("Tablet", 300, 10); // 10% discount
            //product3.DisplayProductInfo();
            //Console.ReadLine();


            ////18
            ////1.Constructor initialization
            //Products3 product = new Products3("Laptop", 1500, "Electronic Gadgets");
            //product.DisplayProductInfo();

            ////2. Object initializer syntax
            //Products3 product2 = new Products3
            //{
            //    Name = "Smartphone",
            //    Price = 800,
            //    Category = "Electronic Gadgets"
            //};
            //product2.DisplayProductInfo();

            ////3. Static Factory Method
            //Products3 product3 = Products3.CreateProduct("Tablet", 15000, "Electronic Gadgets");
            //product3.DisplayProductInfo();

            ////4. Anonymous types
            //var product4 = new { Name = "Headsets", Price = 200, Category = "Accessories" };
            //Console.WriteLine($"Product Name: {product4.Name}, Price: {product4.Price}, Catgeory: {product4.Category}");

            ////5. Reflection 
            //Type productType = typeof(Products3);
            //Products3 product5 = (Products3)Activator.CreateInstance(productType, "Monitor", 250, "Electronic Gadgets");
            //product5.DisplayProductInfo();

            ////6. Default values in constructors
            //Products3 product6 = new Products3();
            //product6.DisplayProductInfo();
            //Console.ReadLine();

            ////19

            ////20
            ////Instance
            //ShoppingCart cart = new ShoppingCart();

            ////Adding Products
            //cart.AddProduct("Laptop", 1200, 1);
            //cart.AddProduct("SmartPhone", 800, 2);
            //cart.AddProduct("Laptop", 180, 3);

            ////Total Price Display
            //double totalPrice = cart.CalculateTotalPrice();
            //Console.WriteLine($"Total Price: {totalPrice}");
            //Console.ReadLine();


            ////21
            ////object
            //Bank21 bank21 = new Bank21();

            ////Add customers
            //bank21.AddCustomer("Abhishek S Kumar");
            //bank21.AddCustomer("Ananthu P");
            //bank21.AddCustomer("Fazin Ashraf");

            ////Add accounts
            //bank21.AddAccount("Abhishek S Kumar", 19221, 500000);
            //bank21.AddAccount("Ananthu P", 19201, 400000);
            //bank21.AddAccount("Fazin Ashraf", 19231, 600000);

            ////Display details
            //bank21.DisplayCustomerDetails();
            //Console.ReadLine();




            ////22
            ////object
            //University university = new University();

            ////Add departments
            //university.AddDepartment("Computer Science Engineering");
            //university.AddDepartment("Mechanical Engineering");

            ////Add Courses
            //university.AddCourse("Computer Science Engineering", "DBMS", "CST301", 4);
            //university.AddCourse("Computer Science Engineering", "Java", "CST302", 3);
            //university.AddCourse("Mechanical Engineering", "Fluid Mechanics", "MET304", 4);
            //university.AddCourse("Mechanical Engineering", "Thermodynamics", "MET305", 3);

            ////Display details
            //university.DisplayCourseDetails();
            //Console.ReadLine();







        }
    }
}

   
