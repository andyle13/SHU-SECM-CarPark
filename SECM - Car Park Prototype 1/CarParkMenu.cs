using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class CarParkMenu : Form
    {
        private int skipHour = 0, pageIndex = 0;
        private CarPark carPark;
        private List<CarParkDB> cpPanels;
        private DateTime dateTime = DateTime.Now;

        public CarParkMenu(CarPark newCarPark)
        {
            InitializeComponent();
            timer1.Start();
            carPark = newCarPark;
            initialiseSpaceMap();
            if (cpPanels.Count != 1) nextLV.Enabled = true;
            capacity.Text = carPark.GetMaxCap().ToString();
            lvCapacity.Text = carPark.GetLVCap().ToString();
            spaces.Text = carPark.GetAvailableSpaces().ToString();
            lvs.Text = carPark.GetLevels().ToString();
            barriers.Text = carPark.GetExitBarriers().ToString();
        }

        private void NewCust_btn_Click(object sender, EventArgs e)
        {
            int isAdded = carPark.GetNoOfActCusts();
            NewCustomer newCust = new NewCustomer(carPark);
            newCust.ShowDialog();
            if (isAdded != carPark.GetNoOfActCusts())
                custNo.Text = carPark.GetNoOfActCusts().ToString();
            checkActCust();
        }

        private void EnterCP_btn_Click(object sender, EventArgs e)
        {
            EnterPark enter = new EnterPark(carPark, cpPanels, spaces, custNo, dateTime, skipHour);
            enter.ShowDialog();
            checkActCust();
            checkActVis();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime = DateTime.Now.AddHours(skipHour);
            time.Text = dateTime.ToString("hh:mm:ss tt");
        }
        private void HourSkipper_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            skipHour++;
            timer1.Start();
        }

        private void nextLV_Click(object sender, EventArgs e)
        {
            if (pageIndex < cpPanels.Count - 1)
            {
                cpPanels[++pageIndex].BringToFront();
                lvLabel.Text = (pageIndex != 0) ? "Level " + pageIndex.ToString() : "Ground Floor";
                if (pageIndex == cpPanels.Count - 1)
                {
                    nextLV.Enabled = false;
                    prevLV.Enabled = true;
                }
                else
                    prevLV.Enabled = true;
            }
        }

        private void prevLV_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0)
            {
                cpPanels[--pageIndex].BringToFront();
                lvLabel.Text = (pageIndex != 0) ? "Level " + pageIndex.ToString() : "Ground Floor";
                if (pageIndex == 0)
                {
                    prevLV.Enabled = false;
                    nextLV.Enabled = true;
                }
                else
                    nextLV.Enabled = true;
            }
        }

        private void RandCust_btn_Click(object sender, EventArgs e)
        {
            int isAdded = carPark.GetNoOfActCusts();
            Customer newCust = new Customer("CP Agent", 666, new FPrintAcc(666, true, "Car Park Employee"));
            carPark.AddActiveCustomer(newCust);
            if (isAdded != carPark.GetNoOfActCusts())
                custNo.Text = carPark.GetNoOfActCusts().ToString();
            checkActCust();
        }

        private void initialiseSpaceMap()
        {
            int bayNo = 1;
            cpPanels = new List<CarParkDB>();
            for (int i = 0; i < carPark.GetLevels(); i++)
            {
                CarParkDB carparkDB = new CarParkDB();
                carparkDB.Name = "cp" + i.ToString();
                for (int j = 0; j < carPark.GetLVCap(); j++)
                {
                    if(i == 0) carparkDB.SetInitialRows(j, "", bayNo, "Available");
                    else carparkDB.SetInitialRows(j, "", bayNo, "Level Inaccessible");
                    bayNo++;
                }
                cpPanels.Add(carparkDB);
                panel_main.Controls.Add(carparkDB);
            }
        }

        private void Bay_btn_Click(object sender, EventArgs e)
        {
            ParkingBay pl = new ParkingBay(carPark, cpPanels);
            pl.ShowDialog();
            checkActVis();
            checkActPark();
            checkActExit();
        }

        private void checkActCust()
        {
            EnterCP_btn.Enabled = (carPark.GetNoOfActCusts() > 0) ? true : false;
            Voucher_btn.Enabled = (carPark.GetNoOfActCusts() > 0) ? true : false;
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            PaymentMachine pay = new PaymentMachine(carPark, cpPanels, dateTime, skipHour);
            pay.ShowDialog();
            checkActPark();
        }

        private void UpdateCust_btn_Click(object sender, EventArgs e)
        {
            UpdateCustomer upd = new UpdateCustomer(carPark);
            upd.ShowDialog();
        }

        private void ExitCP_btn_Click(object sender, EventArgs e)
        {
            ExitPark exit = new ExitPark(carPark, cpPanels, spaces, custNo, dateTime, skipHour);
            exit.ShowDialog();
            checkActCust();
            checkActExit();
        }

        private void checkActVis()
        {
            Bay_btn.Enabled = (carPark.GetNoOfVisitors() > 0) ? true : false;
        }
        private void checkActExit()
        {
            ExitCP_btn.Enabled = (carPark.GetNoOfExitCust() > 0) ? true : false;
        }

        private void Voucher_btn_Click(object sender, EventArgs e)
        {
            PurchaseVoucher voucher = new PurchaseVoucher(carPark);
            voucher.ShowDialog();
        }

        private void DirectDebit_btn_Click(object sender, EventArgs e)
        {
            DirectDebit debit = new DirectDebit(carPark);
            debit.ShowDialog();
        }

        private void Debt_btn_Click(object sender, EventArgs e)
        {
            RelieveDebt debt = new RelieveDebt(carPark);
            debt.ShowDialog();
        }

        private void supervisor_control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (supervisor_control.Text.ToString())
                {
                    case "showcontrol":
                        RandCust_btn.Enabled = true;
                        HourSkipper_btn.Enabled = true;
                        UpdateCust_btn.Enabled = true;
                        DirectDebit_btn.Enabled = true;
                        Debt_btn.Enabled = true;
                        Emergency_btn.Enabled = true;
                        break;
                    case "hidecontrol":
                        RandCust_btn.Enabled = false;
                        HourSkipper_btn.Enabled = false;
                        UpdateCust_btn.Enabled = false;
                        DirectDebit_btn.Enabled = false;
                        Debt_btn.Enabled = false;
                        Emergency_btn.Enabled = false;
                        break;
                    case "customerfullcontrol":
                        NewCust_btn.Enabled = true;
                        Voucher_btn.Enabled = true;
                        EnterCP_btn.Enabled = true;
                        Bay_btn.Enabled = true;
                        Pay_btn.Enabled = true;
                        ExitCP_btn.Enabled = true;
                        break;
                    case "customerban":
                        NewCust_btn.Enabled = false;
                        Voucher_btn.Enabled = false;
                        EnterCP_btn.Enabled = false;
                        Bay_btn.Enabled = false;
                        Pay_btn.Enabled = false;
                        ExitCP_btn.Enabled = false;
                        break;
                    case "hacksystem":
                        NewCust_btn.Enabled = true;
                        Voucher_btn.Enabled = true;
                        EnterCP_btn.Enabled = true;
                        Bay_btn.Enabled = true;
                        Pay_btn.Enabled = true;
                        ExitCP_btn.Enabled = true;
                        RandCust_btn.Enabled = true;
                        HourSkipper_btn.Enabled = true;
                        UpdateCust_btn.Enabled = true;
                        DirectDebit_btn.Enabled = true;
                        Debt_btn.Enabled = true;
                        Emergency_btn.Enabled = true;
                        break;
                    case "crashsystem":
                        supervisor_control.Enabled = false;
                        NewCust_btn.Enabled = false;
                        Voucher_btn.Enabled = false;
                        EnterCP_btn.Enabled = false;
                        Bay_btn.Enabled = false;
                        Pay_btn.Enabled = false;
                        ExitCP_btn.Enabled = false;
                        RandCust_btn.Enabled = false;
                        HourSkipper_btn.Enabled = false;
                        UpdateCust_btn.Enabled = false;
                        DirectDebit_btn.Enabled = false;
                        Debt_btn.Enabled = false;
                        Emergency_btn.Enabled = false;
                        break;
                    case "cleanreset":
                        for (int i = 0; i < carPark.GetLevels(); i++)
                        {
                            for (int j = 0; j < carPark.GetLVCap(); j++)
                            {
                                if (i == 0) cpPanels[i].UpdateCPstatus(j, null, j + 1, "Available");
                                else cpPanels[i].UpdateCPstatus(j, null, j + 1, "Level Inaccessible");
                            }
                        }
                        skipHour = 0;
                        carPark.SetCPVisitorList(new List<Customer>());
                        carPark.SetActCustList(new List<Customer>());
                        carPark.SetNoOfVisitors(-carPark.GetNoOfVisitors());
                        carPark.SetNoOfParkCust(-carPark.GetNoOfParkCust());
                        carPark.SetNoOfExitCust(-carPark.GetNoOfExitCust());
                        carPark.SetNoOfCustomers(-carPark.GetNoOfActCusts());
                        carPark.SetOccupiedSpaces(-(carPark.GetMaxCap() - carPark.GetAvailableSpaces()));
                        spaces.Text = carPark.GetAvailableSpaces().ToString();
                        custNo.Text = carPark.GetNoOfActCusts().ToString(); 
                        Voucher_btn.Enabled = false;
                        EnterCP_btn.Enabled = false;
                        Bay_btn.Enabled = false;
                        Pay_btn.Enabled = false;
                        ExitCP_btn.Enabled = false;
                        break;
                    case "factoryreset":
                        this.Hide();
                        SetupCarPark reboot = new SetupCarPark();
                        reboot.ShowDialog();
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Emergency_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to activate the emergency?", "Emergency", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && !carPark.GetEmergency())
            {
                carPark.SetEmergency(true);
                MessageBox.Show("All barriers are open. Leave the Car Park"
                                + "\nfor your own safety.");
                for (int i = 0; i < carPark.GetLevels(); i++)
                {
                    for (int j = 0; j < carPark.GetLVCap(); j++)
                    {
                        if (!(cpPanels[i].GetStatus(j) == "Available"
                            || cpPanels[i].GetStatus(j) == "Level Inaccessible"
                            || cpPanels[i].GetStatus(j) == "Awaiting Exit"))
                        {
                            cpPanels[i].SetStatus(j, "Awaiting Exit");
                            carPark.SetNoOfVisitors(-1);
                            carPark.SetNoOfParkCust(-1);
                            carPark.SetNoOfExitCust(1);
                        }
                    }
                }
                Barrier_lbl.Text = "Emergency";
                Bay_btn.Enabled = false;
                Pay_btn.Enabled = false;
                checkActExit();
            }
            else if (dialogResult == DialogResult.No)
            {
                Barrier_lbl.Text = "In operation";
                carPark.SetEmergency(false);
                MessageBox.Show("All barriers have been restored.");
            }
        }

        private void checkActPark()
        {
            Pay_btn.Enabled = (carPark.GetNoOfParkCust() > 0) ? true : false;
        }
    }
}
