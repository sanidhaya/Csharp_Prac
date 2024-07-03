using Microsoft.VisualStudio.TestTools.UnitTesting;
using q5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace q5.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        {
        [TestMethod]
        public void TestOrdersWithItemsGreaterThan100()
        {
            // Arrange
            var customers = new List<Customers>()
            {
                new Customers(1, "abc"),
                new Customers(2, "def"),
                new Customers(3, "ghi")
            };

            var orders = new List<Orders>()
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

            var orderRepository = new Mock<IOrderRepository>();
            orderRepository.Setup(o => o.GetOrders()).Returns(orders);

            var customerRepository = new Mock<ICustomerRepository>();
            customerRepository.Setup(c => c.GetCustomers()).Returns(customers);

            var program = new Program(orderRepository.Object, customerRepository.Object);

            // Act
            var result = program.GetOrdersWithItemsGreaterThan100();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual("ghi", result[0].CustomerName);
            Assert.AreEqual("item4", result[0].OrderItemNames[0]);
            Assert.AreEqual("item5", result[0].OrderItemNames[1]);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual("ghi", result[1].CustomerName);
            Assert.AreEqual("item2", result[1].OrderItemNames[0]);
            Assert.AreEqual("item4", result[1].OrderItemNames[1]);
        }
    }
}