﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM___Car_Park_Prototype_1
{
    class VoucherListItems
    {

        public string Name { get; set; }
        public double Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
