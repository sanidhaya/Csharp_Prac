/*
Given a list of Student objects with properties Name, Grade, and Subject,
write a LINQ query to group students by subject and find the average grade
for each subject. Provide handling for cases where there are no students
in the list.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Student{
    public string Name{get;set;}
    public int Grade{get;set;}
    public string Subject{get;set;}
    
    public Student(string name, int grade, string subject){
        Name = name;
        Grade = grade;
        Subject = subject;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>(){
            new Student("John", 85, "Math"),
            new Student("Jane", 90, "Math"),
            new Student("Smith", 80, "Science"),
            new Student("Tom", 75, "Science")
        };
        
        var q = students.GroupBy(s => s.Subject).Select(g => new {
            Subject = g.Key,
            GradeAvg = g.Average(s => s.Grade)
        });
        
        foreach(var item in q)
        {
            Console.WriteLine(item);
        }
    }
}
