using System;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class DirectDebit : Form
    {
        private CarPark _carPark;
        private Customer selectedCustomer;
        public DirectDebit(CarPark carPark)
        {
            InitializeComponent();
            _carPark = carPark;
            for (int i = 0; i < _carPark.GetNoOfActCusts(); i++)
            {
                if (_carPark.GetActiveCustList()[i].GetAccount() != null
                    && _carPark.GetActiveCustList()[i].GetAccount().GetPayStyle() == "Direct Debit")
                {
                    CustListItems item = new CustListItems();
                    item.Name = _carPark.GetActiveCustList()[i].GetName();
                    item.custObj = _carPark.GetActiveCustList()[i];
                    custList.Items.Add(item);
                }
            }
        }

        private void custList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = (custList.SelectedItem as CustListItems).custObj;
            debit_btn.Enabled = true;
        }

        private void debit_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (selectedCustomer.GetName() != _carPark.GetActiveCustList()[i].GetName())
                i++;

            _carPark.GetActiveCustList()[i].SetBalance(-_carPark.GetActiveCustList()[i].GetAccount().GetBalance());
            _carPark.GetActiveCustList()[i].GetAccount().NullBalance();

            MessageBox.Show("Sending a message to " + selectedCustomer.GetName() + "'s FPrint Account..."
                            + "\nYour current balance is: " + selectedCustomer.GetBalance() + " GBP"
                            + "\nYour FPrint balance: " + selectedCustomer.GetAccount().GetBalance() + " GBP");

            if (_carPark.GetActiveCustList()[i].GetBalance() < 0)
            {
                _carPark.GetActiveCustList()[i].SetLocked(true);
                _carPark.GetActiveCustList()[i].SetDebt(_carPark.GetActiveCustList()[i].GetBalance());
                _carPark.GetActiveCustList()[i].NullBalance();
                MessageBox.Show("Sending a warning to " + selectedCustomer.GetName() + "'s FPrint Account..."
                                + "\nDue to insufficient funds in your bank account,"
                                + "\nwe have partially charged and put you in debt with"
                                + "\na sum of " + _carPark.GetActiveCustList()[i].GetDebt() + " GBP. Simultaneously, your account"
                                + "\nhas been locked until you have paid off your"
                                + "\ndebts.");
            }
            custList.Items.Remove(custList.SelectedItem);
            if (custList.Items.Count == 0)
                this.Close();
        }
    }
}
