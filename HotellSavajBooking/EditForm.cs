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
    public partial class EditForm : Form
    {
        private DbHandler db = new DbHandler();
        public EditForm()
        {
            InitializeComponent();       
            DateTime dts = DateTime.Parse("2016-02-12");
            DateTime dte = DateTime.Parse("2016-02-12");
            db.GetAvailableRooms(dts, dte, 0, false);
        }

        private void bookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotSavDBDataSet);

        }

        private void Editform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotSavDBDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotSavDBDataSet.Room);
            // TODO: This line of code loads data into the 'hotSavDBDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.hotSavDBDataSet.Booking);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateBookingNumber())
            {
                int bnr;
                int.TryParse(txtBookingNr.Text, out bnr);
                Booking b = db.GetBooking(bnr);
                PopulateWindow(b);
            }
        }

        private void PopulateWindow(Booking b)
        {
            txtFirstName.Text = "  "+ b.BookedRoom.RoomNumber;
            Console.Write("hej");
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
    }
}
