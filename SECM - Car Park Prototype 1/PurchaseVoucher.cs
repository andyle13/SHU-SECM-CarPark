using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class PurchaseVoucher : Form
    {
        private CarPark _carPark;
        private Customer selectedCustomer;
        private string[] gbpvalue = { "5 GBP", "10 GBP", "20 GBP", "50 GBP", "100 GBP" };
        private double[] vouchervalue = { 5, 10, 20, 50, 100 };
        private double selectedValue;

        public PurchaseVoucher(CarPark carPark)
        {
            InitializeComponent();
            _carPark = carPark;
            
            for (int i = 0; i < _carPark.GetNoOfActCusts(); i++)
            {
                if (_carPark.GetActiveCustList()[i].GetVoucher() == null)
                {
                    CustListItems item = new CustListItems();
                    item.Name = _carPark.GetActiveCustList()[i].GetName();
                    item.custObj = _carPark.GetActiveCustList()[i];
                    custList.Items.Add(item);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                VoucherListItems voucher = new VoucherListItems();
                voucher.Name = gbpvalue[i];
                voucher.Value = vouchervalue[i];
                VoucherList.Items.Add(voucher);
            }
        }

        private void custList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = (custList.SelectedItem as CustListItems).custObj;
            buyVoucher.Enabled = isSelected();
        }

        private void VoucherList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = (VoucherList.SelectedItem as VoucherListItems).Value;
            buyVoucher.Enabled = isSelected();
        }

        private void buyVoucher_Click(object sender, EventArgs e)
        {
            string input;
            int i = 0;
            while (selectedCustomer.GetName() != _carPark.GetActiveCustList()[i].GetName())
                i++;

            input = Interaction.InputBox("Please pay for your voucher.", "Make Payment", selectedValue.ToString());
            if (input.Length > 0 && Convert.ToDouble(input) == selectedValue && selectedCustomer.GetBalance() > selectedValue)
            {
                Double paid = Convert.ToDouble(input);
                Math.Round(paid, 2);
                int lengthOfVoucher = 10;
                List<string> generatedVouchers = new List<string>();
                char[] keys = "ABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890".ToCharArray();
                string generatedCode = GenerateVoucher(keys, lengthOfVoucher);
                MessageBox.Show("Your order has been confirmed."
                    + "\nValue: " + selectedValue + " GBP"
                    + "\nCode: " + generatedCode);
                _carPark.GetActiveCustList()[i].SetBalance(-paid);
                _carPark.GetActiveCustList()[i].SetVoucher(new Voucher(generatedCode, selectedValue));
                custList.Items.Remove(custList.SelectedItem);
                custList.Text = "";
                buyVoucher.Enabled = isSelected();
                if (custList.Items.Count == 0)
                    this.Close();
            }
            else
            {
                MessageBox.Show("Insufficient Balance. Purchase aborted.");
            }
        }

        private string GenerateVoucher(char[] keys, int lengthOfVoucher)
        {
            Random random = new Random();
            return Enumerable
                .Range(1, lengthOfVoucher) // for(i.. ) 
                .Select(k => keys[random.Next(0, keys.Length - 1)])  // generate a new random char 
                .Aggregate("", (e, c) => e + c); // join into a string
        }

        private bool isSelected()
        {
            return (custList.SelectedItem != null && VoucherList.SelectedItem != null) ? true : false;
        }
    }
}
