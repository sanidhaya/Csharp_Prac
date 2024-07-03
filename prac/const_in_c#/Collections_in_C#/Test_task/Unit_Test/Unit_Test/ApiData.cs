using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test
{
    public class ApiData
    {
        public string Data {  get; set; }

        public ApiData() { }

        public override string ToString()
        {
            return($"The returned Data is : {Data}");
        }
    }
}
