//using System; Access to C# features e.g. showing text
//using System.Collections.Generic; Allows for lists to be used and stored
//using System.Text; Allows for texr and strings
//The top three aren't nescessary cause modern application can use implicit global usings

namespace Library
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();

        }

    }

}
