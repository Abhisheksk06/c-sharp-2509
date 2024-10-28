using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Print
    {
        //Method to print a string
        public void PrintData(string data)
        {
            Console.WriteLine("String:"+data);
        }

        //Method to print an integer
        public void PrintData(int data)
        {
            Console.WriteLine("Integer:" + data);
        }

        //Method to print an array of integers
        public void PrintData(int[] data)
        {
            Console.WriteLine("Array of Integers:");
            foreach(int num in data)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    }
}
