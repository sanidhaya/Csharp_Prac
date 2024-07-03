using Nunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit.Tests
{
    [TestFixture]
    public class PrimeServiceTests
    {
        private PrimeService _primeService;

        [SetUp]
        public void IsPrimeTest()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.That(result, Is.False, "1 should not be a prime");
        }
    }
}