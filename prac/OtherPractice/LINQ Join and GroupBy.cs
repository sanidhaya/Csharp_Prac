/*
Given two lists, Students and Courses, write a LINQ query to join
 these lists on a common StudentId and group the result by 
student names, listing all courses each student is taking.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Student{
    public string Name{get;set;}
    public int Id{get;set;}
    
    public Student(string Name, int Id){
        this.Name = Name;
        this.Id = Id;
    }
}

public class Course{
    public string CourseName{get;set;}
    public int StudentId{get;set;}
    
    public Course(string CN, int SI)
    {
        CourseName = CN;
        StudentId = SI;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>(){
            new Student("s1",1),
            new Student("s2",2),
            new Student("s3",3)
        };
        
        List<Course> courses = new List<Course>(){
            new Course("c1",1),
            new Course("c2",1),
            new Course("c3",3),
            new Course("c4",2),
            new Course("c5",1),
            new Course("c6",2),
            new Course("c7",3)
        };
        
        var si = from c in courses
                join s in students on c.StudentId equals s.Id
                group c by s.Name into studentGrps
                select new {Student = studentGrps.Key, Courses = studentGrps.ToList()};
                
        var sis = students.Join(
            courses,
            s => s.Id,
            c => c.StudentId,
            (s,c) => new{
                Name = s.Name,
                Course = c.CourseName
            }).GroupBy(sc => sc.Name).Select(g => new {
               Name = g.Key,
               Courses = g.Select(x => x.Course).ToList()
            });
           
        foreach(var i in sis)
        {
            Console.WriteLine($"Student : {i.Name} + {i}");
            foreach(var m in i.Courses)
            {
                Console.WriteLine(m);//$" - Name: {m.CourseName}, ID: {m.StudentId}");
            }
        }
        
        /*var si = from c in courses
                join s in students on c.StudentId equals s.Id
                group s by c.CourseName into courseGrps
                select new {Course = courseGrps.Key, Students = courseGrps.ToList()};
                
        foreach (var group in si)
        {
            Console.WriteLine($"Course: {group.Course}");
            foreach (var student in group.Students)
            {
                Console.WriteLine($" - Name: {student.Name}, ID: {student.Id}");
            }
        }
        */
    }
}
