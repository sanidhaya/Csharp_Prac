using System;
internal class Program
{
    public struct Students {
        public int Student_id;
        public String Student_name;
        public int Age;
    };

    public struct Twonumbers
    {
        public int int1;
        public int int2;
    };

    private static void Main(string[] args)
    {
        IList<Twonumbers> Numbers = new List<Twonumbers>()
        {
            new Twonumbers(){int1 = 3, int2 = 4},
            new Twonumbers(){int1 = 2, int2 = 5},
            new Twonumbers(){int1 = 1, int2 = 1},
            new Twonumbers(){int1 = 7, int2 = 8},
            new Twonumbers(){int1 = 9, int2 = 10},
            new Twonumbers(){int1 = 11, int2 = 12},
            new Twonumbers(){int1 = 13, int2 = 14 }
        };
         
        Func<int, int,bool> numFunc = (x, y) => x == y;
        Action<int, int> actionfunc = (x,y) =>
        {
            Console.WriteLine(x == y);
        };

        foreach (var item in Numbers)
        {
            bool ans = numFunc(item.int1, item.int2);
            Console.WriteLine(ans);
        }

        Console.ReadLine();
    }
}


/*
         //IList<Students> studentlist = new List<Students>() {
        //    new Students() { Student_id = 1, Student_name = "abc", Age = 20 },
        //    new Students() { Student_id = 2, Student_name = "def", Age = 21 },
        //    new Students() { Student_id = 3, Student_name = "ghi", Age = 22 },
        //    new Students() { Student_id = 4, Student_name = "jkl", Age = 23 },
        //    new Students() { Student_id = 5, Student_name = "mno", Age = 24 },
        //    new Students() { Student_id = 6, Student_name = "pqr", Age = 25 },
        //    new Students() { Student_id = 7, Student_name = "stu", Age = 26 }
        //    };

        //var teenAgerStudent = from s in studentlist
        //                      where
        //                      (s.Age > 12 && s.Age < 24 && s.Student_name.Contains("a") || s.Student_name.Contains("d"))
        //                      select new { s.Student_id,s.Student_name };

        //foreach (var item in teenAgerStudent)
        //{
        //    Console.WriteLine(item);
        //}
 */