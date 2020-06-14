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

        public double GetBalance()
        {
            return balance;
        }

        public string GetPayStyle()
        {
            return (isPAYP) ? "PAYP" : "Direct Debit";
        }

        public string GetIncentiveType()
        {
            return incentive;
        }

        public void SetBalance(double balance)
        {
            this.balance += balance;
        }

        public void NullBalance()
        {
            this.balance = 0;
        }

        public void SetPayStyle(bool isPAYP)
        {
            this.isPAYP = isPAYP;
        }

        public void SetIncentive(string incentive)
        {
            this.incentive = incentive;
        }
    }
}
