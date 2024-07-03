class Program
{
    static void Main(string[] args)
    {
        // Create a list of books
        List<Book> books = new List<Book>
        {
            new Book("Book1", 1),
            new Book("Book2", 2),
            new Book("Book3", 3)
        };

        // Create a list of patrons
        List<Patron> patrons = new List<Patron>
        {
            new Patron { Name = "John" },
            new Patron { Name = "Jane" }
        };

        // Assign books to patrons
        books[0].AssignBook("John", 1, new List<string> { "Book1" });
        books[1].AssignBook("Jane", 1, new List<string> { "Book2" });

        // Create a transaction
        Transaction transaction = new Transaction(books[0], DateTime.Now, DateTime.Now.AddDays(7));

        // Simulate borrowing and returning books
        patrons[0].BorrowBook(books[0]);
        Console.WriteLine("John has borrowed Book1");
        patrons[0].ReturnBook(books[0]);
        Console.WriteLine("John has returned Book1");

        // Search for books
        Console.WriteLine("Books assigned to John:");
        foreach (var book in books.Where(b => b.IsBookAssigned("John", b.Name)))
        {
            Console.WriteLine(book.Name);
        }
    }
}