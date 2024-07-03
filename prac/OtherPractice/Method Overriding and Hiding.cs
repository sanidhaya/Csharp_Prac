/*
Define a base class Employee with methods ShowDetails() and 
CalculateSalary(). Create a derived class Manager that overrides 
CalculateSalary() and hides ShowDetails(). Demonstrate how the
behavior changes when using base and derived class references.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Employee{
    public void ShowDetails()
    {
        Console.WriteLine("Employee show details");
    }
    
    public virtual void CalculateSalary()
    {
        Console.WriteLine("Employee Calculate Salary");
    }
}

public class Manager : Employee{
    public new void ShowDetails()
    {
        Console.WriteLine("Manager details");
    }
    
    public override void CalculateSalary()
    {
        Console.WriteLine("Manager Salary");
    } 
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Employee e = new Employee();
        e.ShowDetails();
        e.CalculateSalary();
        
        Manager m = new Manager();
        m.ShowDetails();
        m.CalculateSalary();
        
        Employee em = new Manager();
        em.ShowDetails();
        em.CalculateSalary();
    }
}
