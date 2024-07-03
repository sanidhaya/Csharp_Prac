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
    public class Transactions
    {
        public int ProductID;
        public int Quantity { get; set; }
        public Products Product { get; set; }

        public Transactions(int quantity, Products product, int productID)
        {
            Product = product;
            Quantity = quantity;
            ProductID = productID;
        }

        public int getTotal() {
            return this.Product.Price * this.Quantity;
        }
    }
}
