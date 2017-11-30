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
        private int skipHour = 0;
        private CarPark carPark;
        public carParkPanel(CarPark newCarPark)
        {
            InitializeComponent();
            timer1.Start();
            carPark = newCarPark;
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
            {
                custNo.Text = carPark.getNoOfActCusts().ToString();
                newCustAdded.Text = carPark.getNewlyAddedCust().getName();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
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
    }
}
