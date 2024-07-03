using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ques1
{
    public delegate int Operation(int x);
    public delegate double Operation2(int x);

    class MathProcessor
    {
        public void Process(int[] array, Operation op, Action<int> callback)
        {
            foreach (var item in array)
            {
                int result = op(item);
                callback(result);
            }
        }

        public void Process2(int[] array, Operation2 op, Action<double> callback)
        {
            foreach(var item in array)
            {
                double result = op(item);
                callback(result);
            }
        }
    }

    class Program
    {

        public static int Double(int x)
        {
            return x * 2;
        }

        public static int Square(int x)
        {
            return x * x;
        }

        public static int Cube(int x)
        {
            return x*x*x;
        }

        public static double Root(int x)
        {
            return (double)Math.Sqrt(x);
        }

        public static double CubeRoot(int x)
        {
            return Math.Pow(x, 1 / 3);
        }

        public static void printResults(int result)
        {
            Console.WriteLine("Processed value : " + result);
        }

        public static void printResults(double result)
        {
            Console.WriteLine("Processed value : " + result);
        }

        static void Main(string[] args)
        {
            MathProcessor proc = new MathProcessor();
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Doubling");
            proc.Process(array, Double, printResults);

            Console.WriteLine("Square");
            proc.Process(array, Square, printResults);

            Console.WriteLine("Cube");
            proc.Process(array, Square, printResults);

            Console.WriteLine("Sqrt");
            proc.Process2(array, Root, printResults);

            Console.WriteLine("Cube root");
            proc.Process2(array, Root, printResults);
        }
    }
}
