using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is walking.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    // Class representing a Student, inheriting from Person
    class Student : Person
    {
        public string School { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying at {School}.");
        }

        public void AttendClass()
        {
            Console.WriteLine($"{Name} is attending a class.");
        }

        public void DoHomework()
        {
            Console.WriteLine($"{Name} is doing homework.");
        }
    }

    // Class representing a Teacher, inheriting from Person
    class Teacher : Person
    {
        public string Subject { get; set; }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {Subject}.");
        }

        public void GradePapers()
        {
            Console.WriteLine($"{Name} is grading papers.");
        }

        public void PrepareLesson()
        {
            Console.WriteLine($"{Name} is preparing a lesson on {Subject}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            SM s = new SM();

            // Create a Person object
            Person person = new Person { Name = "John", Age = 30 };
            person.Introduce();
            person.Walk();
            person.Sleep();

            // Create a Student object
            Student student = new Student { Name = "Alice", Age = 20, School = "XYZ University" };
            student.Introduce();
            student.Study();
            student.AttendClass();
            student.DoHomework();

            // Create a Teacher object
            Teacher teacher = new Teacher { Name = "Mr. Smith", Age = 45, Subject = "Mathematics" };
            teacher.Introduce();
            teacher.Teach();
            teacher.GradePapers();
            teacher.PrepareLesson();
        }
    }
}
