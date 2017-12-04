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
    public partial class enterPark : Form
    {
        CarPark _carPark;
        List<CarParkDB> _cpPanels;
        Customer selectedCustomer;
        Label _spaces;
        int index;
        public enterPark(CarPark carPark, List<CarParkDB> cpPanels, Label spaces)
        {
            InitializeComponent();
            _carPark = carPark;
            _cpPanels = cpPanels;
            _spaces = spaces;
            FPrintScan.Enabled = false;
            enterCP.Enabled = false;
            for (int i = 0; i < _carPark.getNoOfActCusts(); i++)
            {
                custListItems item = new custListItems();
                item.Name = _carPark.getActiveCustList()[i].getName();
                item.custObj = _carPark.getActiveCustList()[i];
                custList.Items.Add(item);
            }
        }
        private void custList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = (custList.SelectedItem as custListItems).custObj;
            FPrintScan.Enabled = true;
        }
        private void FPrintScan_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            int i = 0;
            while (!isFound)
            {
                if (selectedCustomer.getName() == _carPark.getActiveCustList()[i].getName())
                {
                    if (_carPark.getActiveCustList()[i].getAccount() == null)
                    {
                        entryBarrierText.Text = "As a non-registered customer, use the dispensed chip-coin to make payments at the Payment Machine.";
                    }
                    else
                    {
                        entryBarrierText.Text = "FPrint account found. Tap-in successful. Please enter the Car Park.";
                    }
                    isFound = true;
                    index = allocateBay(selectedCustomer.getName());
                    while (_cpPanels[getLevel()].getStatus(index % _carPark.getLVCap()) != "Available")
                    {
                        index = linearProbing(index);
                    }

                    bayAllocator.Text = "Your allocated Parking Bay is No. #" + (_cpPanels[getLevel()].getBayNo(index % _carPark.getLVCap())) + ".";

                    double loadFactor = ((double)_carPark.getNoOfVisitors() / (double)_carPark.getCPCap());
                    if (loadFactor >= 0.7 && _carPark.getUnlockedLevels() < _carPark.getLevels())
                    {
                        MessageBox.Show("Load factor reached: " + loadFactor + ". Array will be resized.");
                        _carPark.setParkingLot();
                        for(int j = 0; j < _carPark.getLVCap(); j++)
                        {
                            _cpPanels[_carPark.getUnlockedLevels()].setStatus(j, "Available");
                        }
                        _carPark.setCPCap(1);
                    } // increase the array size once the load factor has been reached or exceeded
                }
                else
                {
                    i++;
                }
            }
            custList.Enabled = false;
            raised.Checked = true;
            FPrintScan.Enabled = false;
            enterCP.Enabled = true;
        }

        private void enterCP_Click(object sender, EventArgs e)
        {
            _cpPanels[getLevel()].updateCPstatus(index % _carPark.getLVCap(), selectedCustomer.getName(), (index + 1), "Entered");
            _carPark.setNoOfVisitors(1);
            custList.Enabled = true;
            lowered.Checked = true;
            enterCP.Enabled = false;
            entryBarrierText.Text = bayAllocator.Text = custList.Text = "";
            custList.Items.Remove(custList.SelectedItem);
            _carPark.setNoOfCustomers(-1);
            _carPark.setOccupiedSpaces(1);
            _spaces.Text = _carPark.getAvailableSpaces().ToString();
        }

        private int allocateBay(string key)
        {
            // initialise the hash value to 0
            int hash = 0;
            foreach (char ascii in key)
            {
                hash += ascii;
            } // increment the hash value by the ascii values of each letter of the key
            return hash % _carPark.getLVCap();
        } // perform modular arithmetic on the hash value to return the index

        public int linearProbing(int index)
        {
            return (index + 1) % _carPark.getLVCap();
        }

        public int getLevel()
        {
            for(int i = 0; i < _carPark.getLevels(); i++)
            {
                for(int j = 0; j < _carPark.getLVCap(); j++)
                {
                    if(_cpPanels[i].getStatus(j) == "Available")
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private void enterPark_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Customer> newList = new List<Customer>();
            for (int i = 0; i < custList.Items.Count; i++)
            {
                newList.Add((custList.Items[i] as custListItems).custObj);
            }
            _carPark.setActCustList(newList);
        }
    }
}
