using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SECM___Car_Park_Prototype_1
{
    public partial class PaymentMachine : Form
    {
        CarPark _carPark;
        List<CarParkDB> _cpPanels;
        CustListItems selectedCustomer;
        DateTime _currentTime;
        int _skipHour;
        double totalPrice, cashlessPrice, paid = 0;
        const double hourlyPrice = 3.50;
        bool isCrypto = false;
        public PaymentMachine(CarPark carPark, List<CarParkDB> cpPanels, DateTime currentTime, int skipHour)
        {
            InitializeComponent();
            _carPark = carPark;
            _cpPanels = cpPanels;
            _currentTime = currentTime;
            _skipHour = skipHour;
            timer1.Start();
            for (int i = 0; i < _carPark.GetLevels(); i++)
            {
                for (int j = 0; j < _carPark.GetLVCap(); j++)
                {
                    if (_cpPanels[i].GetStatus(j) == "Occupied" ||
                        _cpPanels[i].GetStatus(j) == "Occupied (Secured)")
                    {
                        CustListItems item = new CustListItems();
                        item.Level = i;
                        item.BayIndex = j;
                        item.Name = _cpPanels[i].GetCustName(j);
                        item.BayNo = _cpPanels[i].GetBayNo(j);
                        custList.Items.Add(item);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _currentTime = DateTime.Now.AddHours(_skipHour);
        }

        private void custList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = custList.SelectedItem as CustListItems;

            int i = 0;
            while (selectedCustomer.ToString() != _carPark.GetCPVisitor()[i].GetName())
                i++;

            if (_carPark.GetCPVisitor()[i].GetAccount() == null)
            {
                InsertCoin_btn.Text = "Insert Coin";
                ChipCoinLost_btn.Enabled = true;
            }
            else
            {
                InsertCoin_btn.Text = "Scan Fingerprint";
                ChipCoinLost_btn.Enabled = false;
            }

            InsertCoin_btn.Enabled = true;
        }

        private void FPrintScan_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (selectedCustomer.ToString() != _carPark.GetCPVisitor()[i].GetName())
                i++;


            if (_carPark.GetCPVisitor()[i].GetAccount() == null && _carPark.GetCPVisitor()[i].GetChipCoin() == true)
            {
                TimeSpan totalTime = _currentTime.Subtract(_carPark.GetCPVisitor()[i].GetEntryTime());
                if (totalTime.Minutes <= 30 && totalTime.Hours == 0) totalPrice = 0;
                else totalPrice = hourlyPrice * totalTime.Hours;
                if (_carPark.GetCPVisitor()[i].GetPassword() != null)
                    totalPrice += 2.50;
                cashlessPrice = totalPrice;
                paymentScreen.Text = "The total price for having parked for " + totalTime.Hours + " hours is: " + totalPrice + " GBP.";
                balance_lbl.Text = _carPark.GetCPVisitor()[i].GetBalance().ToString() + " GBP";
                InsertCoin_btn.Enabled = false;
                ChipCoinLost_btn.Enabled = false;
                custList.Enabled = false;
                paymentPanel.Enabled = true;
                pay_btn.Enabled = true;
                pay_btn.Text = "Pay for Exit";
            }
            else
            {
                if (_carPark.GetCPVisitor()[i].GetAccount().GetPayStyle() == "PAYP")
                {
                    paymentScreen.Text = "Welcome " + _carPark.GetCPVisitor()[i].GetName()
                        + ",\nyour current FPrint Balance is "
                        + _carPark.GetCPVisitor()[i].GetAccount().GetBalance()
                        + " GBP.\nUse this terminal to top up your balance.";
                    paymentPanel.Enabled = true;
                    balance_lbl.Text = _carPark.GetCPVisitor()[i].GetBalance().ToString() + " GBP";
                    InsertCoin_btn.Enabled = false;
                    custList.Enabled = false;
                    pay_btn.Enabled = true;
                    pay_btn.Text = "Top up FPrint Balance";
                }
                else
                {
                    paymentScreen.Text = "Welcome " + _carPark.GetCPVisitor()[i].GetName()
                        + ",\nyour accumulated FPrint charge is "
                        + _carPark.GetCPVisitor()[i].GetAccount().GetBalance()
                        + " GBP.";
                    paymentPanel.Enabled = false;
                }
            }
            if (totalPrice == 0 && _carPark.GetCPVisitor()[i].GetAccount() == null)
            {
                _cpPanels[selectedCustomer.Level].SetStatus(selectedCustomer.BayIndex, "Paid");
                custList.Items.Remove(custList.SelectedItem);
                custList.Text = "";
                paymentPanel.Enabled = false;
                if (custList.Items.Count <= 0)
                    this.Close();
                else
                    custList.Enabled = true;
            }
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            string input;
            double notPaid = 0;

            int i = 0;
            while (selectedCustomer.ToString() != _carPark.GetCPVisitor()[i].GetName())
                i++;

            if (_carPark.GetCPVisitor()[i].GetAccount() == null && _carPark.GetCPVisitor()[i].GetChipCoin() == true)
            {
                if (isCrypto == true)
                {
                    CryptoPayment crypto = new CryptoPayment(this, totalPrice);
                    crypto.ShowDialog();
                } // send payment with cryptocurrency
                else
                {
                    bool isCancel = false;
                    do
                    {
                        input = Interaction.InputBox("Please pay " + totalPrice + " GBP:", "Make Payment", totalPrice.ToString());
                        if (input.Length > 0)
                        {
                            paid = Convert.ToDouble(input);
                            Math.Round(paid, 2);
                            if(paid == Math.Round(totalPrice, 2)) isCancel = true;
                        }
                        else
                        {
                            isCancel = true;
                        }
                    } while (paid != Math.Round(totalPrice, 2) && !isCancel);
                } // regular payment

                if (paid != notPaid)
                {
                    _carPark.GetCPVisitor()[i].SetChipCoin(false);
                    _carPark.GetCPVisitor()[i].SetBalance(-paid);

                    if (_carPark.GetCPVisitor()[i].GetBalance() < 0)
                    {
                        _carPark.GetCPVisitor()[i].SetLocked(true);
                        _carPark.GetCPVisitor()[i].SetDebt(_carPark.GetCPVisitor()[i].GetBalance());
                        _carPark.GetCPVisitor()[i].NullBalance();
                        MessageBox.Show("Sending a warning to " + selectedCustomer.Name + "..."
                                        + "\nDue to insufficient funds in your bank account,"
                                        + "\nwe have partially charged and put you in debt with"
                                        + "\na sum of " + _carPark.GetCPVisitor()[i].GetDebt() + " GBP. Simultaneously, your account"
                                        + "\nhas been locked until you have paid off your"
                                        + "\ndebts.");
                    }

                    balance_lbl.Text = _carPark.GetCPVisitor()[i].GetBalance().ToString() + " GBP";

                    _cpPanels[selectedCustomer.Level].SetStatus(selectedCustomer.BayIndex, "Paid");
                    custList.Items.Remove(custList.SelectedItem);
                    paymentPanel.Enabled = false;
                    paymentScreen.Text = "Thank you for your visit. Your car has been detached from the parking bay and is ready for departure.";
                } // make sure payment sent is in full
            }
            else
            {
                if (isCrypto == true)
                {
                    input = Interaction.InputBox("Determine the top-up value for your FPrint Balance.", "Make Payment", totalPrice.ToString());
                    if(input.Length > 0)
                    {
                        Double topup = Convert.ToDouble(input);
                        Math.Round(topup, 2);
                        CryptoPayment crypto = new CryptoPayment(this, topup);
                        crypto.ShowDialog();
                    }

                } // send payment with cryptocurrency
                else
                {
                    bool isCancel = false;
                    do
                    {
                        input = Interaction.InputBox("Please top-up your FPrint Balance:", "Make Payment", "5");
                        if (input.Length > 0)
                        {
                            paid = Convert.ToDouble(input);
                            Math.Round(paid, 2);
                            if (paid == Math.Round(totalPrice, 2)) isCancel = true;
                        }
                        else
                        {
                            isCancel = true;
                        }
                    } while (paid != Math.Round(totalPrice, 2) && !isCancel);
                } // regular payment

                if (paid != notPaid)
                {
                    _carPark.GetCPVisitor()[i].SetBalance(-paid);
                    _carPark.GetCPVisitor()[i].GetAccount().SetBalance(paid);
                    balance_lbl.Text = _carPark.GetCPVisitor()[i].GetBalance().ToString() + " GBP";
                    paymentScreen.Text = "Your new FPrint Balance is: " + _carPark.GetCPVisitor()[i].GetAccount().GetBalance() + " GBP.";
                    paymentPanel.Enabled = false;
                }
            }

            custList.Text = "";
            custList.Enabled = true;
        }

        private void card_btn_CheckedChanged(object sender, EventArgs e)
        {
            totalPrice = cashlessPrice;
            isCrypto = false;
        }

        private void crypto_btn_CheckedChanged(object sender, EventArgs e)
        {
            isCrypto = true;
        }

        private void ChipCoinLost_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to signal that you have lost your chip coin?" +
                " A compensation fee of 15 GBP plus charging interest will apply. In addition, you will be banned until" +
                " you have paid off your debts. Would you like to proceed?",
                "Chip Coin Lost", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int i = 0;
                while (selectedCustomer.ToString() != _carPark.GetCPVisitor()[i].GetName())
                    i++;

                _cpPanels[selectedCustomer.Level].SetStatus(selectedCustomer.BayIndex, "Paid");
                custList.Items.Remove(custList.SelectedItem);
                custList.Text = "";
                _carPark.GetCPVisitor()[i].SetLocked(true);
                _carPark.GetCPVisitor()[i].SetDebt(15);
                if (custList.Items.Count <= 0)
                    this.Close();
            }
        }

        private void voucher_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (selectedCustomer.Name != _carPark.GetCPVisitor()[i].GetName())
                i++;

            if (_carPark.GetCPVisitor()[i].GetVoucher() != null)
            {
                string input = null;
                input = Interaction.InputBox("Please enter your voucher code:", "Make Payment", input);
                if (input.Length > 0 && input == _carPark.GetCPVisitor()[i].GetVoucher().GetVoucherCode()) {
                    MessageBox.Show("Voucher successfully redeemed.");
                    totalPrice -= _carPark.GetCPVisitor()[i].GetVoucher().GetValue();
                    _carPark.GetCPVisitor()[i].SetVoucher(null);
                    paymentScreen.Text = "Updated price: " + totalPrice + " GBP.";
                }
                else
                    MessageBox.Show("Invalid code.");
            }
            else
            {
                MessageBox.Show("No voucher found!");
            }
        }

        private void cash_btn_CheckedChanged(object sender, EventArgs e)
        {
            totalPrice += Math.Round(totalPrice * 0.15, 2);
            isCrypto = false;
        }

        public void SetQRPaid(double paid)
        {
            this.paid = Math.Round(paid, 2);
        }
    }
}
