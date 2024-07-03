/*
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Shape{
    public string Shapetype{get; set;}
    public int area{get;set;}
}

public class Circle : Shape{
    public int radius{get; set;}
    public int circumference{get; set;}
}

public class Rectangle : Shape{
    public int width{get;set;}
    public int height{get; set;}
}

public class Triangle : Shape{
    public int height{get;set;}
    public int trbase{get;set;}
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Circle{radius = 5};
        shapes[1] = new Rectangle{width = 8, height = 22};
        shapes[2] = new Triangle{height = 22, trbase = 21};
        
        foreach(var shape in shapes)
        {
            if (shape is Circle)
            {
                var circle = shape as Circle;
                Console.WriteLine($"{circle.radius}");
            }
            else if(shape is Rectangle)
            {
                var rectangle = shape as Rectangle;
                Console.WriteLine($"{rectangle.height} {rectangle.width}");
            }
            else if(shape is Triangle)
            {
                var triangle = shape as Triangle;
                Console.WriteLine($"{triangle.height}");
            }
        }
    }
}
*/

/*
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Container<T>
{
    private List<T> items = new List<T>();
    
    public void Add(T item)
    {
        items.Add(item);
    }
    
    public T Get(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }
        
        return items[index];
    }
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}
*/

/*
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Collections;

public class Customcoll<T> : ICollection<T>,IEnumerable<T>
{
    private int size= 8;
    public T[] colArr = new T[size];
    
    //Add
    public void Add(T t)
    {
        Console.WriteLine("element added");
    }
    //clear
    public void Clear()
    {
        Console.WriteLine("element cleared");
    }
    
    //conatins
    public bool Contains(T t)
    {
        Console.WriteLine("this might contain "+t);
        return false;
    }
    
    //Copyto
    public void CopyTo(T[] t, int a)
    {
        Console.WriteLine("these are copied");
    }
    
    //Remove
    public bool Remove(T t)
    {
        Console.WriteLine("remove this element" + t);
        return false;
    }
    
    //
    public int Count
    {
        get {return size;}
    }
    
    public bool IsReadOnly
    {
        get {return false;}
    }
    
    
    //IEnumerable
    public IEnumerator<T> GetEnumerator()
    {
        for(int i=0; i< size; i++)
        {
            yield return colArr[i];
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
    
    
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
    }
}
*/

/*
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Linq;

public class CustomObj{
    public string name{get;set;}
    public int age{get;set;}
    public int score{get;set;}
    
    public CustomObj(string _name,int _age,int _score)
    {
        name = _name;
        age = _age;
        score = _score;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<CustomObj> custObj = new List<CustomObj>(){
            new CustomObj("abc",12,12),
            new CustomObj("def",11,14),
            new CustomObj("ijk",11,34)
        };
        
        var ab = from c in custObj 
                orderby c.age, c.score 
                select c;
                
        foreach(var item in ab){
            Console.WriteLine($"{item.name} {item.age} {item.score}");
        }        
    }
}
*/