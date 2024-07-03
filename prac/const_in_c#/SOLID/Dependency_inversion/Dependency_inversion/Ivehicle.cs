using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion
{
    public interface IVehicle
    {
        void Start();
        void Accelerate();
        void Stop();
    }
}
