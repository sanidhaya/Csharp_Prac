using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GreaterThanMaxPossibleException : Exception
    {
        public GreaterThanMaxPossibleException(){}

        public GreaterThanMaxPossibleException(string message) : base(message) { }
    }
}
