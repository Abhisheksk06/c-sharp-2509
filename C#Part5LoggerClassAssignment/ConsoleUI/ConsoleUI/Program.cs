using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace ConsoleUI
{
    public class Program
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Divide(int a, int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Logger.LogError("Attempted to divide by zero.", ex);
                Console.WriteLine("DivideByZeroException caught and logged.");
            }
        }
        static void Main(string[] args)
        {
            Divide(10, 0);
            Console.ReadLine();
        }
    }
}
