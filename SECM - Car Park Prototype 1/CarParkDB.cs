using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class CarParkDB : UserControl
    {
        public CarParkDB()
        {
            InitializeComponent();
        }

        public void SetInitialRows(int rowno, string name, int bayno, string status)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[rowno].Cells[0].Value = bayno;
            dataGridView1.Rows[rowno].Cells[1].Value = name;
            dataGridView1.Rows[rowno].Cells[2].Value = status;
        }

        public void UpdateCPstatus(int rowno, string name, int bayno, string status)
        {
            dataGridView1.Rows[rowno].Cells[1].Value = name;
            dataGridView1.Rows[rowno].Cells[2].Value = status;
        }

        public int GetBayNo(int rowno)
        {
            return (int)dataGridView1.Rows[rowno].Cells[0].Value;
        }

        public string GetCustName(int rowno)
        {
            return (string)dataGridView1.Rows[rowno].Cells[1].Value;
        }

        public string GetStatus(int rowno)
        {
            return (string)dataGridView1.Rows[rowno].Cells[2].Value;
        }

        public void SetStatus(int rowno, string update)
        {
            dataGridView1.Rows[rowno].Cells[2].Value = update;
        }
    }
}
