using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_v_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RefKeyword rf = new RefKeyword();
            OutKeyWord ou = new OutKeyWord();
            
            int i = 1;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            string test = rf.GetNextName(ref i);
            Console.WriteLine("Next value of integer is " + i.ToString()
                
                );
            
        }
    }
}
