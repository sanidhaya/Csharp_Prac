/*
Define an abstract class called Shape with an abstract method CalculateArea().
Create two subclasses, Circle and Rectangle, that implement the CalculateArea method.
Write a small program that demonstrates the use of these classes.
*/

abstract class Shape{
    public abstract double CalculateArea();
}

class Circle : Shape{
    public double radius{get;set;}

    public override double CalculateArea(){
        return(Math.PI * radius * radius);
    }
}

class Rectangle : Shape{
    public int length{get;set;}
    public int breadth{get;set;}
    public override double CalculateArea()
    {
        return(length * breadth);
    }
}

class Program4{
    // static void Main(string[] args){
    //     Circle c = new Circle();
    //     c.radius = 5;
    //     Console.WriteLine(c.CalculateArea());

    //     Rectangle r = new Rectangle();
    //     r.length = 5;
    //     r.breadth = 10;
    //     Console.WriteLine(r.CalculateArea());
    // }
}