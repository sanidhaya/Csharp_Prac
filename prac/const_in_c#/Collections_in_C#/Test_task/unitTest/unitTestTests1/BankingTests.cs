using Microsoft.VisualStudio.TestTools.UnitTesting;
using unitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTest.Tests
{
    [TestClass()]
    public class BankingTests
    {
        //[TestMethod()]
        //public void BankingTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void Debit_withValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginingBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            Banking account = new Banking("mrabc", beginingBalance);

            //Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual,0.001, "Account not debited correctly");

        }

        //[TestMethod()]
        //public void CreditTest()
        //{
        //    Assert.Fail();
        //}
    }
}