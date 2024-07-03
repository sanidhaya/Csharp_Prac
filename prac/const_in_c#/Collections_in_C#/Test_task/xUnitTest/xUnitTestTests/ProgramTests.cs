using xUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace xUnitTest.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
              var primeService = new Program();
                bool result = primeService.IsPrime(1);

                Assert.False(result, "1 should not be prime");
        }
    }
}