/*
Create a base class Shape with an abstract method GetArea(). 
Derive classes Rectangle, Circle, and Triangle from the base class, 
each with their own specific implementations of GetArea().
Implement a ShapeManager class that holds a collection (e.g., List) of
 Shape objects. Provide methods to add and remove shapes from the collection.]
Implement a method in ShapeManager to loop through the collection and 
calculate the total area of all shapes, demonstrating polymorphism.
*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public abstract class Shape{
    public abstract double GetArea();
}

public class Rectangle : Shape{
    public int length{get;set;}
    public int width{get;set;}
    
    public Rectangle(int _length, int _width){
        length = _length;
        width = _width;
    }
    
    public override double GetArea(){
        return (length*width);
    }
}

public class Triangle : Shape{
    public int height{get;set;}
    public int length{get;set;}
    
    public Triangle(int _height, int _length)
    {
        height = _height;
        length = _length;
    }
    
    public override double GetArea(){
        return((0.5)*(height)*(length));
    }
}

public class Circle : Shape{
    public int radius{get;set;}
    
    public Circle(int _radius){
        radius = _radius;
    }
    
    public override double GetArea(){
        return (Math.PI*Math.Pow(radius,2));
    }
}

public class HelloWorld
{
    public static void Main(string[] args){
        List<Shape> ShMan = new List<Shape>(){
                new Rectangle(12,23),
                new Triangle(12,23),
                new Circle(12)
           };
           
        foreach(var item in ShMan){
            Console.WriteLine(item.GetArea());
        }
    }
}