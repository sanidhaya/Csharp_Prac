using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    public class Driver
    {
        private IVehicle vehicle;

        public Driver(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Drive()
        {
            vehicle.Start();
            vehicle.Accelerate();
            vehicle.Stop();
        }
    }
}
