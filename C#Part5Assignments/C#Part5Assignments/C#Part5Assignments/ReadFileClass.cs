using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class ReadFileClass
    {
        //method of ReadFile
        public void ReadFile(string filepath)
        {
            StreamReader reader = null; //initializing reader to null

            try
            {
                //Attempt to open the file
                reader = new StreamReader(filepath);
                string content = reader.ReadToEnd(); //Read the entire file content
                Console.WriteLine("File Contents:");
                Console.WriteLine(content); //Display file content
            }
            catch (FileNotFoundException ex)
            {
                //handling file does not exist case
                Console.WriteLine($"FileNotFoundException caught: {ex.Message}");
            }
            finally
            {
                //ensure the file is closed
                if (reader != null)
                {
                    reader.Close(); //close the reader
                    Console.WriteLine("File Closed");
                }
            }
        }
    }
}
