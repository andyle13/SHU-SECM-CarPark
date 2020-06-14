using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Microsoft.VisualBasic;
using System.IO;

namespace SECM___Car_Park_Prototype_1
{
    public partial class ParkingBay : Form
    {
        CarPark _carPark;
        List<CarParkDB> _cpPanels;
        CustListItems selectedCustomer;
        private bool DeviceExist = false, isCorrect;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        public ParkingBay(CarPark carPark, List<CarParkDB> cpPanels)
        {
            InitializeComponent();
            DetectWebcam();
            _carPark = carPark;
            _cpPanels = cpPanels;
            for (int i = 0; i < _carPark.GetLevels(); i++)
            {
                for (int j = 0; j < _carPark.GetLVCap(); j++)
                {
                    if (_cpPanels[i].GetStatus(j) == "Reserved" ||
                        _cpPanels[i].GetStatus(j) == "Occupied" ||
                        _cpPanels[i].GetStatus(j) == "Occupied (Secured)" ||
                        _cpPanels[i].GetStatus(j) == "Paid")
                    {
                        CustListItems item = new CustListItems
                        {
                            Level = i,
                            BayIndex = j,
                            Name = _cpPanels[i].GetCustName(j),
                            BayNo = _cpPanels[i].GetBayNo(j)
                        };
                        custList.Items.Add(item);
                    }
                }
            }
        }

        private void custList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = custList.SelectedItem as CustListItems;
            switch (_cpPanels[selectedCustomer.Level].GetStatus(selectedCustomer.BayIndex))
            {
                case "Reserved":
                    park_btn.Enabled = true;
                    lock_btn.Enabled = false;
                    park_btn.Text = "Park";
                    lock_btn.Text = "Secure Parking";
                    break;
                case "Occupied":
                    park_btn.Enabled = true;
                    lock_btn.Enabled = true;
                    park_btn.Text = "Leave Bay";
                    lock_btn.Text = "Secure Parking";
                    break;
                case "Occupied (Secured)":
                    park_btn.Enabled = false;
                    lock_btn.Enabled = true;
                    park_btn.Text = "Park";
                    lock_btn.Text = "Revoke Security";
                    break;
                case "Paid":
                    park_btn.Enabled = true;
                    lock_btn.Enabled = false;
                    park_btn.Text = "Leave Bay";
                    lock_btn.Text = "Secure Parking";
                    break;
                default:
                    break;
            }
        }

        private void park_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (selectedCustomer.Name != _carPark.GetCPVisitor()[i].GetName())
                i++;

