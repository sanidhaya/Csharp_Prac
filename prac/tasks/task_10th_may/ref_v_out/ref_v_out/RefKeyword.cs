using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_v_out
{
    internal class RefKeyword
    {
        public string GetNextName(ref int id)
        {
            string returnText = "Next - " + id.ToString();
            id += 1;
            return returnText;
        }
    }
}
