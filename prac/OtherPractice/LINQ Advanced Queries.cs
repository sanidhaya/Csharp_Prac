// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

/*
Given a list of Employee objects with properties Name
, Department, Salary, and HireDate, write a LINQ query
 to find the highest-paid employee in each department.
 Ensure the solution handles potential edge cases.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Employee{
    public string Name{get;set;}
    public string Department{get;set;}
    public int Salary{get;set;}
    public string HireDate{get;set;}
    
    public Employee(string name, string department, int salary, string hiredate)
    {
        Name = name;
        Department = department;
        Salary = salary;
        HireDate = hiredate;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee("abc","aaa",123,"d1"),
            new Employee("def","aaa",243,"d2"),
            new Employee("ded","aaa",233,"d3"),
            new Employee("csd","bbb",124,"d4"),
            new Employee("sds","bbb",454,"d5"),
            new Employee("Svs","bbb",233,"d6")
        };
        
        var ab = from e in employees
                group e by e.Department into deptGroup
                let highestSalary = deptGroup.Max(emp => emp.Salary)
                select deptGroup.First(emp => emp.Salary == highestSalary);
                
        foreach(var em in ab)
        {
                Console.WriteLine($"{em.Name} from {em.Department} has {em.Salary}");
                
                //Console.WriteLine(em);
        }
    }
}