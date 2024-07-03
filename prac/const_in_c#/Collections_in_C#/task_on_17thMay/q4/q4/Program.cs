/*
You have two lists: one of students and one of courses they
are enrolled in. Each course has a list of student IDs enrolled
in it. You need to find the courses with more than 3 students
enrolled and list the course name along with the names of the
students enrolled in it.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "abc"),
                new Student(2, "def"),
                new Student(3, "ghi"),
                new Student(4, "jkl"),
                new Student(5, "mno"),
                new Student(6, "pqr")
            };

            List<Courses> courses = new List<Courses>() 
            {
                new Courses("c1", new List<Student>{students[0],students[1],students[2]}),
                new Courses("c2", new List<Student>{students[0],students[1],students[2],students[3],students[5]}),
                new Courses("c3", new List<Student>{students[1],students[2],students[5],students[4]}),
                new Courses("c4", new List<Student>{students[0],students[1],students[2],students[3]}),
                new Courses("c5", new List<Student>{students[3],students[4],students[5]})
            };

            var course_more = from c in courses
                              where c.EnrolledStudents.Count() > 3
                              select c;

            foreach (var item in course_more)
            {
                Console.WriteLine(item.Name);
                foreach (var item1 in item.EnrolledStudents)
                {
                    Console.WriteLine(item1.Name);
                }
            }
        }
    }
}
