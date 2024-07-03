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
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Products(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
