class Book
{
    string Title;
    string Author;
    string ISBN;

    static void Main(String[] args)
    {
        Book book = new Book();

        book.Title = "C# for beginners";
        book.Author = "Billgates";
        book.ISBN = "12345678";

        Console.WriteLine($"Book title: {book.Title}");
        Console.WriteLine($"Book author: {book.Author}");
        Console.WriteLine($"Book ISBN: {book.ISBN}");
    }
}