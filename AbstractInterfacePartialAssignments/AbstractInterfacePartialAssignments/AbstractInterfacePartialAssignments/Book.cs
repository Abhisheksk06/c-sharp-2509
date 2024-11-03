using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfacePartialAssignments
{
    public class Book
    {
        //properties
        public string Title {  get; set; }
        public string Author { get; set; }

        //constructor
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    public class Library
    {
        //list
        public Book[] books;

        //constructor
        public Library(int size)
        {
            books = new Book[size];
        }

        //indexer to acces books by index
        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        //display all books
        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                if (book != null)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
                }
            }
        }
    }
}
