public class Transaction
{
    public Book Book { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime ExpectedEndDate { get; set; }
    public DateTime ActualEndDate { get; set; }
    public TimeSpan TotalDuration { get; set; }

    public Transaction(Book book, DateTime startDate, DateTime expectedEndDate)
    {
        Book = book;
        StartDate = startDate;
        ExpectedEndDate = expectedEndDate;
    }
}