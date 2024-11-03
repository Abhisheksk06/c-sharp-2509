using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class AgeValidator
    {
        // method to validate age and throw an exception if age is below 18
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("Age must be 18 or older.");
            }
            Console.WriteLine("Age is valid.");
        }

    }
}
