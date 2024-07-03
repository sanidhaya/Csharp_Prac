/*
Create an interface IPrintable with a method PrintDetails().
 Implement this interface in your Book and Textbook classes to print detailed descriptions of the objects.
  Explain how this demonstrates polymorphism
*/

interface IPrintable{
    public void PrintDetails();
}

class PolymBook : IPrintable{
    public string name{get;set;}
    public virtual void DisplayInfo(){
        Console.WriteLine($"This is a book by the name of {name}");
    }

    public virtual void PrintDetails(){
        Console.WriteLine($"This is a book by the name of {name}");
    }
}

class PolymTextbook : PolymBook{
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

class Program6{
//     public static void Main(string[] args){
//         PolymTextbook book = new PolymTextbook();
//         book.name = "C#";
//         book.author = "John";
//         book.subject = "C#";
//         book.pages = 100;
//         book.year = 2019;

//         book.PrintDetails();
        
// }
}