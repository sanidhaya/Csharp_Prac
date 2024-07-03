/*
You have a list of sales transactions and a list of products.

Each transaction has a product ID, quantity, and price. 

You need to calculate the total sales amount for each product and then find
the product with the highest total sales amount. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>()
            {
                new Products(1, "abc", 12),
                new Products(2, "abc", 14),
                new Products(3, "abc", 16),
                new Products(4, "abc", 18),
            };

            List<Transactions> transactions = new List<Transactions>()
            {
                new Transactions(22,products[0],1),
                new Transactions(23,products[1],2),
                new Transactions(24,products[2],3),
                new Transactions(25,products[3],4),
                new Transactions(26,products[0],1)
            };

            //foreach (var item in transactions)
            //{
            //    Console.WriteLine($"{item.getTotal()}");
            //}

            var transact = transactions
                .GroupBy(t => t.ProductID)
                .SelectMany(g => g)
                .ToList().FirstOrDefault();

            Console.WriteLine($"{transact.Product.Id}");
        }
    }
}
