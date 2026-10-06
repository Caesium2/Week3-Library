using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Library
{
    public class Book
    {
        string Title;
        string Author;
        string ISBN;

        //Constructor eample to construct a new book object
        //Constructor name must be same as the class name
        public Book(string bookTitle, string bookAuthor, string bookISBN) {

            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo() {

            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        
        
        }
    }
}
