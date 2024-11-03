using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace C_Part5Assignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////1. Library.cs
            ////library instance with capacity of 5 books
            //Library library = new Library(5);
            //library.AddBook("Wings of Fire");
            //library.AddBook("Othello");
            //library.AddBook("Mending Wall");
            //library.DisplayBooks(); //Display all books in the library
            //Console.WriteLine();

            ////classroom instance with 4 rows and 4 columns
            //Classroom classroom = new Classroom(4, 2);
            //classroom.AssignSeat(0, 0, "Abhishek");
            //classroom.AssignSeat(0, 1, "Aaron");
            //classroom.AssignSeat(1, 0, "Ananthu");
            //classroom.AssignSeat(1, 1, "Faizn");
            //classroom.AssignSeat(2, 0, "stud1");
            //classroom.AssignSeat(2, 1, "stud2");
            //classroom.AssignSeat(3, 0, "anu");
            //classroom.AssignSeat(3, 1, "manu");
            //classroom.DisplaySeatingArrangement(); //Display the current seating arrangement
            //Console.ReadLine();


            ////2 Movie.cs
            ////instance of MovieLibrary with a capacity of 3 movies
            //MovieLibrary movieLibrary = new MovieLibrary(3);

            ////Adding movies to movie library
            //movieLibrary.AddMovie(new Movie("Interstellar", 2014));
            //movieLibrary.AddMovie(new Movie("Home", 2020));
            //movieLibrary.AddMovie(new Movie("Inception", 2010));

            ////Display all movies
            //movieLibrary.DisplayMovies();
            //Console.ReadLine();


            //////3 Order.cs
            ////instance of Order
            //Order order = new Order(1, "Laptop");

            ////Display order
            //order.DisplayOrderInfo();
            //Console.WriteLine();

            ////updating order status to shipped
            //order.UpdateStatus(OrderStatus.Shipped);
            //order.DisplayOrderInfo();
            //Console.WriteLine();

            ////updating order status to Delivered
            //order.UpdateStatus(OrderStatus.Delivered);
            //order.DisplayOrderInfo();
            //Console.ReadLine();


            //////4 Shape.cs
            ////Value type
            //Circle circle1 = new Circle(5); //instance of circle with radius 5
            //Circle circle2 = circle1; //assign circle1 to circle2

            //Console.WriteLine($"Circle1 Radius: {circle1.Radius}");
            //Console.WriteLine($"Circle2 Radius: {circle2.Radius}");

            ////modify circle2 radius
            //circle2.Radius = 15;

            ////Display results
            //Console.WriteLine($"Circle1 Radius: {circle1.Radius}");
            //Console.WriteLine($"Circle2 Radius: {circle2.Radius}");
            //Console.WriteLine();

            ////refernce types
            //Shape shape1 = new Shape(8, 3);
            //Shape shape2 = shape1;

            //Console.WriteLine($"Shape1 Breadth: {shape1.Breadth}");
            //Console.WriteLine($"Shape2 Breadth: {shape2.Breadth}");

            ////modify shape2 Breadth
            //shape2.Breadth = 5;

            ////Display results
            //Console.WriteLine($"Shape1 Breadth: {shape1.Breadth}");
            //Console.WriteLine($"Shape2 Breadth: {shape2.Breadth}");
            //Console.ReadLine();


            ////5 Score.cs
            //int playerscore = 100;
            //Console.WriteLine($"Initial score: {playerscore}");

            ////instance
            //Game game = new Game();

            ////pass playerscore by reference
            //game.IncreaseScore(ref playerscore);

            ////Display result
            //Console.WriteLine($"Updated score is : {playerscore}");
            //Console.ReadLine();

            //////6 DivideClass.cs
            //int dividend = 15;
            //int divisor = 7;

            //int quotient, remainder;

            //DivideClass divideClass = new DivideClass();

            ////calling divide method with out parameters
            //divideClass.Divide(dividend, divisor, out quotient, out remainder);

            ////display results
            //Console.WriteLine($"Dividend : {dividend}, Divisor : {divisor}");
            //Console.WriteLine($"Quotient : {quotient}, Remainder : {remainder}");
            //Console.ReadLine();

            //////7
            ////FileNotFoundException
            //try
            //{
            //    Console.WriteLine("Attempting to read a file that doesn't exist");
            //    StreamReader reader = new StreamReader("abcdef.txt");
            //    Console.WriteLine(reader.ReadToEnd());
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine($"FileNotFoundException caught:{ex.Message}");
            //    Console.WriteLine("File cannot be found");
            //}
            //Console.WriteLine();

            ////IndexOutOfRangeException
            //try
            //{
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine("Accessing out of range index of the array");
            //    Console.WriteLine(numbers[3]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
            //    Console.WriteLine("Index is invalid");
            //}
            //Console.ReadLine();


            ////8 UserInputClass.cs
            //UserInputClass userInputClass = new UserInputClass();
            //int userInput = userInputClass.GetUserInput();
            //Console.WriteLine($"Entered value is: {userInput}");
            //Console.ReadLine();


            ////9 MultipleCatch.cs
            //MultipleCatch multipleCatch = new MultipleCatch();
            //multipleCatch.PerformDivision();
            //Console.ReadLine();

            ////10 ReadFileClass.cs
            ////filepath
            //string filepath = "abcdefgh.txt";
            ////instance
            //ReadFileClass readFileClass = new ReadFileClass();
            //readFileClass.ReadFile(filepath);
            //Console.WriteLine();

            ////filepath
            //string filepath2 = "efgh.txt";
            //readFileClass.ReadFile(filepath2);
            //Console.ReadLine();

            ////11 AgeValidator.cs
            ////instance
            //AgeValidator validator = new AgeValidator();

            //try
            //{
            //    Console.Write("Enter your age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    // Calling method ValidateAge, which may throw an exception if age is invalid
            //    validator.ValidateAge(age);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"ArgumentException caught: {ex.Message}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"FormatException caught: Invalid input. {ex.Message}");
            //}
            //Console.ReadLine();


            ////12 NegativeNumberException.cs
            ////instance
            //NumberChecker checker = new NumberChecker();

            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    // Calling CheckNumber method, which may throw a NegativeNumberException
            //    checker.CheckNumber(number);
            //}
            //catch (NegativeNumberException ex)
            //{
            //    Console.WriteLine($"NegativeNumberException caught: Negative Numbers are not allowed {ex.Message}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"FormatException caught: Invalid input. {ex.Message}");
            //}
            //Console.ReadLine();

            //13 ConsoleUI Project








            ////14 NegativeNumberException2.cs
            NumberProcessor processor = new NumberProcessor();

            try
            {
                Console.Write("Enter a positive number: ");
                int input = int.Parse(Console.ReadLine());

                processor.ProcessNumber(input); // Calling method to process the input
            }
            catch (NegativeNumberException2 ex)
            {
                Console.WriteLine($"NegativeNumberException caught: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException caught: {ex.Message}");
            }
            Console.ReadLine();



            ////////15 FileProcessor.cs
            ////instance of FileProcessor.cs
            //FileProcessor fileProcessor = new FileProcessor();
            ////Reading from an existing file
            //fileProcessor.ReadFileContent("efgh.txt");
            ////Reading from invalid file
            //fileProcessor.ReadFileContent("tfc.txt");
            //Console.WriteLine();

            ////instance of MathsOperations class
            //MathsOperations mathsOperations = new MathsOperations();
            //int result = mathsOperations.Divide(15, 0);
            //Console.WriteLine(result);
            //Console.WriteLine();

            ////instance of person class
            //Person person = new Person();
            //try
            //{
            //    person.SetAge(-5);
            //}
            //catch (InvalidAgeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();


        }
    }
}
