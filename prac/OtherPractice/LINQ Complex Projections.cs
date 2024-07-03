/*
Given a list of Product objects with properties Name, Category
, Price, write a LINQ query that selects products grouped by 
category and projects the results into a custom class ProductSummary
containing CategoryName and a list of products in each category.
Output the results in a formatted way.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public enum Categories{
    C1,
    C2
}

public class Product{
    public string Name{get;set;}
    public Categories Category{get;set;}
    public int Price{get;set;}
    
    public Product(string name, Categories category, int price)
    {
        Name = name;
        Category = category;
        Price = price;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Product> prods = new List<Product>{
            new Product("aa",Categories.C1,123),
            new Product("ab",Categories.C2,232),
            new Product("as",Categories.C1,343),
            new Product("qw",Categories.C2,122),
            new Product("we",Categories.C1,122)
        };
        
        var ProductSummary = prods.GroupBy(p => p.Category).Select(
                g => new {
                    Name = g.Key,
                    Products = g.Select(x => x).ToList()
                }
            );
            
        foreach(var item in ProductSummary)
        {
            Console.WriteLine(item);
            foreach(var x in item.Products)
            {
                Console.WriteLine($"{x.Name} {x.Category}");
            }
        }
    }
}
