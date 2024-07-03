using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Singlet
    {
        private Singlet() { }

        private static Singlet _instance = null;

        public static Singlet Instance() {
            if (_instance == null) {
                return new Singlet();
            }

            return _instance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
