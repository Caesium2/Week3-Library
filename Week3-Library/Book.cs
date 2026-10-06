using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Library
{
    public class Book
    {
        private string title; //field 
        private string author; //field
        private string isbn; //field

        //Title property to allow access to the private field wihtout allowing full access
        public string Title {

            get { return title;} //Get method
            set { title = value;} //Set method
        }

        public string Author
        {

            get { return author;}
            set
            {

                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else { 
                
                    Console.WriteLine("Error: Author name cannot contain numbers");
                }
            }
        
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {

                if (value != "")
                {

                    isbn = value;


                }
                else {

                    Console.WriteLine("Error: ISBN cannot be blank");
                
                }
            }
        }



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
