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
    /// <summary>
    /// Class written by Ted Malmgren
    /// 
    /// The class hadles the editing or removal of a booking
    /// </summary>
    public partial class EditForm : Form
    {
        private DbHandler dbHandler;
        private bool validPost = false;


        /// <summary>
        /// Constructor for the class
        /// </summary>
        public EditForm()
        {
            InitializeComponent();
            dbHandler = new DbHandler();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateBookingNumber())
            {
                int bnr;
                int.TryParse(txtBookingNr.Text, out bnr);
                Booking b = dbHandler.GetBooking(bnr);
                if (b != null)
                    PopulateWindow(b);
                else
                {
                    ResetValues();
                    System.Windows.Forms.MessageBox.Show("Booking with this number doesn't exist", "Error");
                }
            }
        }

        private void PopulateWindow(Booking b)
        {
            validPost = true;
            txtFirstName.Text = "  "+ b.FirstName;
            txtLastName.Text = "  " + b.LastName;
            txtRoomNumber.Text = "  " + b.BookedId;
            chkBWake.Checked = (b.WakeUp);
            dntPickerWake.Value = b.WakeTime;
            dntPickerStart.Value = b.Startime;
            dntPickerend.Value = b.EndTime;
        }

        private void ResetValues()
        {
            validPost = false;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
            chkBWake.Checked = (false);
            dntPickerWake.Value = DateTime.Now;
            dntPickerStart.Value = DateTime.Now;
            dntPickerend.Value = DateTime.Now;
        }

        private bool ValidateBookingNumber()
        {
            if(!String.IsNullOrEmpty(txtBookingNr.Text) && txtBookingNr.Text.All(char.IsDigit))
            {
                return true;
            }
            else
                return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validPost == true)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure?", "Delete post?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    int bnr;
                    int.TryParse(txtBookingNr.Text, out bnr);
                    int del = dbHandler.DeletePost(bnr);
                    ResetValues();
                }
            }
            
        }
    }
}
