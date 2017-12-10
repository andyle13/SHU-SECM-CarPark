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
    public partial class parkLock : Form
    {
        CarPark _carPark;
        List<CarParkDB> _cpPanels;
        custListItems selectedCustomer;
        public parkLock(CarPark carPark, List<CarParkDB> cpPanels)
        {
            InitializeComponent();
            _carPark = carPark;
            _cpPanels = cpPanels;
            for (int i = 0; i < _carPark.getLevels(); i++)
            {
                for (int j = 0; j < _carPark.getLVCap(); j++)
                {
                    if (_cpPanels[i].getStatus(j) == "Reserved" ||
                        _cpPanels[i].getStatus(j) == "Parked" ||
                        _cpPanels[i].getStatus(j) == "Occupied" ||
                        _cpPanels[i].getStatus(j) == "Occupied (Secured)")
                    {
                        custListItems item = new custListItems();
                        item.Level = i;
                        item.BayIndex = j;
                        item.Name = _cpPanels[i].getCustName(j);
                        item.BayNo = _cpPanels[i].getBayNo(j);
                        custList.Items.Add(item);
                    }
                }
            }
        }

        private void custList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = custList.SelectedItem as custListItems;
            switch (_cpPanels[selectedCustomer.Level].getStatus(selectedCustomer.BayIndex))
            {
                case "Reserved":
                    park_btn.Enabled = true;
                    break;
                case "Parked":
                    park_btn.Enabled = true;
                    break;
                case "Occupied":
                    lock_btn.Enabled = true;
                    break;
                case "Occupied (Secured)":
                    lock_btn.Enabled = true;
                    lock_btn.Text = "Unlock";
                    break;
                default:
                    break;
            }
        }

        private void park_btn_Click(object sender, EventArgs e)
        {
            _cpPanels[selectedCustomer.Level].updateCPstatus(selectedCustomer.BayIndex, selectedCustomer.Name, selectedCustomer.BayNo, "Occupied");
            if (_cpPanels[selectedCustomer.Level].getStatus(selectedCustomer.BayIndex) == "Occupied")
            {
                park_btn.Enabled = false;
                lock_btn.Enabled = true;
            }
        }

        private void lock_btn_Click(object sender, EventArgs e)
        {
            // check the customer object by FPrint Account
            switch (_cpPanels[selectedCustomer.Level].getStatus(selectedCustomer.BayIndex))
            {
                case "Occupied":
                    _cpPanels[selectedCustomer.Level].updateCPstatus(selectedCustomer.BayIndex, selectedCustomer.Name, selectedCustomer.BayNo, "Occupied (Secured)");
                    lock_btn.Text = "Unlock";
                    break;
                case "Occupied (Secured)":
                    _cpPanels[selectedCustomer.Level].updateCPstatus(selectedCustomer.BayIndex, selectedCustomer.Name, selectedCustomer.BayNo, "Awaiting Exit");
                    lock_btn.Text = "Lock";
                    lock_btn.Enabled = false;
                    park_btn.Enabled = true;
                    custList.Items.Remove(custList.SelectedItem);
                    if (custList.Items.Count == 0)
                        this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
