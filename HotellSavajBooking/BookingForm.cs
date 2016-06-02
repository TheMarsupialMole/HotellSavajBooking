using System;
using System.Collections;
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
        private readonly DbHandler _dbHandler = new DbHandler();
        private ArrayList _roomList = new ArrayList();

        public BookingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGui();
            Booking b1 = new Booking(DateTime.Today, DateTime.Today, "Radde", "Mojsovski", 1, true, DateTime.UtcNow);
            Booking b2 = new Booking(DateTime.Today, DateTime.Today, "Radde", "Mojsovski", 1, true, DateTime.UtcNow);
            Console.WriteLine(b1.Equals(b2));
        }

        private void InitializeGui()
        {
            foreach (string str in Enum.GetNames(typeof(RoomType)))
            {
                cbTypOfRoom.Items.Add(str.Replace("_", " "));
                cbTypOfRoom.SelectedIndex = 0;
            }
            btnBookRoom.Enabled = false;
        }

        private void checkWakeupCall_CheckedChanged(object sender, EventArgs e)
        {
            dtpWakeupTime.Enabled = checkWakeupCall.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _roomList = _dbHandler.GetAvailableRooms(dtpStartDate.Value, dtpEndDate.Value, cbTypOfRoom.SelectedIndex, checkMinibar.Checked);
            listAvailableRooms.Items.Clear();
            listAvailableRooms.Items.AddRange(_roomList.ToArray());
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
            DialogResult result = MessageBox.Show("Your exiting the program.", "Are you sure?",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) e.Cancel = true;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void cbTypOfRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void ClearSearch()
        {
            listAvailableRooms.Items.Clear();
            btnBookRoom.Enabled = false;
        }

        private void listAvailableRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAvailableRooms.SelectedIndex > -1)
            {
                btnBookRoom.Enabled = true;
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("First name: " + tbFirstName.Text);
                sb.AppendLine("Last name: " + tbLastName.Text);
                sb.AppendLine("Room type: " + cbTypOfRoom.Text);
                sb.AppendLine("Start date: " + dtpStartDate.Text);
                sb.AppendLine("End date: " + dtpEndDate.Text);
                string wantMiniBar = checkMinibar.Checked ? "Yes" : "No";
                sb.AppendLine("Mini bar: " + wantMiniBar);
                string wantWakeUpCall = checkWakeupCall.Checked ? "Yes" : "No";
                sb.AppendLine("Wakeup call: " + wantWakeUpCall);
                if (checkWakeupCall.Checked)
                {
                    sb.AppendLine("Wakeup time: " + dtpWakeupTime.Text);
                }

                DialogResult result = MessageBox.Show(sb.ToString(), "Is this information correct?", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int roomNumber = (int) _roomList[listAvailableRooms.SelectedIndex];
              
                    int bookingNumber = _dbHandler.InsertBooking(new Booking(dtpStartDate.Value, dtpEndDate.Value, tbFirstName.Text,
                        tbLastName.Text, roomNumber, checkWakeupCall.Checked, dtpWakeupTime.Value));
                    Console.WriteLine(bookingNumber);
                    if (bookingNumber != -1)
                    {
                        MessageBox.Show(string.Format("Your room is booked with booking ID {0}!", bookingNumber), "Booking done!", MessageBoxButtons.OK);
                        ResetInputFields();
                    }
                }
            }
        }

        private void checkMinibar_CheckedChanged(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new EditForm().Show();
        }

        private void ResetInputFields()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            cbTypOfRoom.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            checkMinibar.Checked = false;
            checkWakeupCall.Checked = false;
            DateTime now = DateTime.Now;
            dtpWakeupTime.Value = new DateTime(now.Year, now.Month, now.Day, 7, 0, 0);
        }
    }
}
