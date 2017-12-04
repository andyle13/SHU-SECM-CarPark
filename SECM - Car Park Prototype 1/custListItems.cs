using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM___Car_Park_Prototype_1
{
    class custListItems
    {
        public string Name { get; set; }
        public Customer custObj { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