            if (_carPark.GetCPVisitor()[i].GetAccount() != null || _cpPanels[selectedCustomer.Level].GetStatus(selectedCustomer.BayIndex) != "Occupied")
            {
                switch (_cpPanels[selectedCustomer.Level].GetStatus(selectedCustomer.BayIndex))
                {
                    case "Reserved":
                        _cpPanels[selectedCustomer.Level].SetStatus(selectedCustomer.BayIndex, "Occupied");
                        park_btn.Text = "Leave Bay";
                        lock_btn.Enabled = true;
                        _carPark.SetNoOfParkCust(1);
                        break;
                    case "Occupied":
                        _cpPanels[selectedCustomer.Level].SetStatus(selectedCustomer.BayIndex, "Awaiting Exit");
                        custList.Items.Remove(custList.SelectedItem);
                        park_btn.Text = "Park";
                        lock_btn.Enabled = false;
                        park_btn.Enabled = false;
                        _carPark.SetNoOfExitCust(1);
                        _carPark.SetNoOfParkCust(-1);
                        _carPark.SetNoOfVisitors(-1);
                        if (custList.Items.Count == 0)
                            this.Close();
                        break;
                    case "Paid":
                        if (_carPark.GetCPVisitor()[i].GetPassword() != null)
                        {
                            string password = null;
                            if (Interaction.InputBox("Open the garage using your Password:", "Secure Parking", password) == _carPark.GetCPVisitor()[i].GetPassword())
                            {
                                isCorrect = true;
                                _carPark.GetCPVisitor()[i].SetPassword(null);
                            }
                            else
                                isCorrect = false;
                        }
                        else
                            isCorrect = true;
                        if (isCorrect)
                        {
                            _cpPanels[selectedCustomer.Level].SetStatus(selectedCustomer.BayIndex, "Awaiting Exit");
                            custList.Items.Remove(custList.SelectedItem);
                            park_btn.Text = "Park";
                            lock_btn.Enabled = false;
                            park_btn.Enabled = false;
                            _carPark.SetNoOfExitCust(1);
                            _carPark.SetNoOfParkCust(-1);
                            _carPark.SetNoOfVisitors(-1);
                            if (custList.Items.Count == 0)
                                this.Close();
                        }
                        break;
                    default:
                        break;
                }
            }
            else
                MessageBox.Show("Please pay at the Payment Machine before you leave the car park.");
        }

        private void lock_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (selectedCustomer.Name != _carPark.GetCPVisitor()[i].GetName())
                i++;

            if (_carPark.GetCPVisitor()[i].GetAccount() != null || _cpPanels[selectedCustomer.Level].GetStatus(selectedCustomer.BayIndex) != "Occupied (Secured)")
            {
                string password = null;
                switch (_cpPanels[selectedCustomer.Level].GetStatus(selectedCustomer.BayIndex))
                {
                    case "Occupied":
                        if (DeviceExist == true && _carPark.GetCPVisitor()[i].GetAccount() != null)
                        {
                            FaceID facescan = new FaceID(_carPark, _cpPanels, _carPark.GetCPVisitor()[i], this);
                            facescan.ShowDialog();
                        }
                        else
                        {
                            password = Interaction.InputBox("Secure your car with a Password:", "Secure Parking", password);
                            if (password.Length > 0)
                            {
                                _carPark.GetCPVisitor()[i].SetPassword(password);
                                isCorrect = true;
                            }
                        }
                        if (isCorrect)
                        {
                            _cpPanels[selectedCustomer.Level].SetStatus(selectedCustomer.BayIndex, "Occupied (Secured)");
                            park_btn.Enabled = false;
                            lock_btn.Text = "Revoke Security";
                            park_btn.Text = "Park";
                            isCorrect = false;
                        }
                        break;
                    case "Occupied (Secured)":
                        if (DeviceExist == true && _carPark.GetCPVisitor()[i].GetAccount() != null)
                        {
                            FacialRecognition facescan = new FacialRecognition(_carPark, _cpPanels, _carPark.GetCPVisitor()[i], this);
                            facescan.ShowDialog();
                        }
                        else
                        {
                            if (Interaction.InputBox("Open the garage using your Password:", "Secure Parking", password) == _carPark.GetCPVisitor()[i].GetPassword())
                            {
                                isCorrect = true;
                                _carPark.GetCPVisitor()[i].SetPassword(null);
                            }
                            else
                                isCorrect = false;
                        }
                        if (isCorrect)
                        {
                            _cpPanels[selectedCustomer.Level].SetStatus(selectedCustomer.BayIndex, "Awaiting Exit");
                            lock_btn.Text = "Secure Parking";
                            park_btn.Text = "Park";
                            lock_btn.Enabled = false;
                            park_btn.Enabled = false;
                            custList.Items.Remove(custList.SelectedItem);
                            _carPark.SetNoOfExitCust(1);
                            _carPark.SetNoOfParkCust(-1);
                            _carPark.SetNoOfVisitors(-1);
                            isCorrect = false;
                            if (custList.Items.Count == 0)
                                this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Revoking parking bay security failed.");
                        }
                        break;
                    default:
                        break;
                }
            }
            else
                MessageBox.Show("Please pay at the Payment Machine before you leave the car park.");
        }

        private void DetectWebcam()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
            }
        }

        public void IsCorrectCam()
        {
            isCorrect = true;
        }
    }
}
