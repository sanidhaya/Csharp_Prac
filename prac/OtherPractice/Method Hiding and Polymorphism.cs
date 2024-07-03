/*
Create a base class BasePrinter with a method Print(). 
Create a derived class DerivedPrinter that hides the 
Print() method using the new keyword. Demonstrate how
 method hiding affects the behavior when using base and
derived class references
*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Linq;

public class BasePrinter{
    public void Print()
    {
        Console.WriteLine("printing base class");   
    }
}

public class DerivedPrinter : BasePrinter{
    public new void Print()
    {
        Console.WriteLine("printing new class");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
    BasePrinter b = new BasePrinter();
    b.Print();
    
    DerivedPrinter d = new DerivedPrinter();
    d.Print();
    
    BasePrinter bd = new DerivedPrinter();
    bd.Print();
    
    DerivedPrinter db = new DerivedPrinter();
    BasePrinter bb = db;
    bb.Print();
    }
}