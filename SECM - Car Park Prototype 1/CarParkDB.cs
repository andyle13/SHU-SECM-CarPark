using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class CarParkDB : UserControl
    {
        public CarParkDB()
        {
            InitializeComponent();
        }

        public void setInitialRows(int rowno, string name, int bayno, string status)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[rowno].Cells[0].Value = bayno;
            dataGridView1.Rows[rowno].Cells[1].Value = name;
            dataGridView1.Rows[rowno].Cells[2].Value = status;
        }

        public void updateCPstatus(int rowno, string name, int bayno, string status)
        {
            dataGridView1.Rows[rowno].Cells[1].Value = name;
            dataGridView1.Rows[rowno].Cells[2].Value = status;
        }

        public int getBayNo(int rowno)
        {
            return (int)dataGridView1.Rows[rowno].Cells[0].Value;
        }

        public string getCustName(int rowno)
        {
            return (string)dataGridView1.Rows[rowno].Cells[1].Value;
        }

        public string getStatus(int rowno)
        {
            return (string)dataGridView1.Rows[rowno].Cells[2].Value;
        }

        public void setStatus(int rowno, string update)
        {
            dataGridView1.Rows[rowno].Cells[2].Value = update;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
