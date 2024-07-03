// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

/*
Create a method ProcessOrder() in a OrderProcessor class that
 throws different types of exceptions (ArgumentNullException,
 InvalidOperationException, and a custom OrderProcessingException). 
Handle these exceptions differently in a calling method.
*/


using System;
using System.Collections.Generic;
using System.Linq;

public class Order{
    public string Name{get;set;}
    public int Price{get;set;}
    public string Type{get;set;}
    
    public Order(string name,int price, string type)
    {
        Name = name;
        Price = price;
        Type = type;
    }
}

public class OrderProcessingException : Exception{
    public OrderProcessingException() {}
    
    public OrderProcessingException(string message) : base(message) {}
}

public class LessAmountException : Exception{
    public LessAmountException() {}
    
    public LessAmountException(string message) : base(message) {}
}

public class OrderProcessor{
    
    private int TotalAmount = 1000;
    
    public void ProcessOrder(Order order)
    {
        if (string.IsNullOrEmpty(order.Type))
        {
            throw new ArgumentNullException($"Order {order.Name} type cannot be empty");
        }
        
        if ((order.Type != "buy" )&&(order.Type !="sell"))
        {
            throw new InvalidOperationException($"Order {order.Type} has to be buy or sell");
        }
        
        if (order.Type == "Invalid Order")
        {
            throw new OrderProcessingException($"Invalid order");
        }
        
        if (order.Price > TotalAmount){
            throw new LessAmountException($"Amount remaining is less than {order.Price}");
        }else{
            TotalAmount -= order.Price;
            Console.WriteLine($"{order.Name} is successful and the remaining price is {TotalAmount}");
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var processor = new OrderProcessor();
        
        List<Order> orders = new List<Order>(){
        new Order("o1",12,"withdraw"),
        new Order("o2",23,"buy"),
        new Order("o3",23,"sell"),
        new Order("o4",12,"buy"),
        new Order("o5",14,"accept"),
        new Order("o6",34,null),
        new Order("o7",233,"Invalid Order")
        };
        
        foreach(var item in orders)
        {
            try{
                processor.ProcessOrder(item);
                Console.WriteLine("Order successfully processed");
            }catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(OrderProcessingException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(LessAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }finally{
                Console.WriteLine("all orders processed");
            }
        }
    }
}










