using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

namespace C_Part5Assignments
{
    //FileProcessor class
    public class FileProcessor
    {
        public void ReadFileContent(string filepath)
        {
            try
            {
                //Reading contents using StreamReader
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("File Contents:");
                    Console.WriteLine(content);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"FileNotFoundException caught: File not found: {filepath}");
            }
        }
    }


    //MathsOperations
    public class MathsOperations
    {
        public int Divide(int a, int b)
        {
            //Division of non zero denominator number
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException Caught: Cannot divide by zero");
                return 0;
            }
        }
    }

    //Custom exception Invalid Exception
    public class InvalidAgeException : Exception
    {
        //constructor
        //public InvalidAgeException(string message) : base(message) { }
        public InvalidAgeException()
        {
            Console.WriteLine("Invalid age provided");
        }
    }
    public class Person
    {  
        //properties
        public int Age { get; set; }
        //method
        public void SetAge(int age)
        {
           if(age < 0 || age > 120)  //check for valid age
            {
                throw new InvalidAgeException();
            }
            Age = age; //assigns valid age to the Age property
        }

    }

}
