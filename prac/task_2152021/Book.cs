public class Book
{
    public string Name { get; set; }
    public int BookId { get; set; }
    public List<BookAssigned> AssignedBooks { get; set; } = new List<BookAssigned>();

    public Book(string name, int id)
    {
        Name = name;
        BookId = id;
    }

    public void AssignBook(string patronName, int numberOfBooks, List<string> bookNames)
    {
        AssignedBooks.Add(new BookAssigned { numberOfBooks, patronName, bookNames });
    }

    public List<string> GetAssignedBooks(string patronName)
    {
        return AssignedBooks.Where(x => x._person_name == patronName).Select(x => string.Join(", ", x._book_names)).ToList();
    }

    public bool IsBookAssigned(string patronName, string bookName)
    {
        return AssignedBooks.Any(x => x._person_name == patronName && x._book_names.Contains(bookName));
    }
}

public struct BookAssigned
{
    public int NumberOfBooks { get; set; }
    public string PersonName { get; set; }
    public List<string> BookNames { get; set; }
}