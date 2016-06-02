using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace HotellSavajBooking
{
    /// <summary>
    /// Class written by Radovan Mojsovski 
    /// 
    /// This class is for the For that handles the booking System. The user enters the values needed 
    /// for a search and gets a list of available rooms. The user can then book the selected room in the list.
    /// The Foorm also has an option of changing som of the booking data. 
    /// </summary>
    public partial class BookingForm : Form
    {
        // Instance of the DBHandler
        private readonly DbHandler _dbHandler = new DbHandler();
        // An arraylist for storing the rooms that ar being searched
        private ArrayList _roomList = new ArrayList();

        /// <summary>
        /// Default constructor that initializes the components
        /// </summary>
        public BookingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that executes when the form loads and initiates the Gui-
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">the event arguments</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGui();
        }

        /// <summary>
        /// Method for initializing the Gui.
        /// </summary>
        private void InitializeGui()
        {
            foreach (string str in Enum.GetNames(typeof(RoomType)))
            {
                cbTypOfRoom.Items.Add(str.Replace("_", " "));
                cbTypOfRoom.SelectedIndex = 0;
            }
            btnBookRoom.Enabled = false;
        }

        /// <summary>
        /// Event handler that executes when the checkbox for wake up call is changed
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the event arguments</param>
        private void checkWakeupCall_CheckedChanged(object sender, EventArgs e)
        {
            dtpWakeupTime.Enabled = checkWakeupCall.Checked;
        }

        /// <summary>
        /// Event handler for the search room button.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the event arguments</param>
        private void btnSearchRoom_Click(object sender, EventArgs e)
        {

            _roomList = _dbHandler.GetAvailableRooms(dtpStartDate.Value, dtpEndDate.Value, cbTypOfRoom.SelectedIndex, checkMinibar.Checked);
            listAvailableRooms.Items.Clear();
            listAvailableRooms.Items.AddRange(_roomList.ToArray());
        }


        /// <summary>
        /// Method that validates the form before it is posible to make a booking.
        /// </summary>
        /// <returns>Boolean for correct information in form</returns>
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

        /// <summary>
        ///  Event handler for when the Form is about to close. It makes the user confirm the action.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">event arguments</param>
        private void BookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Your exiting the program.", "Are you sure?",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) e.Cancel = true;
        }

        /// <summary>
        /// Event handler for when the datetimepicker for start date changes value to clear the search list.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the event arguments</param>
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            ClearSearch();
        }

        /// <summary>
        /// Event handler for when the datetimepicker for end date changes value to clear the search list.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the event arguments</param>
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            ClearSearch();
        }

        /// <summary>
        /// Event handler for when the combobox for the room type changes values to clear the search list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTypOfRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSearch();
        }

        /// <summary>
        /// Method for clearing the list och disabeling the booking button
        /// </summary>
        private void ClearSearch()
        {
            listAvailableRooms.Items.Clear();
            btnBookRoom.Enabled = false;
        }

        /// <summary>
        /// Eventhandler for when the user selects a listed room and enables the book room button
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the event arguments</param>
        private void listAvailableRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAvailableRooms.SelectedIndex > -1)
            {
                btnBookRoom.Enabled = true;
            }
        }

        /// <summary>
        /// Event handler for the book room button
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the event arguments</param>
        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                StringBuilder sb = BuildString();

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

        /// <summary>
        /// Method that builds the string that gives the user the booking information to confirm.
        /// </summary>
        /// <returns>the built string for display</returns>
        private StringBuilder BuildString()
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
            return sb;
        }

        /// <summary>
        /// Method that checkes if the value is changed for clearing the search
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the event arguments</param>
        private void checkMinibar_CheckedChanged(object sender, EventArgs e)
        {
            ClearSearch();
        }

        /// <summary>
        /// Event handler that opens the edit Form for editing a booking
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the event arguments</param>
        private void EditFormButton_Click(object sender, EventArgs e)
        {
            new EditForm().ShowDialog();
        }

        /// <summary>
        /// Method that clears all textfields and resets the values in comboboxes and 
        /// dateTimePickers
        /// </summary>
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
