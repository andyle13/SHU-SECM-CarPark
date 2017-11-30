using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SECM___Car_Park_Prototype_1
{
    public class FPrintAcc
    {
        private double balance;
        private string incentive;
        private bool isPAYP;

        public FPrintAcc(double balance, bool isPAYP, string incentive)
        {
            this.balance = balance;
            this.isPAYP = isPAYP;
            this.incentive = incentive;
        }

        public double getBalance()
        {
            return balance;
        }

        public string getPayStyle()
        {
            return (isPAYP) ? "PAYP" : "Direct Debit";
        }

        public string getIncentiveType()
        {
            return incentive;
        }

        public double getAccBalance()
        {
            return balance;
        }
    }
}
