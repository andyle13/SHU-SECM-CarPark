using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM___Car_Park_Prototype_1
{
    public class Customer
    {
        private string name;
        private double balance;
        private FPrintAcc fingerprint;

        public Customer(string name, double balance, FPrintAcc fingerprint)
        {
            this.name = name;
            this.balance = balance;
            this.fingerprint = fingerprint;
        }

        public string getName()
        {
            return name;
        }

        public double getBalance()
        {
            return balance;
        }

        public FPrintAcc getAccount()
        {
            return fingerprint;
        }
    }
}
