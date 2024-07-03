/*
 You have a list of orders and a list of customers. 
Each order contains a list of order items and a reference to a customer.

You need to find all orders that have at least one item with a price 
greater than $100. 

For these orders, return the order ID, customer name, 
and a list of the item names that meet the price condition.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    public class Program
    {
        public struct abc
        { 
            
        }
        public static void Main(string[] args)
        {
            
            List<Customers> customers = new List<Customers>()
            {
              new Customers( 1, "abc"),
              new Customers(2, "def"),
              new Customers(3, "ghi")
            };

            List<Orders> orders = new List<Orders>()
            {
                new Orders(1, new List<OrderItem>()
                {
                    new OrderItem(23, "item1"),
                    new OrderItem(100, "item2"),
                    new OrderItem(50, "item3"),
                    new OrderItem(200, "item4"),
                    new OrderItem(300, "item5")
                }, customers[0]),
                new Orders(2, new List<OrderItem>()
                {
                    new OrderItem(100, "item2"),
                    new OrderItem(50, "item3"),
                    new OrderItem(200, "item4"),
                }, customers[2]),
                new Orders(2, new List<OrderItem>()
                {
                    new OrderItem(100, "item2"),
                    new OrderItem(50, "item3"),
                    new OrderItem(200, "item4"),
                }, customers[2]),
                new Orders(2, new List<OrderItem>()
                {
                    new OrderItem(50, "item3")
                }, customers[2])

            };

            var order_customer_naems = from order in orders
                                       join customer in customers on order.Consumer.Id equals customer.Id
                                       select new { order, customer.Name };

            //orders with one item greater than 100
            var order_gr = from order in order_customer_naems
                           where order.order.OrderItems.Any(items => items.Price > 100)
                           select order;

            foreach (var item in order_gr)
            {
                Console.WriteLine(string.Join(",", item.order.OrderItems.Select(OrderItem => OrderItem.Ordername)));
            }

            var itgr = ((from order in order_gr
                         let order_list = order.order.OrderItems.Where(item => item.Price > 100).Select(item => item.Ordername).ToList()
                         select new {order.order.Id, order.Name, OrderItem = order_list}).ToList());

            foreach (var item in itgr)
            {
                Console.WriteLine($"{item.Id}, {item.Name}, {string.Join(",",item.OrderItem)}");
            }
        }
    }
}
