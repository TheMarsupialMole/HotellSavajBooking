namespace HotellSavajBooking
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotSavDBDataSet = new HotellSavajBooking.HotSavDBDataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new HotellSavajBooking.HotSavDBDataSetTableAdapters.BookingTableAdapter();
            this.tableAdapterManager = new HotellSavajBooking.HotSavDBDataSetTableAdapters.TableAdapterManager();
            this.roomTableAdapter = new HotellSavajBooking.HotSavDBDataSetTableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotSavDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotSavDBDataSet;
            // 
            // hotSavDBDataSet
            // 
            this.hotSavDBDataSet.DataSetName = "HotSavDBDataSet";
            this.hotSavDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.hotSavDBDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.RoomTableAdapter = this.roomTableAdapter;
            this.tableAdapterManager.UpdateOrder = HotellSavajBooking.HotSavDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 599);
            this.Name = "EditForm";
            this.Text = "Editform";
            this.Load += new System.EventHandler(this.Editform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotSavDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HotSavDBDataSet hotSavDBDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotSavDBDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private HotSavDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HotSavDBDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
    }
}