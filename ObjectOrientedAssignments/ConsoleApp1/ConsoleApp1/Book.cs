using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        //constructor
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        //Method bookdetails()
        public void DisplayBook()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }

    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void Addbook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book { book.Title} added to the library.");
        }

        public void Removebook(String isbn)
        {
            Book booktoremove = books.Find(b => b.ISBN == isbn);
            if (booktoremove != null)
            {
                books.Remove(booktoremove);
                Console.WriteLine($"Book{booktoremove.Title} removed from the library.");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public void DisplayAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No Books in the library");
            }
            else
            {
                Console.WriteLine("Books in the library");
                foreach (var book in books)
                {
                    book.DisplayBook();
                }
            }
        }
    }
}