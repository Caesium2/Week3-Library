using Library;

Book book = new Book();
//Info for one book in the library

book.Title = "The Great Gatsby";
book.Author = "F. Scott Fitzgerald";
book.ISBN = "12345678";

book.DisplayInfo();

//Info for second book

Book book1 = new Book();
book1.Title = "The Hunchback of Notre Dame";
book1.Author = "Victor Hugo";
book1.ISBN = "23748342";

book1.DisplayInfo();