using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ComVisibility
{
    [ComVisible(false)]
    class MyClass
    {
        public static void Fun()
        {
            Console.WriteLine("My class");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
