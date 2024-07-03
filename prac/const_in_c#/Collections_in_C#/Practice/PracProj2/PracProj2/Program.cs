using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProj2
{
    public class BaseClass
    {

    }

    public class Program
    {
        static void method1(string s = null,params int[] p)
        {
            foreach (var item in p)
            {
                Console.WriteLine(item);             
            }
        }

        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
            method1(123, 22);
        }
    }
}
