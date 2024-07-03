using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = new Car();
            IVehicle motorcycle = new MotorCycle();

            Driver driver = new Driver(car);
            driver.Drive();

            driver = new Driver(motorcycle);
            driver.Drive();
        }
    }
}
