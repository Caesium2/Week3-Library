using Week3_Library;
class Program {

    static void Main(string[] args)
    {
        //Information for one book in our library
        Book book = new Book("C# for beginners", "BillGates", "12345678");

        book.DisplayInfo();

        //Information for another book in our library

        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "55127846");

        book1.DisplayInfo();
    }
}