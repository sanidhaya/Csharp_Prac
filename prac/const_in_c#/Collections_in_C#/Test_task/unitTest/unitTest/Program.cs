using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace unitTest
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            Banking ba = new Banking("abc", 1.1);

            ba.Credit(5.99);
            ba.Debit(11.99);

            Console.WriteLine($"current balance us {ba.Balance}");
        }
    }
}
