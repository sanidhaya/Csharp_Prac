using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    public class MotorCycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Starting motorcycle");
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerating motorcycle");
        }

        public void Stop()
        {
            Console.WriteLine("Stop motorcycle");
        }
    }
}
