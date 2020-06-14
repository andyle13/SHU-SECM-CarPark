using System;

namespace SECM___Car_Park_Prototype_1
{
    public class Customer
    {
        private string name, password;
        private double balance, debt;
        private bool chipCoin;
        private FPrintAcc fingerprint;
        private Voucher voucher;
        private DateTime entryTime;
        private bool isLocked;

        public Customer(string name, double balance, FPrintAcc fingerprint)
        {
            this.name = name;
            this.balance = balance;
            this.fingerprint = fingerprint;
            isLocked = false;
            voucher = null;
            debt = 0;
        }

        public string GetName()
        {
            return name;
        }

        public double GetBalance()
        {
            return balance;
        }

        public double GetDebt()
        {
            return debt;
        }

        public bool GetChipCoin()
        {
            return chipCoin;
        }

        public FPrintAcc GetAccount()
        {
            return fingerprint;
        }

        public DateTime GetEntryTime()
        {
            return entryTime;
        }
        public bool GetLocked()
        {
            return isLocked;
        }
        public string GetPassword()
        {
            return password;
        }
        public Voucher GetVoucher()
        {
            return voucher;
        }
        public void SetVoucher(Voucher voucher)
        {
            this.voucher = voucher;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetEntryTime(DateTime entryTime)
        {
            this.entryTime = entryTime;
        }

        public void SetChipCoin(bool chipCoin)
        {
            this.chipCoin = chipCoin;
        }

        public void SetBalance(double balance)
        {
            this.balance += balance;
        }

        public void NullBalance()
        {
            this.balance = 0;
        }
        public void SetDebt(double debt)
        {
            this.debt = Math.Round(-1 * debt - (debt * 0.3), 2);
        }
        public void SetFPrintAcc(FPrintAcc fingerprint)
        {
            this.fingerprint = fingerprint;
        }

        public void SetLocked(bool isLocked)
        {
            this.isLocked = isLocked;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
    }
}
