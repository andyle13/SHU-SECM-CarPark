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
    public partial class newCustomer : Form
    {
        private CarPark _carPark;
        private string cID = null;
        private double cBalance = 0;
        private string cIncentive = null;
        private bool cPAYP, payStyleChecked, incentivesChecked = false;
        public newCustomer(CarPark carPark)
        {
            InitializeComponent();
            _carPark = carPark;
        }

        private void newCustomer_Load(object sender, EventArgs e)
        {
            submit.Enabled = false;
            regForm.Enabled = false;
        }
        private void fBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void fBalance_Enter(object sender, EventArgs e)
        {
            if (fBalance.Text == "0")
            {
                fBalance.Text = "";
                fBalance.ForeColor = Color.Black;
            }
        }
        private void fBalance_Leave(object sender, EventArgs e)
        {
            if (fBalance.Text == "")
            {
                fBalance.Text = "0";
                fBalance.ForeColor = SystemColors.InactiveCaption;
            }
        }
        private void cName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void fBalance_TextChanged(object sender, EventArgs e)
        {
            cBalance = (fBalance.Text != "") ? double.Parse(fBalance.Text) : 0;

            if (!regForm.Enabled && cBalance != 0)
                submit.Enabled = true;
            else
                unlockSubmit();
        }
        private void yesID_CheckedChanged(object sender, EventArgs e)
        {
            regForm.Enabled = true;
            submit.Text = "Register";
            unlockSubmit();
        }
        private void noID_CheckedChanged(object sender, EventArgs e)
        {
            submit.Text = "Submit";
            regForm.Enabled = false;
            if (!regForm.Enabled && cBalance != 0)
                submit.Enabled = true;
        }
        private void cName_TextChanged(object sender, EventArgs e)
        {
            cID = cName.Text;
            unlockSubmit();
        }
        private void payp_CheckedChanged(object sender, EventArgs e)
        {
            cPAYP = true;
            payStyleChecked = true;
            unlockSubmit();
        }
        private void dDebit_CheckedChanged(object sender, EventArgs e)
        {
            cPAYP = false;
            payStyleChecked = true;
            unlockSubmit();
        }
        private void standard_CheckedChanged(object sender, EventArgs e)
        {
            cIncentive = "Standard Visitor";
            incentivesChecked = true;
            unlockSubmit();
        }
        private void cpEmp_CheckedChanged(object sender, EventArgs e)
        {
            cIncentive = "Car Park Employee";
            incentivesChecked = true;
            unlockSubmit();
        }
        private void student_CheckedChanged(object sender, EventArgs e)
        {
            cIncentive = "Student";
            incentivesChecked = true;
            unlockSubmit();
        }
        private void coopEmp_CheckedChanged(object sender, EventArgs e)
        {
            cIncentive = "Partner Employee";
            incentivesChecked = true;
            unlockSubmit();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if(noID.Checked == true)
                cID = "Customer No. " + new Random().Next(1, 9999).ToString();

            Customer newCust = (yesID.Checked == true) ?
                new Customer(cID, cBalance * 0.8, new FPrintAcc(cBalance * 0.2, cPAYP, cIncentive)) : 
                new Customer(cID, cBalance, null);

            _carPark.addActiveCustomer(newCust);
            
            if(yesID.Checked == true)
                MessageBox.Show("Thank you for registering with us " + newCust.getName()
                    + "\nYour current balance is: " + newCust.getBalance() 
                    + "\nYour FPrint balance: " + newCust.getAccount().getAccBalance()
                    + "\nYour Payment mode: " + newCust.getAccount().getPayStyle()
                    + "\nYour Discount mode: " + newCust.getAccount().getIncentiveType());
            else
                MessageBox.Show("Welcome " + newCust.getName() + "\nYour current balance is: " + newCust.getBalance());

            this.Close();
        }

        private void unlockSubmit()
        {
            submit.Enabled = (cID != "" && cBalance != 0 && payStyleChecked && incentivesChecked) ?
                true : false;
        }
    }
}
