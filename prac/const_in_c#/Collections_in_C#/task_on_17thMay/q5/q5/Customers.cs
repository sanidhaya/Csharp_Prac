/*
 You have a list of orders and a list of customers. 
Each order contains a list of order items and a reference to a customer.
You need to find all orders that have at least one item with a price 
greater than $100. For these orders, return the order ID, customer name, 
and a list of the item names that meet the price condition.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customers(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
