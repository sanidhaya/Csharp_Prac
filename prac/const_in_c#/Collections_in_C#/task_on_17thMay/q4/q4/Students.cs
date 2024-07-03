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
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
