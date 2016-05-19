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
        public EditForm()
        {
            InitializeComponent();
            DbHandler db = new DbHandler();

            db.test();
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
    }
}
