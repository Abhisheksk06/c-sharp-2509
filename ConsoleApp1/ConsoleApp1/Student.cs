using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Student
    {
        public string Name;
        public int ID;
        private List<int> Grades = new List<int>();

        public Student(string name, int id)
        {
            Name = name;
            ID = id;
            
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
            Console.WriteLine($"Grade {grade} added for {Name}.");
        }

        public double CalculateAverageGrade()
        {
            if( Grades.Count == 0)
            {
                Console.WriteLine("No grades available to calculate the average");
                return 0;
            }

            int sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }
            return (double)sum/ Grades.Count;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Student Name: {Name}, ID: {ID}, Average Grade: {CalculateAverageGrade()}");
        }
    }
}
