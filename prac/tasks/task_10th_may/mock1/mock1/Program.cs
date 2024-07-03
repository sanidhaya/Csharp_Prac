using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock1
{
    abstract class Addition
    {
        //public abstract int Add(int a, int b);

        public virtual int Add(int a, int b)
        {
            return a+b;
        }

        //    public int Add(int a, int b, int c)
        //    {
        //        return a + b + c;
        //    }


    }

    class  Multiplication : Addition{

        public override int Add(int a, int b) {
            return a*b;
        }    

        //public int  Mulit(int a, int b)
        //{
        //    return a * b;
        //}
    }

    internal class Program
    {   
        static void Main(string[] args)
        {
            List<string> menties = new List<string>();
            Dictionary<string, List<string>> sto = new Dictionary<string, List<string>>();
            
        }
    }
}
