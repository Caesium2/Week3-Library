using Week3_Library;
class Program {

    static void Main(string[] args)
    {
        //Information for one book in our library
        Book book = new Book("C# for beginners", "BillGates", "12345678");

        Console.WriteLine("Currently available books");
        book.DisplayInfo();

        //Information for another book in our library

        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "55127846");

        book1.DisplayInfo();

        Console.WriteLine("Library Members:");
        Member member = new Member(1, "John Smith", "1 High Street", "0790090090");
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", "0790345666");
        //Member invalidMember = new Member(-5, "Rob0t C0p", "50 Main Street", "07811223344");
        member.DisplayInfo();
        member1.DisplayInfo();
        //invalidMember.DisplayInfo();
    }
}