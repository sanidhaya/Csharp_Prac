using Microsoft.VisualStudio.TestTools.UnitTesting;
using q3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3.Tests
{
    [TestClass()]
    public class BooksTests
    {
        [TestMethod()]
        public void BooksTest()
        {
            // Arrange
            var mockRating = new List<double> { 4.0, 5.0, 2.0, 4.5, 4.2, 4.3 };
            var book = new Books("abc1", "hello1", mockRating);

            // Act
            var result = book.GetAverageRating();

            // Assert
            Assert.AreEqual(4.1, result, "Average rating is not correct");
        }

        [TestMethod()]
        public void GetAverageRatingTest()
        {
            // Arrange
            var mockRating = new List<double> { 4.0, 5.0, 2.0, 4.5, 4.2, 4.3 };
            var book = new Books("abc1", "hello1", mockRating);

            // Act
            var result = book.GetAverageRating();

            // Assert
            Assert.IsTrue(result >= 4.0, "Average rating is less than 4.0");
        }

        [TestMethod()]
        public void InvalidRatingTest()
        {
            // Arrange
            var mockRating = new List<double> { 4.0, 5.0, 2.0, 4.5, 4.2, 6.0 };
            var book = new Books("abc1", "hello1", mockRating);

            // Act
            // Assert
            Assert.ThrowsException<Exception>(() => book.GetAverageRating());
        }
    }
}