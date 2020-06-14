namespace SECM___Car_Park_Prototype_1
{
    public class Voucher
    {
        private string voucherCode;
        private double value;

        public Voucher(string code, double credit)
        {
            voucherCode = code;
            value = credit;
        }

        public string GetVoucherCode()
        {
            return voucherCode;
        }

        public double GetValue()
        {
            return value;
        }
    }
}
