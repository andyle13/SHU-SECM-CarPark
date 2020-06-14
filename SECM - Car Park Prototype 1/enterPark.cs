using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class EnterPark : Form
    {
        CarPark _carPark;
        List<CarParkDB> _cpPanels;
        Customer selectedCustomer;
        Label _spaces, _custNo;
        DateTime _dateTime;
        int _skipHour, index;

        public EnterPark(CarPark carPark, List<CarParkDB> cpPanels, Label spaces, Label custNo, DateTime dateTime, int skipHour)
        {
            InitializeComponent();
            _carPark = carPark;
            _cpPanels = cpPanels;
            _spaces = spaces;
            _custNo = custNo;
            _dateTime = dateTime;
            _skipHour = skipHour;
            raised.Checked = (!_carPark.GetEmergency()) ? false : true;
            timer1.Start();
            for (int i = 0; i < _carPark.GetNoOfActCusts(); i++)
            {
                if (_carPark.GetActiveCustList()[i].GetLocked() == false)
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
            FPrintScan.Enabled = (!_carPark.GetEmergency()) ? true : false;
            if (_carPark.GetEmergency()) enterCP.Enabled = true;
        }
        private void FPrintScan_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            int i = 0;
            while (!isFound)
            {
                if (selectedCustomer.GetName() == _carPark.GetActiveCustList()[i].GetName())
                {
                    if (_carPark.GetActiveCustList()[i].GetAccount() == null)
                    {
                        entryBarrierText.Text = "As a non-registered customer, use the dispensed chip-coin to make payments at the Payment Machine.";
                        selectedCustomer.SetChipCoin(true);
                    }
                    else
                    {
                        entryBarrierText.Text = "Tap-in successful. Please enter the Car Park.";
                        if(selectedCustomer.GetVoucher() != null && selectedCustomer.GetAccount().GetPayStyle() == "PAYP")
                        {
                            entryBarrierText.Text =  "Tap-in successful. Please enter the Car Park. Your Voucher has been credited towards your FPrint Balance.";
                            selectedCustomer.GetAccount().SetBalance(selectedCustomer.GetVoucher().GetValue());
                            selectedCustomer.SetVoucher(null);
                        }
                    }

                    isFound = true;
                    BayAllocation();
                    bayAllocator.Text = "Your allocated Parking Bay is No. #" + (_cpPanels[getLevel()].GetBayNo(index % _carPark.GetLVCap())) + ".";
                }
                else
                    i++;
            }
            custList.Enabled = false;
            raised.Checked = true;
            FPrintScan.Enabled = false;
            enterCP.Enabled = true;
        }

        private void enterCP_Click(object sender, EventArgs e)
        {
            BayAllocation();
            _cpPanels[getLevel()].UpdateCPstatus(index % _carPark.GetLVCap(), selectedCustomer.GetName(), (index + 1), "Reserved");
            custList.Enabled = true;
            lowered.Checked = (!_carPark.GetEmergency()) ? true : false;
            enterCP.Enabled = false;
            selectedCustomer.SetEntryTime(_dateTime);
            _carPark.AddCPVisitors(selectedCustomer);
            _carPark.RemoveActCustVisitor(selectedCustomer);
            custList.Items.Remove(custList.SelectedItem);
            entryBarrierText.Text = bayAllocator.Text = custList.Text = "";
            _carPark.SetNoOfVisitors(1);
            _carPark.SetOccupiedSpaces(1);
            _carPark.SetNoOfCustomers(-1);
            _spaces.Text = _carPark.GetAvailableSpaces().ToString();
            _custNo.Text = _carPark.GetNoOfActCusts().ToString();

            if (custList.Items.Count == 0)
                this.Close();
        }

        private int allocateBay(string key)
        {
            // initialise the hash value to 0
            int hash = 0;
            foreach (char ascii in key)
            {
                hash += ascii;
            } // increment the hash value by the ascii values of each letter of the key
            return hash % _carPark.GetLVCap();
        } // perform modular arithmetic on the hash value to return the index

        public int linearProbing(int index)
        {
            return (index + 1) % _carPark.GetLVCap();
        }

        public int getLevel()
        {
            for(int i = 0; i < _carPark.GetLevels(); i++)
            {
                for(int j = 0; j < _carPark.GetLVCap(); j++)
                {
                    if(_cpPanels[i].GetStatus(j) == "Available")
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _dateTime = DateTime.Now.AddHours(_skipHour);
        }

        private void BayAllocation()
        {
            index = allocateBay(selectedCustomer.GetName());
            while (_cpPanels[getLevel()].GetStatus(index % _carPark.GetLVCap()) != "Available")
                index = linearProbing(index);
            
            double loadFactor = ((double)_carPark.GetNoOfVisitors() / (double)_carPark.GetCPCap());
            if (loadFactor >= 0.7 && _carPark.GetUnlockedLevels() < _carPark.GetLevels())
            {
                MessageBox.Show("Load factor reached: " + loadFactor + ". Array will be resized.");
                _carPark.SetParkingLot();
                for (int j = 0; j < _carPark.GetLVCap(); j++)
                    _cpPanels[_carPark.GetUnlockedLevels()].SetStatus(j, "Available");

                _carPark.SetCPCap(1);
            } // increase the array size once the load factor has been reached or exceeded
        }
    }
}
