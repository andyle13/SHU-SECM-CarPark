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
    public partial class carParkPanel : Form
    {
        private int skipHour = 0, pageIndex = 0;
        private CarPark carPark;
        private List<CarParkDB> cpPanels;

        public carParkPanel(CarPark newCarPark)
        {
            InitializeComponent();
            timer1.Start();
            carPark = newCarPark;
            initialiseSpaceMap();
            if (cpPanels.Count != 1) nextLV.Enabled = true;
            capacity.Text = carPark.getMaxCap().ToString();
            lvCapacity.Text = carPark.getLVCap().ToString();
            spaces.Text = carPark.getAvailableSpaces().ToString();
            lvs.Text = carPark.getLevels().ToString();
        }

        private void newCust_Click(object sender, EventArgs e)
        {
            int isAdded = carPark.getNoOfActCusts();
            newCustomer newCust = new newCustomer(carPark);
            newCust.ShowDialog();
            if (isAdded != carPark.getNoOfActCusts())
                custNo.Text = carPark.getNoOfActCusts().ToString();
            checkActCust();
        }

        private void enterCP_Click(object sender, EventArgs e)
        {
            enterPark enter = new enterPark(carPark, cpPanels, spaces);
            enter.ShowDialog();
            checkActCust();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now.AddHours(skipHour);
            time.Text = dateTime.ToString("hh:mm:ss tt");
        }
        private void hourSkipper_Click(object sender, EventArgs e)
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

        private void carParkPanel_Load(object sender, EventArgs e)
        {

        }

        private void randCust_Click(object sender, EventArgs e)
        {
            int isAdded = carPark.getNoOfActCusts();
            Customer newCust = new Customer("CP Agent", 666, new FPrintAcc(666, true, "Car Park Employee"));
            carPark.addActiveCustomer(newCust);
            if (isAdded != carPark.getNoOfActCusts())
                custNo.Text = carPark.getNoOfActCusts().ToString();
            checkActCust();
        }

        private void initialiseSpaceMap()
        {
            int bayNo = 1;
            cpPanels = new List<CarParkDB>();
            for (int i = 0; i < carPark.getLevels(); i++)
            {
                CarParkDB carparkDB = new CarParkDB();
                carparkDB.Name = "cp" + i.ToString();
                for (int j = 0; j < carPark.getLVCap(); j++)
                {
                    if(i == 0) carparkDB.setInitialRows(j, "", bayNo, "Available");
                    else carparkDB.setInitialRows(j, "", bayNo, "Level Inaccessible");
                    bayNo++;
                }
                cpPanels.Add(carparkDB);
                panel_main.Controls.Add(carparkDB);
            }
        }

        private void parklock_Click(object sender, EventArgs e)
        {
            parkLock pl = new parkLock(carPark, cpPanels);
            pl.ShowDialog();
        }

        private void checkActCust()
        {
            enterCP.Enabled = (carPark.getActiveCustList().Count > 0) ? true : false;
        }
    }
}
