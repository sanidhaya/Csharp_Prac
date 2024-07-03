using Microsoft.VisualStudio.TestTools.UnitTesting;
using q6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestMain()
        {
            // Arrange
            var products = new List<Products>
        {
            new Products(1, "abc", 12),
            new Products(2, "abc", 14),
            new Products(3, "abc", 16),
            new Products(4, "abc", 18),
        };

            var transactions = new List<Transactions>
        {
            new Transactions(22, products[0], 1),
            new Transactions(23, products[1], 2),
            new Transactions(24, products[2], 3),
            new Transactions(25, products[3], 4),
            new Transactions(26, products[0], 1),
        };

            // Create a mock for the Transactions class
            var mockTransactions = new Mock<Transactions>();
            mockTransactions.Setup(t => t.getTotal()).Returns(100);

            // Create a fake for the Products class
            var fakeProduct = new FakeProducts(1, "abc", 12);

            // Create a stub for the Program class
            var program = new Program();
            program.transactions = mockTransactions.Object;
            program.products = new List<Products> { fakeProduct };

            // Act
            var result = program.Main(null);

            // Assert
            Assert.AreEqual(1, result);
        }
    }

    public class FakeProducts : Products
    {
        public FakeProducts(int id, string name, int price) : base(id, name, price) { }
    }

    public class MockTransactions : Transactions
    {
        public MockTransactions() { }

        public int getTotal()
        {
            return 100;
        }
    }
}