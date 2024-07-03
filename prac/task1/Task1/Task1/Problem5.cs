/*Modify your Book class to ensure that all fields are safely encapsulated. 
Provide public methods to allow controlled access to these fields, such
 as getting and setting values.*/

using System;

public class Book
{
    private static Book instance; 
    private string title;
    private string author;
    private int pages;

    // Private constructor
    private Book(string title, string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int Pages
    {
        get { return pages; }
        set { pages = value; }
    }

    // Public static method to access the singleton instance
    public static Book GetInstance(string title, string author, int pages)
    {
        if (instance == null)
        {
            instance = new Book(title, author, pages);
        }
        return instance;
    }

    // Method to display book information
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Pages: {pages}");
    }
}

public class Program5{
    // static void Main(string[] args)
    // {
    //     Book book1 = Book.GetInstance("B1", "A1", 180);

    //     book1.DisplayInfo();

    //     book1.Title = "B2";
    //     book1.Author = "A2";
    //     book1.Pages = 280;

    //     book1.DisplayInfo();
    // }
}