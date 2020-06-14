using System;
using System.Drawing;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class UpdateCustomer : Form
    {
        private CarPark _carPark;
        private Customer selectedCustomer;
        private string cID = null;
        private double currentBalance, cBalance = 0;
        private string cIncentive = null;
        private bool cPAYP = false, payStyleChecked = false, incentivesChecked = false;

        public UpdateCustomer(CarPark carPark)
        {
            InitializeComponent();
            _carPark = carPark;
            for (int i = 0; i < _carPark.GetNoOfActCusts(); i++)
            {
                CustListItems item = new CustListItems();
                item.Name = _carPark.GetActiveCustList()[i].GetName();
                item.custObj = _carPark.GetActiveCustList()[i];
                custList.Items.Add(item);
            }
        }
        private void CustList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = (custList.SelectedItem as CustListItems).custObj;

            // Display financial details
            currentBalance = selectedCustomer.GetBalance();
            AccBalance_lbl.Text = selectedCustomer.GetBalance().ToString();
            if (selectedCustomer.GetAccount() != null)
                FPrintBalance_lbl.Text = selectedCustomer.GetAccount().GetBalance().ToString();
            Debt_lbl.Text = selectedCustomer.GetDebt().ToString();

            // Determine Update button status
            YesID.Checked = (selectedCustomer.GetAccount() != null) ? true : false;
            NoID.Checked = (selectedCustomer.GetAccount() != null) ? false : true;
            if (NoID.Checked) Update.Enabled = true;

            // Determine FPrint Account panel status
            FPrintDesc_lbl.Enabled = (selectedCustomer.GetAccount() != null) ? false : true;
            CName.Enabled = (selectedCustomer.GetAccount() != null) ? false : true;
            YesID.Enabled = (selectedCustomer.GetAccount() != null) ? false : true;
            NoID.Enabled = (selectedCustomer.GetAccount() != null) ? false : true;
            regForm.Enabled = true;
        }
        private void Balance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Balance_Enter(object sender, EventArgs e)
        {
            if (Balance.Text == "0")
            {
                Balance.Text = "";
                Balance.ForeColor = Color.Black;
            }
        }
        private void Balance_Leave(object sender, EventArgs e)
        {
            if (Balance.Text == "")
            {
                Balance.Text = "0";
                Balance.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void Balance_TextChanged(object sender, EventArgs e)
        {
            cBalance = (Balance.Text != "") ? double.Parse(Balance.Text) : 0;
        }

        private void YesID_CheckedChanged(object sender, EventArgs e)
        {
            Name_lbl.Enabled = true;
            CName.Enabled = true;
            PayStyle.Enabled = true;
            Incentives.Enabled = true;
            Update.Enabled = false;
        }
        private void NoID_CheckedChanged(object sender, EventArgs e)
        {
            Name_lbl.Enabled = false;
            CName.Enabled = false;
            PayStyle.Enabled = false;
            Incentives.Enabled = false;
            Update.Enabled = true;
        }
        private void CName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CName_TextChanged(object sender, EventArgs e)
        {
            cID = CName.Text;
            UnlockSubmit();
        }
        private void Payp_CheckedChanged(object sender, EventArgs e)
        {
            cPAYP = true;
            payStyleChecked = true;
            UnlockSubmit();
        }
        private void DirectDebit_CheckedChanged(object sender, EventArgs e)
        {
            cPAYP = false;
            payStyleChecked = true;
            UnlockSubmit();
        }
        private void Standard_CheckedChanged(object sender, EventArgs e)
        {
            cIncentive = "Standard Visitor";
            incentivesChecked = true;
            UnlockSubmit();
        }
        private void CpEmp_CheckedChanged(object sender, EventArgs e)
        {
            cIncentive = "Car Park Employee";
            incentivesChecked = true;
            UnlockSubmit();
        }
        private void Student_CheckedChanged(object sender, EventArgs e)
        {
            cIncentive = "Student";
            incentivesChecked = true;
            UnlockSubmit();
        }
        private void CoopEmp_CheckedChanged(object sender, EventArgs e)
        {
            cIncentive = "Partner Employee";
            incentivesChecked = true;
            UnlockSubmit();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (selectedCustomer.GetName() != _carPark.GetActiveCustList()[i].GetName())
                i++;

            if (selectedCustomer.GetAccount() != null)
            {
                _carPark.GetActiveCustList()[i].SetBalance(cBalance);
                _carPark.GetActiveCustList()[i].SetBalance(_carPark.GetActiveCustList()[i].GetAccount().GetBalance());
                _carPark.GetActiveCustList()[i].GetAccount().NullBalance();
                _carPark.GetActiveCustList()[i].GetAccount().SetPayStyle(cPAYP);
                _carPark.GetActiveCustList()[i].GetAccount().SetIncentive(cIncentive);
                MessageBox.Show(selectedCustomer.GetName() + "'s updated balance is: " + selectedCustomer.GetBalance() + " GBP"
                                + "\nUpdated Payment mode: " + selectedCustomer.GetAccount().GetPayStyle()
                                + "\nUpdated Discount mode: " + selectedCustomer.GetAccount().GetIncentiveType());
            }
            else
            {
                if(YesID.Checked == true)
                {
                    _carPark.GetActiveCustList()[i].SetName(cID);
                    _carPark.GetActiveCustList()[i].SetBalance(cBalance - 5);
                    _carPark.GetActiveCustList()[i].SetFPrintAcc(new FPrintAcc(5, cPAYP, cIncentive));
                    MessageBox.Show("Thank you for registering with us " + selectedCustomer.GetName()
                                    + "\nYour current balance is: " + selectedCustomer.GetBalance() + " GBP"
                                    + "\nYour FPrint balance: " + selectedCustomer.GetAccount().GetBalance() + " GBP"
                                    + "\nYour Payment mode: " + selectedCustomer.GetAccount().GetPayStyle()
                                    + "\nYour Discount mode: " + selectedCustomer.GetAccount().GetIncentiveType());
                }
                else
                {
                    _carPark.GetActiveCustList()[i].SetBalance(cBalance);
                    MessageBox.Show("Customer No. " + selectedCustomer.GetName() + "'s updated balance is: " + selectedCustomer.GetBalance() + " GBP.");
                }
            }
            this.Close();
        }

        private void UnlockSubmit()
        {
            Update.Enabled = (cID != "" && payStyleChecked && incentivesChecked) ?
                true : false;
        }
    }
}
