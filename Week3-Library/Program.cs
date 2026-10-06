using Week3_Library;

Book book = new Book();

//Information for one book in our library

book.Title = "C# for beginners";
book.Author = "BillGates";
book.ISBN = "12345678";

book.DisplayInfo();

//Information for another book in our library

Book book1 = new Book();
book1.Title = "The Great Gatsby";
book1.Author = "F. Scott Fitzgerald";
book1.ISBN = "55127846";

book1.DisplayInfo();