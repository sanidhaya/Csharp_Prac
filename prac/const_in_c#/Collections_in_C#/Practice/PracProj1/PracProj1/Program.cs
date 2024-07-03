using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProj1
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in Enumerable.Range(0, 10).TakeWhile(n => n<9))
            {
                Console.WriteLine(number);
            }
        }
    }
}

/*
 foreach (int number in Enumerable.Range(0, 10).TakeWhile(n => n<9))
            {
                Console.WriteLine(number);
            }
 */

/*
 foreach (int number in Enumerable.Range(0, 10).Take(3))
            {
                Console.WriteLine(number);
            }
 */

/*
 foreach (int number in Enumerable.Range(0, 10).SkipWhile(n => n < 6))
            {
                Console.WriteLine(number);
            }
 */

/*
 foreach (int number in Enumerable.Range(0, 8).Take(0))
            {
                Console.WriteLine(number);
            }
 */

/*
class  Bouquet
    {
        public List<string> Flowers { get; set; }
    } 

 string[] words1 = { "the", "quick", "brown", "fox" };
            string[] words2 = { "jumped", "over", "the", "lazy", "dog" };

            var q = from words in words1.Intersect(words2) select words;

            int abc;

            Console.WriteLine(q.GetType());

            foreach(var wor in q)
            {
                Console.WriteLine(wor);
            }
 */

/*
 List<Bouquet> bouquets = new List<Bouquet>()
            { new Bouquet {Flowers = {"abc","def","ghi"}},
              new Bouquet {Flowers = {"f1","f2","f3"}},
              new Bouquet {Flowers = {"n1","n2","n3"}},
              new Bouquet {Flowers = {"a1","a2","a3"}}
            };

            IEnumerable<List<string>> query1 = bouquets.Select(bq => bq.Flowers);

            IEnumerable<string> query2 = bouquets.SelectMany(bq => bq.Flowers);

            Console.WriteLine("Result using Select \n");
            foreach (IEnumerable<string> collections in query1)
            {
                foreach(string item in collections)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            foreach (string item in query2)
            {
                Console.WriteLine(item);
            }
 */

/*
 int[] numbers = { 1, 2, 3, 4, 5 };
            string[] letters = { "a", "b", "c", "d", "e" };

            var query = from number in numbers
                        from letter in letters
                        select (number, letter);

            var lambdaQuery = letters.SelectMany(letter => numbers, (letter, number) => (letter, number));

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");

            foreach (var q in lambdaQuery)
            {
                Console.WriteLine(q);
            }
 */
