using System;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class RelieveDebt : Form
    {
        private CarPark _carPark;
        private Customer selectedCustomer;
        public RelieveDebt(CarPark carPark)
        {
            InitializeComponent();
            _carPark = carPark;
            for (int i = 0; i < _carPark.GetNoOfActCusts(); i++)
            {
                if (_carPark.GetActiveCustList()[i].GetLocked() == true)
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

            if (_carPark.GetActiveCustList()[i].GetBalance() < _carPark.GetActiveCustList()[i].GetDebt())
            {
                MessageBox.Show("Direct debit unsuccessful due to"
                                + "\ninsufficient balance.");
            }
            else
            {
                _carPark.GetActiveCustList()[i].SetLocked(false);
                _carPark.GetActiveCustList()[i].SetBalance(-_carPark.GetActiveCustList()[i].GetDebt());
                _carPark.GetActiveCustList()[i].SetDebt(0);
                MessageBox.Show("Direct debit successful. The customer"
                                + "\nhas been relieved from debt.");
                custList.Items.Remove(custList.SelectedItem);
                if (custList.Items.Count == 0)
                    this.Close();
            }
        }
    }
}
