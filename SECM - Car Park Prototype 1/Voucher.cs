using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM___Car_Park_Prototype_1
{
    class Voucher
    {
        private string voucherCode;
        private double value;

        public Voucher(string code, double credit)
        {
            voucherCode = code;
            value = credit;
        }
    }
}
