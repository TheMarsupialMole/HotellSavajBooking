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
    /// The class handles the editing or removal of a booking
    /// </summary>
    public partial class EditForm : Form
    {
        private DbHandler dbHandler;
        private bool validPost = false;
        private Booking currentBooking = null;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        public EditForm()
        {
            InitializeComponent();
            dbHandler = new DbHandler();    
        }

        /// <summary>
        /// Method that fills the differens areas in the edit form with Booking values
        /// </summary>
        /// <param name="b"></param>
        private void PopulateWindow(Booking b)
        {
            currentBooking = b;
            validPost = true;
            txtFirstName.Text = String.Empty + b.FirstName;
            txtLastName.Text = String.Empty + b.LastName;
            txtRoomNumber.Text = String.Empty + b.BookedId;
            chkBWake.Checked = (b.WakeUp);
            dntPickerWake.Value = b.WakeTime;
            dntPickerStart.Value = b.Startime;
            dntPickerend.Value = b.EndTime;
        }

        /// <summary>
        /// Method that clears the Booking values from the edit form
        /// </summary>
        private void ResetValues() 
        {
            currentBooking = null;
            validPost = false;
            txtBookingNr.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
            chkBWake.Checked = (false);
            dntPickerWake.Value = DateTime.Now;
            dntPickerStart.Value = DateTime.Now;
            dntPickerend.Value = DateTime.Now;
        }

        /// <summary>
        /// Method that checks to see if a number has been entered
        /// </summary>
        /// <returns></returns>
        private bool ValidateBookingNumber()
        {
            if(!String.IsNullOrEmpty(txtBookingNr.Text) && txtBookingNr.Text.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Not a valid booking number!", "Incorrect entry");
                return false;
            }
                
        }

        /// <summary>
        /// Method that handles the action when te "GO" button is pressed, fetches a booking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Method that handles the action of the cancellation button. 
        /// Closes the edit form if confirmed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method that handles the action of the delete button. 
        /// Deletes a Booking post from the database if confirmed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Method that handles the action of the "EDIT" button.
        /// Checks if changes has been made on the current booking and updates the database if confirmed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(currentBooking != null)
            {
                int bnr;
                int.TryParse(txtBookingNr.Text, out bnr);

                int o;
                int.TryParse(txtRoomNumber.Text, out o);

                Booking edited = new Booking(dntPickerStart.Value, dntPickerend.Value, txtFirstName.Text,
                    txtLastName.Text, o, chkBWake.Checked, dntPickerWake.Value);

                if (!edited.Equals(currentBooking))
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure?", "Update post?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        if(dbHandler.UpdatePost(edited, bnr) == 1);
                            ResetValues();
                    }
                }
                else
                    MessageBox.Show(this, "Nothing changed", "Unchanged Post");
            }
        }

        /// <summary>
        /// Handles the action of the form closing event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            int o;
            int.TryParse(txtRoomNumber.Text, out o);
            Booking edited = new Booking(dntPickerStart.Value, dntPickerend.Value, txtFirstName.Text,
                    txtLastName.Text, o, chkBWake.Checked, dntPickerWake.Value);

            if (currentBooking != null && !edited.Equals(currentBooking))
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
