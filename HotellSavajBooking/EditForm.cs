using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// class written by Ted Malmgren
/// </summary>
namespace HotellSavajBooking
{
    public partial class EditForm : Form
    {
        private DbHandler dbCon;
        private Booking bookingToEdit;
        public EditForm()
        {
            InitializeComponent();
        }

        private void btnBookingSearch_Click(object sender, EventArgs e)
        {
            ValidateAndGet(txbBookingNr.Text);
        }


        private void btnNameNDateSearch_Click(object sender, EventArgs e)
        {
            ValidateAndGetNameDate(txbName.Text, dateTimePicker1);
        }

        private void ValidateAndGet(string text)
        {
            if (!text.Equals(string.Empty))
                Console.Write("test");
                //bookingToEdit = dBCon(text);
        }

        private void ValidateAndGetNameDate(string name, DateTimePicker date)
        {
            if (!name.Equals(string.Empty))
                Console.Write("test");
            //bookingToEdit = dBCon(name, date);
        }

    }
}
