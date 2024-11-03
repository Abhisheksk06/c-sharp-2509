using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class UserInputClass
    {
        //method
        public int GetUserInput()
        {
            int result=0;
            bool isVaild = false;

            //loop untill a valid integer is entered
            while (!isVaild)
            {
                Console.WriteLine("Enter an integer");
                string userInput = Console.ReadLine();//Read Input

                try
                {
                    //Check if user input is null
                    if (string.IsNullOrEmpty(userInput))
                    {
                        throw new ArgumentException("Input cannot be null");
                    }
                    //parsing input as an integer
                    result = int.Parse(userInput);
                    isVaild = true; // exit loop if parsing is successfull
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"ArgumentException caught: {ex.Message}");
                    Console.WriteLine("Please enter a valid integer");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"FormatException caught: {ex.Message}");
                    Console.WriteLine("Please enter a valid integer");
                }
                catch (OverflowException ex) {
                    Console.WriteLine($"OverflowException caught: {ex.Message}");
                    Console.WriteLine("Please enter a valid integer");
                }
            }
            return result;
        }
    }
}
