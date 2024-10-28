using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class University
    {
        //List to store dept objs
        public List<Department> departments = new List<Department>();

        //method to add dept
        public void AddDepartment(string name)
        {
            departments.Add(new Department(name));
        }

        //method to add a new course to department
        public void AddCourse(string departmentName, string courseName, string courseCode, int credits)
        {
            Department department = departments.Find(d => d.Name == departmentName);
            if(department != null)
            {
                department.AddCourse(courseName, courseCode, credits);
            }
            else
            {
                Console.WriteLine($"Department {departmentName} not found");
            }
        }

        //method to display details of all departments and their courses
        public void DisplayCourseDetails()
        {
            foreach (var department in departments)
            {
                Console.WriteLine($"Department: {department.Name}");
                foreach (var course in department.Courses)
                {
                    Console.WriteLine($"Course Name: {course.CourseName}, Course Code: {course.CourseCode}, Credits: {course.Credits}");
                }
            }
        }
        //nested department class
        public class Department
        {
            public string Name;
            public List<Course> Courses;

            //constructor for dept with name and empty course list
            public Department(string name)
            {
                Name = name;
                Courses = new List<Course>();

            }

            //method to add a course to the dept
            public void AddCourse(string courseName, string courseCode, int credits)
            {
                Courses.Add(new Course(courseName, courseCode, credits));
            }
        }

        //nested course class
        public class Course
        {
            public string CourseName;
            public string CourseCode;
            public int Credits;

            //constructor for initialize course details
            public Course(string  courseName, string courseCode, int credits)
            {
                CourseName = courseName;
                CourseCode = courseCode;
                Credits = credits;
            }
        }

    }
}
