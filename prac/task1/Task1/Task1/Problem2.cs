/*
Assume your Book class has a method DisplayInfo(). 
Override this method in the Textbook class to include additional details. 
Demonstrate how method overriding works in this context.
*/

//note :- explain name var also

using System;

class PolyBook{
    public string name{get;set;}
    public void DisplayInfo(){
        Console.WriteLine($"This is a book by the name of {name}");
    }
}

class PolyTextbook : PolyBook{
    //public string name{get;set;}
    public string author{get;set;}
    public string subject{get;set;}
    public int pages{get;set;}
    public int year{get;set;}


    public void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"This is a specific subject textbook has {name} written by {author} for {subject}");
    }
}

class Problem2{
    public static void Main(string[] args){
        PolyTextbook book = new PolyTextbook();
        book.name = "C#";
        book.author = "John";
        book.subject = "C#";
        book.pages = 100;
        book.year = 2019;

        book.DisplayInfo();
    
}}