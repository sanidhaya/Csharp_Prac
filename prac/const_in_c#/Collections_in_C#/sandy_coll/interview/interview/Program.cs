using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = [97, 92, 81, 60];

            IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;


        }
    }
}
