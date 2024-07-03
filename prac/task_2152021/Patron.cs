public class Patron
{
    public string Name { get; set; }
    public List<Book> BorrowedBooks { get; set; } = new List<Book>();

    public void BorrowBook(Book book)
    {
        BorrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        BorrowedBooks.Remove(book);
    }

    public List<Book> GetBorrowedBooks()
    {
        return BorrowedBooks;
    }
}