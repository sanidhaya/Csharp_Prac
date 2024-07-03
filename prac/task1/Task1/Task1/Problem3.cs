/*In the Book class, implement multiple constructors that allow initializing
 a book's properties in different ways. Explain how constructor overloading 
 can improve class usability*/

// ask the doubt regarding deep shalow constructor reference

/*as seen in the below example when we are able to overload the constructor
we are able to use the constructor for various tasks.*/

class ConstBook{
    public ConstBook()
    {
        Console.WriteLine("Default Constructor");
    }

    public ConstBook(int name, int year)
    {
        Console.WriteLine($"this is the name of the book {name} which was produced in {year}");
    }

    public static string pages;

    static ConstBook()
    {
        pages = "white";
    }
}

class Program3{
    // static void Main(){
    //     ConstBook book1 = new ConstBook();
    //     ConstBook book2 = new ConstBook(1,2021);
    //     Console.WriteLine(ConstBook.pages);
    // }
}
