using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

public class Product
{
    public string Name { get; set; }
    public int StockQuantity { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Name = "John Doe", Salary = 45000 },
            new Employee { Name = "Jane Smith", Salary = 60000 },
            new Employee { Name = "Peter Jones", Salary = 55000 },
            new Employee { Name = "Alice Brown", Salary = 70000 }
        };

        List<Product> products = new List<Product>()
        {
            new Product { Name = "Laptop", StockQuantity = 5 },
            new Product { Name = "Mouse", StockQuantity = 15 },
            new Product { Name = "Keyboard", StockQuantity = 8 },
            new Product { Name = "Monitor", StockQuantity = 2 }
        };

        var highSalaryEmployees = from employee in employees
                                  where employee.Salary > 50000
                                  select employee;


        Console.WriteLine("Employees with salary greater than 50,000:");
        foreach (var employee in highSalaryEmployees)
        {
            Console.WriteLine($"\tName: {employee.Name}, Salary: {employee.Salary}");
        }

        var lowStockProducts = from product in products
                               where product.StockQuantity < 10
                               select product;

        Console.WriteLine("\nProducts with stock quantity less than 10:");
        foreach (var product in lowStockProducts)
        {
            Console.WriteLine($"\tName: {product.Name}, Stock Quantity: {product.StockQuantity}");
        }

        Console.ReadLine();
    }
}
 


                          
gang of 4 for design pattern


assignments:

what is unit testing
what is msunit, x unit, n unit, AAA, Test Doubles(mock, ...), isolation frameworks and using mock queue framework impliment MOQ framework, PPT , how to write good test cases, code coverage.