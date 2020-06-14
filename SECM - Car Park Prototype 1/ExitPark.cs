using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SECM___Car_Park_Prototype_1
{
    public partial class ExitPark : Form
    {
        CustListItems selectedCustomer;
        BarrierListItems selectedBarrier;
        List<ExitBarrierPanel> exitBarriers = new List<ExitBarrierPanel>();

        const int SPACER = 1;
        public ExitPark(CarPark carPark, List<CarParkDB> cpPanels, Label spaces, Label custNo, DateTime dateTime, int skipHour)
        {
            InitializeComponent();
            label4.Text = carPark.GetExitBarriers().ToString();

            for (int i = 0; i < carPark.GetLevels(); i++)
            {
                for (int j = 0; j < carPark.GetLVCap(); j++)
                {
                    if (cpPanels[i].GetStatus(j) == "Awaiting Exit")
                    {
                        CustListItems item = new CustListItems();
                        item.Level = i;
                        item.BayIndex = j;
                        item.Name = cpPanels[i].GetCustName(j);
                        item.BayNo = cpPanels[i].GetBayNo(j);
                        custList.Items.Add(item);
                    }
                }
            } // Gather customers who are about to leave

            for (int i = 0; i < carPark.GetExitBarriers(); i++)
            {
                ExitBarrierPanel exitBarrier = new ExitBarrierPanel(carPark, cpPanels, spaces, custNo, dateTime, skipHour);
                ExitBarrierPanel previous;

                exit_panel.Controls.Add(exitBarrier);
                if (exit_panel.Controls.Count < 2)
                {
                    exitBarrier.Location = new Point(0, 0);
                }
                else
                {
                    previous = (ExitBarrierPanel)exit_panel.Controls[exit_panel.Controls.Count - 2];
                    exitBarrier.Location = new Point(previous.Location.X + previous.Height + SPACER, 0);
                }
                exitBarrier.setLabel(i+1);
                exitBarrier.Width = exit_panel.Width;
                exitBarrier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
                                        | System.Windows.Forms.AnchorStyles.Bottom)
                                        | System.Windows.Forms.AnchorStyles.Left)));
                exitBarriers.Add(exitBarrier);
            } // Gather exit points

            for (int i = 0; i < carPark.GetExitBarriers(); i++)
            {
                BarrierListItems item = new BarrierListItems();
                item.Name = "Exit Barrier " + (i+1).ToString();
                item.ID = i;
                barrierList.Items.Add(item);
            } // Gather exit barrier list
        }

        private void queue_btn_Click(object sender, EventArgs e)
        {
            exitBarriers[selectedBarrier.ID].setQueuePosition(selectedCustomer);
            custList.Items.Remove(custList.SelectedItem);
            selectedCustomer = null;
            custList.Text = "";
            queue_btn.Enabled = false;
        }

        private void custList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = custList.SelectedItem as CustListItems;
            CheckQueue();
        }

        private void barrierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBarrier = barrierList.SelectedItem as BarrierListItems;
            CheckQueue();
        }

        public void CheckQueue()
        {
            queue_btn.Enabled = (custList.SelectedIndex > -1
                && barrierList.SelectedIndex > -1) ?
                true : false;
        }

        public void IsQueueEmpty()
        {
            int allEmpty = 0;
            for(int i = 0; i < exitBarriers.Count; i++)
            {
                if (exitBarriers[i].IsQueueEmpty())
                    allEmpty++;
                
                if (custList.Items.Count <= 0 && allEmpty == exitBarriers.Count)
                    this.Close();
            }
        }

        private void ExitPark_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool isEmpty = true;
            for (int i = 0; i < exitBarriers.Count; i++)
            {
                if (!exitBarriers[i].IsQueueEmpty())
                {
                    isEmpty = false;
                }
            }
            if (!isEmpty)
            {
                MessageBox.Show("Please dequeue all the leaving customers first.");
                e.Cancel = true;
            }
        }
    }
}
