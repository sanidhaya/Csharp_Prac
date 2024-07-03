/*Create a base class Vehicle with properties like Make, Model, and Year, 
and a virtual method DisplayInfo().
Derive classes Car and Truck from Vehicle. Override the 
DisplayInfo() method in each derived class to display specific information about each vehicle type.
Write a program to demonstrate polymorphism by creating instances 
of Vehicle, Car, and Truck and calling the DisplayInfo() method on them.
*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Linq;

public class Vehicle{
    public string Make{get;set;}
    public string Model{get;set;}
    public int Year{get;set;}
    
    public Vehicle(string make,string model,int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    
    public virtual void DisplayInfo(){
        Console.WriteLine("Display Info for vehicle");
    }
}

public class Car : Vehicle{
    
    public string Door{get;set;}
    
    public Car(string make,string model, int year, string door) : base(make,model,year)
    {
        Door = door;
    }
    
    public override void DisplayInfo(){
        Console.WriteLine("This is a car");
    }
}

public class Truck : Vehicle{
    public string MaxW{get;set;}
    
    public Truck(string make, string model, int year, string MaxW) : base(make, model, year)
    {
        this.MaxW = MaxW;
    }
    
    public override void DisplayInfo(){
        Console.WriteLine("This is a truck");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
       List<Vehicle> vehicles = new List<Vehicle>(){
           new Car("abc","def",123,"door"),
           new Truck("ss","asa",122,"aas")
       };
       
       foreach(var item in vehicles)
        {
            item.DisplayInfo();
        }
    }
}