/*
Design two interfaces, IReadable and IBorrowable, for functionalities related 
to reading and borrowing library items, respectively. Implement these interfaces 
in the Book class. Discuss how using multiple specific interfaces instead of a single
generic interface adheres to the Interface Segregation Principle and supports Dependency Inversion.
*/

/*
Interface Segregation Principle means that one cannot overload a class and execute a functionality  
that it doesnot need. It helps us in preventing interface alienation. In Dependacy Inversion we 
create a layer of abstraction from where we call the classes both to the lower and higher levels.

Here in the example below we have two interfaces IReadable and IBorrowable having methods Readable and 
Borrowable ,we call both of them in the Book Class, but lets say i create a new class Online books, where 
where i would require only readable method and not the borrowable. In that case I would only require
readable and not borrowable. And by using interface segregation, we add a layer of abstraction between
class Online_Books and the class Books without having inter-dependancy and preventing any method to 
be unused and remain alienated.
*/

interface IReadable{
    public void Readable();
}

interface IBorrowable{
    public void Borrowable();
}

interface IPrintable7{
    public void PrintDetails();
}

class Prob7Book : IPrintable7,IReadable,IBorrowable{
    public string name{get;set;}
    public virtual void DisplayInfo(){
        Console.WriteLine($"This is a book by the name of {name}");
    }

    public virtual void PrintDetails(){
        Console.WriteLine($"This is a book by the name of {name}");
    }

    public void Readable(){
        Console.WriteLine($"reading a book by the name of {name}");
    }

    public void Borrowable(){
        Console.WriteLine($"borrowing a book by the name of {name}");
    }

}

class Prob7Textbook : Prob7Book{
    //public string name{get;set;}
    public string author{get;set;}
    public string subject{get;set;}
    public int pages{get;set;}
    public int year{get;set;}

    public override void PrintDetails(){
        base.PrintDetails();
        Console.WriteLine($"This is a specific subject textbook has {name} written by {author} for {subject}");
    }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"This is a specific subject textbook has {name} written by {author} for {subject}");
    }
}

class Online_Books: IReadable{
    public string name{get;set;}
    public string author{get;set;}
    public string subject{get;set;}
    public int pages{get;set;}
    public int year{get;set;}

    public void Readable(){
        Console.WriteLine($"reading an online book by the name of {name}");
    }
}

class Program7{
    // public static void Main(string[] args){
    //     Prob7Textbook book = new Prob7Textbook();
    //     book.name = "C#";
    //     book.author = "ab";
    //     book.subject = "C#";
    //     book.pages = 100;
    //     book.year = 2024;

    //     book.Readable();
    //     book.Readable();

    //     Online_Books ob = new Online_Books();
    //     ob.name = "C#";
    //     ob.author = "ab";
    //     ob.subject = "C#";
    //     ob.pages = 100;
    //     ob.year = 2024;

    //     ob.Readable();
    //     }
}