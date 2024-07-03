using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Checknum(string num) {
            Console.WriteLine($"{num.GetType()}");
            try
            {
                int intNum = int.Parse(num);
                Console.WriteLine($"{intNum.GetType()}");
            }
            catch (Exception ex) {
                Console.WriteLine($"it is a string of letters : {ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("../../abc.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    Checknum(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ArgumentException(ex.StackTrace);
            }
            finally {
                Console.WriteLine("Executing finally blockl");
            }
        }
    }
}
