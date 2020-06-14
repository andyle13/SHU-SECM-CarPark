using System;
using System.Drawing;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class SetupCarPark : Form
    {
        private int lv, sp, exitBarriers;
        public SetupCarPark()
        {
            InitializeComponent();
        }
        private void setupCarPark_Load(object sender, EventArgs e)
        {
            instantiation.Enabled = false;
        }
        private void levels_Enter(object sender, EventArgs e)
        {
            if (levels.Text == "0")
            {
                levels.Text = "";
                levels.ForeColor = Color.Black;
            }
        }
        private void levels_Leave(object sender, EventArgs e)
        {
            if (levels.Text == "")
            {
                levels.Text = "0";
                levels.ForeColor = SystemColors.InactiveCaption;
            }
        }
        private void spaces_Enter(object sender, EventArgs e)
        {
            if (spaces.Text == "0")
            {
                spaces.Text = "";
                spaces.ForeColor = Color.Black;
            }
        }
        private void spaces_Leave(object sender, EventArgs e)
        {
            if (spaces.Text == "")
            {   
                spaces.Text = "0";
                spaces.ForeColor = SystemColors.InactiveCaption;
            }
        }
        private void exits_Enter(object sender, EventArgs e)
        {
            if (exits.Text == "0")
            {
                exits.Text = "";
                exits.ForeColor = Color.Black;
            }
        }
        private void exits_Leave(object sender, EventArgs e)
        {
            if (exits.Text == "")
            {
                exits.Text = "0";
                exits.ForeColor = SystemColors.InactiveCaption;
            }
        }
        private void levels_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void spaces_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void exits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void levels_TextChanged(object sender, EventArgs e)
        {
            lv = (levels.Text != "") ? int.Parse(levels.Text) : 0;
            capacity_display();
        }
        private void spaces_TextChanged(object sender, EventArgs e)
        {
            sp = (spaces.Text != "") ? int.Parse(spaces.Text) : 0;
            capacity_display();
        }
        private void exits_TextChanged(object sender, EventArgs e)
        {
            exitBarriers = (exits.Text != "") ? int.Parse(exits.Text) : 0;
            capacity_display();
        }
        private void capacity_display()
        {
            capacity.Text = (lv != 0 && sp != 0) ? (lv * sp).ToString() : "0";
            instantiation.Enabled = (lv != 0 && sp != 0 && exitBarriers != 0) ? true : false;
        }
        private void instantiation_Click(object sender, EventArgs e)
        {
            CarPark newCarPark = new CarPark(lv, sp, exitBarriers);
            MessageBox.Show("Car Park created.");
            this.Hide();
            CarParkMenu main = new CarParkMenu(newCarPark);
            main.ShowDialog();
            this.Close();
        }
    }
}
