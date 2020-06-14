using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    internal partial class ExitBarrierPanel : UserControl
    {
        CarPark _carPark;
        List<CarParkDB> _cpPanels;
        Label _spaces, _custNo;
        DateTime _currentTime;
        int _skipHour;
        double totalPrice;
        String exitMsg = "\nWe hope you enjoyed staying with us. Have a nice journey!";
        const double hourlyPrice = 2.50;
        public ExitBarrierPanel(CarPark carPark, List<CarParkDB> cpPanels, Label spaces, Label custNo, DateTime currentTime, int skipHour)
        {
            InitializeComponent();
            _carPark = carPark;
            _cpPanels = cpPanels;
            _spaces = spaces;
            _custNo = custNo;
            _currentTime = currentTime;
            _skipHour = skipHour;
            timer1.Start();
            FPrintScan.Enabled = (!_carPark.GetEmergency()) ? true : false;
            raised.Checked = (!_carPark.GetEmergency()) ? false : true;
        }

        public String getLabel()
        {
            return exitBarrierGroup.Text;
        }

        public void setLabel(int barrierNo)
        {
            exitBarrierGroup.Text = getLabel() + " " + barrierNo.ToString();
        }

        public void setQueuePosition(CustListItems queuedCustomer)
        {
            queue_list.Items.Add(queuedCustomer);
            EnableQueue();
        }

        public void EnableQueue()
        {
            if (queue_list.Items.Count > 0 && _carPark.GetEmergency()) exitCP.Enabled = true;
            exitBarrierGroup.Enabled = (queue_list.Items.Count > 0) ? true : false;
            FPrintScan.Enabled = (queue_list.Items.Count > 0 && !_carPark.GetEmergency()) ? true : false;
        }

        public bool IsQueueEmpty()
        {
            if (queue_list.Items.Count <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void exitCP_Click(object sender, EventArgs e)
        {
            // Locate customer
            int i = 0;
            CustListItems front = queue_list.Items[0] as CustListItems;
            while (front.Name != _carPark.GetCPVisitor()[i].GetName())
                i++;

            // Update barrier status
            lowered.Checked = (!_carPark.GetEmergency()) ? true : false;
            EnableQueue();

            // Update UI
            FPrintScan.Enabled = (!_carPark.GetEmergency()) ? true : false;
            queue_list.Items.Remove(queue_list.Items[0]);
            exitCP.Enabled = (queue_list.Items.Count > 0 && _carPark.GetEmergency()) ? true : false;

            // Update visitor statistics
            _carPark.SetOccupiedSpaces(-1);
            _carPark.SetNoOfExitCust(-1);
            _spaces.Text = _carPark.GetAvailableSpaces().ToString();

            // Return the customer to the pool
            List<Customer> newList = new List<Customer>();
            newList = _carPark.GetActiveCustList();
            newList.Add(_carPark.GetCPVisitor()[i]);
            _carPark.SetActCustList(newList);
            _carPark.SetNoOfCustomers(1);
            _custNo.Text = _carPark.GetNoOfActCusts().ToString();

            // Eject customer from the Car Park 
            _cpPanels[front.Level].UpdateCPstatus(front.BayIndex, null, front.BayNo, "Available");
            _carPark.RemoveCPVisitor(_carPark.GetCPVisitor()[i]);

            // Check if Car Park is empty to close the window
            ExitPark eP = (ExitPark)this.FindForm();
            eP.IsQueueEmpty();
        }

        private void chip_btn_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            int i = 0;
            while (!isFound)
            {
                if (queue_list.Items[0].ToString() == _carPark.GetCPVisitor()[i].GetName())
                {
                    if (_carPark.GetCPVisitor()[i].GetChipCoin() == false)
                    {
                        _carPark.GetCPVisitor()[i].SetChipCoin(true);
                        exitBarrierText.Text += exitMsg;
                    }
                    else
                    {
                        exitBarrierText.Text = "Upon your exit, your ban will start as of now. We are sorry for hearing" +
                            " that these unfortunate circumstances have occurred. We are hoping that this issue will be" +
                            " resolved as soon as possible. Have a safe journey!";
                    }
                    isFound = true;
                }
                else i++;
                exitCP.Enabled = true;
                raised.Checked = true;
                chip_btn.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _currentTime = DateTime.Now.AddHours(_skipHour);
        }

        private void FPrintScan_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            int i = 0;
            while (!isFound)
            {
                if (queue_list.Items[0].ToString() == _carPark.GetCPVisitor()[i].GetName())
                {
                    if (_carPark.GetCPVisitor()[i].GetAccount() == null)
                    {
                        exitBarrierText.Text = "As a non-registered customer, please insert your chip coin to leave the Car Park.";
                        chip_btn.Enabled = true;
                    }
                    else
                    {
                        TimeSpan totalTime = _currentTime.Subtract(_carPark.GetCPVisitor()[i].GetEntryTime());
                        if (totalTime.Minutes <= 30 && totalTime.Hours == 0) totalPrice = 0;
                        else totalPrice = hourlyPrice * totalTime.Hours;

                        switch (_carPark.GetCPVisitor()[i].GetAccount().GetIncentiveType())
                        {
                            case "Student":
                                totalPrice *= 0.5;
                                break;
                            case "Partner Employee":
                                totalPrice -= totalPrice * 0.3;
                                break;
                            case "Car Park Employee":
                                totalPrice = 0;
                                break;
                            case "Standard Visitor":
                                break;
                            default:
                                break;
                        }

                        exitBarrierText.Text = "Tap-out successful." +
                            "\nTotal price: " + totalPrice + " GBP" +
                            "\nHours spent: " + totalTime.Hours + " hour." +
                            exitMsg;

                        // Update the customer's FPrint Balance
                        if (_carPark.GetCPVisitor()[i].GetAccount() != null)
                            if (_carPark.GetCPVisitor()[i].GetAccount().GetPayStyle() == "PAYP")
                            {
                                _carPark.GetCPVisitor()[i].GetAccount().SetBalance(-totalPrice);
                                if (_carPark.GetCPVisitor()[i].GetAccount().GetBalance() < 0)
                                {
                                    _carPark.GetCPVisitor()[i].SetLocked(true);
                                    _carPark.GetCPVisitor()[i].SetDebt(_carPark.GetCPVisitor()[i].GetAccount().GetBalance());
                                    _carPark.GetCPVisitor()[i].GetAccount().NullBalance();
                                    MessageBox.Show("Sending a warning to " + queue_list.Items[0].ToString() + "'s FPrint Account..."
                                                    + "\nDue to insufficient funds in your bank account,"
                                                    + "\nwe have partially charged and put you in debt with"
                                                    + "\na sum of " + _carPark.GetCPVisitor()[i].GetDebt() + " GBP. Simultaneously, your account"
                                                    + "\nhas been locked until you have paid off your"
                                                    + "\ndebts.");
                                }
                            }
                            else
                                _carPark.GetCPVisitor()[i].GetAccount().SetBalance(totalPrice);

                        exitCP.Enabled = true;
                        raised.Checked = true;
                    }
                    isFound = true;
                }
                else
                    i++;
            }
            FPrintScan.Enabled = false;
        }
    }
}
