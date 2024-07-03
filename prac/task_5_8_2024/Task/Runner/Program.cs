using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task;

namespace Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperations t = new MathsOperations();
            int a = t.add(2, 5);
            Console.WriteLine($"this is the new maths operation + {a}");
            Console.WriteLine("Blah blah");
            Console.ReadLine();
        }
    }
}
