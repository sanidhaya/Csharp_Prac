/*
Given a list of Book objects with properties Title, Author, 
Genre, and PublicationYear, write a LINQ query to group
books by their genre and then order each group by 
publication year. Display the results
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Book{
    public string Title{get;set;}
    public string Author{get;set;}
    public string Genre{get;set;}
    public DateTime PublicationYear{get;set;}

    public Book(string title, string author, string genre, DateTime py){
        Title = title;
        Author = author;
        Genre = genre;
        PublicationYear = py;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Book>  books = new List<Book>(){
            new Book("abc","aa","abc",new DateTime(2015,12,23)),
            new Book("def","bb","abc",new DateTime(2019,5,12)),
            new Book("ghi","abb","abc",new DateTime(2011,4,29)),
            new Book("b1","as","def",new DateTime(2019,6,12)),
            new Book("b2","As","def",new DateTime(2018,7,12)),
            new Book("b3","ass","def",new DateTime(2015,2,12))
        };

        var newBook = from b in books
                    group b by b.Genre into g
                    select new{
                        Genre = g.Key,
                        Books = g.OrderBy(b => b.PublicationYear)
                    };
                    
        var blbks = books.GroupBy(b => b.Genre).Select(g => new{Genre = g.Key,Books = g.OrderBy(b => b.PublicationYear)});
                    
        foreach(var i in blbks)
        {
                Console.WriteLine($"{i.Genre} => {i.Books}");
                foreach(var k in i.Books)
                {
                    Console.WriteLine($"{k.PublicationYear}");
                }
        }
    }
}
