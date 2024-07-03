using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Starting car");
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerating Car");
        }

        public void Stop()
        {
            Console.WriteLine("Stop car");
        }
    }
}
