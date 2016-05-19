using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotellSavajBooking
{
    public partial class BookingForm : Form
    {
        private DbHandler _dbHandler = new DbHandler();

        public BookingForm()
        {
            InitializeComponent();
            new EditForm().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGui();
        }

        private void InitializeGui()
        {
            foreach (string str in Enum.GetNames(typeof(RoomType)))
            {
                cbTypOfRoom.Items.Add(str.Replace("_", " "));
                cbTypOfRoom.SelectedIndex = 0;
            }
        }

        private void checkWakeupCall_CheckedChanged(object sender, EventArgs e)
        {
            dtpWakeupTime.Enabled = checkWakeupCall.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("First name: " + tbFirstName.Text);
                sb.AppendLine("Last name: " + tbLastName.Text);
                sb.AppendLine("Room type: " + cbTypOfRoom.Text);
                sb.AppendLine("Start date: " + dtpStartDate.Text);
                sb.AppendLine("End date: " + dtpEndDate.Text);
                string wantMiniBar = checkMinibar.Checked ? "YES" : "NO";
                sb.AppendLine("Mini bar: " + wantMiniBar);
                string wantWakeUpCall = checkWakeupCall.Checked ? "YES" : "NO";
                sb.AppendLine("Wakeup call: " + wantWakeUpCall);
                if (checkWakeupCall.Checked)
                {
                    sb.AppendLine("Wakeup time: " + dtpWakeupTime.Text);
                }
                DialogResult result = MessageBox.Show(sb.ToString(), "Is this information correct?", MessageBoxButtons.OKCancel);
                
            }
        }

        private bool ValidateForm()
        {
            if (tbFirstName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a first name.", "No first name added.", MessageBoxButtons.OK);
                return false;
            }
            if (tbLastName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a last name.", "No last name added.", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void BookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
