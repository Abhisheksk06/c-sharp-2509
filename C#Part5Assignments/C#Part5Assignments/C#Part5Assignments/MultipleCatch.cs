using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class MultipleCatch
    {
        //method
        public void PerformDivision()
        {
            int dividend = 0;
            int divisor = 0;
            bool isValidInput = false;

            //loop untill valid inputs are provided
            while (!isValidInput)
            {
                try
                {
                    Console.WriteLine("Enter the dividend");
                    dividend = int.Parse(Console.ReadLine()); //read and parse dividend

                    Console.WriteLine("Enter the divisor");
                    divisor = int.Parse(Console.ReadLine()); //read and parse divisor

                    //division
                    int result = dividend / divisor;
                    Console.WriteLine($"Result: {dividend} / {divisor} = {result}");
                    isValidInput = true; //exit loop if successfull
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"FormatException caught: {ex.Message}");
                    Console.WriteLine("Invalid input. Please enter valid integers");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"DivideByZeroException caught: {ex.Message}");
                    Console.WriteLine("Divisor cannot be zero. Please enter valid divisor");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected exception caught: {ex.Message}");
                }
            }
        }
    }
}
