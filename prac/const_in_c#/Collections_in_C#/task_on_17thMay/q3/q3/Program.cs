/*
You have a list of books and a list of reviews for those books. 
Each review has a rating (1-5). You need to find the average rating
for each book and then list the books that have an average rating
of 4.0 or higher.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Books> books = new List<Books>()
            {
                new Books("abc1","hello1", new List<double>{4.0,5.0,2.0,4.5,4.2,4.3}),
                new Books("abc2","hello2", new List<double>{4.0,2.0,3.0}),
                new Books("abc3","hello3", new List<double>{1.0,1.3,1.4,1.8,1.5}),
                new Books("abc4","hello4", new List<double>{5.0,4.7,4.8,4.3,4.9}),
            };

            var HeighestRating = (from book in books
                                  let ratings = book.GetAverageRating()
                                  orderby ratings descending
                                  select book).FirstOrDefault();

            Console.WriteLine(HeighestRating.title);
                                  
        }
    }
}
