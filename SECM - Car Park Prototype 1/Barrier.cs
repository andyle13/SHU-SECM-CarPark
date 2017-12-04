using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM___Car_Park_Prototype_1
{
    class Barrier
    {   
        private bool lifted;

        // Constructor
        public Barrier()
        {}

        public void Lower()
        {
            lifted = false;
        }

        public void Raise()
        {
            lifted = true;
        }

        public bool IsLifted()
        {
            return lifted;
        }
    }
}
