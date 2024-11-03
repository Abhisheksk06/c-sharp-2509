using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class Library
    {
        //Array to store title of books
        public string[] books;
        public int bookCount; // counter for no.of books

        //constructor
        public Library(int capacity)
        {
            books = new string[capacity];   //initilaize array with given capacity
            bookCount = 0; //no books
        }

        //method to add a book
        public void AddBook(string title)
        {
            if (bookCount < books.Length)
            {
                books[bookCount] = title; //add the book title to array
                bookCount++; //increment count
                Console.WriteLine($"Book: {title} added");
            }
            else
            {
                Console.WriteLine("Library is full");
            }
            Console.WriteLine();
        }

        //method to display books
        public void DisplayBooks()
        {
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"  {books[i]}");
            }
        }

    }

    public class Classroom
    {
        public string[,] seats; //2D Array to represent seats
        public int rows; //Number of rows in classroom
        public int columns; //Number of columns in classroom

        //constructor
        public Classroom(int rows, int  columns)
        {
            this.rows = rows; //initilaize rows
            this.columns = columns; //initialize columns
            seats = new string[rows, columns]; //Initialze 2d array for seats
        }

        //method to assign to a specific seat
        public void AssignSeat(int row, int column, string studentName)
        {
            //checking seats are valid
            if(row < rows && column < columns)
            {
                seats[row, column] = studentName; //Assigning student to the seat
                Console.WriteLine($"Seat ({row + 1}, {column + 1}) assigned to {studentName}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid seat arrangement");
            }
        }

        //method to display the current seating arrangement
        public void DisplaySeatingArrangement()
        {
            Console.WriteLine("Seating Arrangements");
            //looping through rows
            for(int i = 0; i < rows; i++ )
            {
                //looping through the columns
                for(int j = 0; j < columns; j++ )
                {
                    Console.Write($"{seats[i, j]}\t");
                }
                Console.WriteLine();
            }
        }


    }
}
