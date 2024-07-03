/*
Given a list of integers, write a LINQ query to calculate 
the product of all elements. Ensure your solution handles 
edge cases like an empty list.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Element{
    public string name{get;set;}
    public int price{get;set;}
    
    public Element(string _name, int _price){
        name = _name;
        price = _price;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Element> elements = new List<Element>(){
            new Element("a1",1),
            new Element("a2",2),
            new Element("a3",3),
            new Element("a4",4)
        };
        
        var pr = elements.Select(e => e.price).Aggregate(1,(acc,n) => acc*n);
        
        Console.WriteLine(pr);
    }
}
