using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //abstract class Car {
    //    public abstract void Engine();
    //    public abstract void Door();
    //}

    //class McLaren : Car {
    //    public void Engine() {
    //        Console.WriteLine("mclaren");
    //    }


    // }


    //}

    class Student {
        private string name = "abc";

        public virtual void Abc() {
            Console.WriteLine("method abc");
        }
    }

    class NewStudent : Student {
        public void Abc()
        {
            Console.WriteLine("this is the overriden method");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> {
             1,2,3,4,5,6,7
            };

            var odds = ints.Where(i => i % 2 != 0);

            
        }
    }
}
