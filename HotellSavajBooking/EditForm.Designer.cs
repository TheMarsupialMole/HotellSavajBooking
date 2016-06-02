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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dntPickerWake = new System.Windows.Forms.DateTimePicker();
            this.chkBWake = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dntPickerend = new System.Windows.Forms.DateTimePicker();
            this.dntPickerStart = new System.Windows.Forms.DateTimePicker();
            this.txtBookingNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotSavDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dntPickerWake);
            this.groupBox1.Controls.Add(this.chkBWake);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRoomNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.dntPickerend);
            this.groupBox1.Controls.Add(this.dntPickerStart);
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 454);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "booking information";
            // 
            // dntPickerWake
            // 
            this.dntPickerWake.Location = new System.Drawing.Point(147, 347);
            this.dntPickerWake.Name = "dntPickerWake";
            this.dntPickerWake.Size = new System.Drawing.Size(201, 26);
            this.dntPickerWake.TabIndex = 22;
            // 
            // chkBWake
            // 
            this.chkBWake.AutoSize = true;
            this.chkBWake.Location = new System.Drawing.Point(147, 301);
            this.chkBWake.Name = "chkBWake";
            this.chkBWake.Size = new System.Drawing.Size(22, 21);
            this.chkBWake.TabIndex = 21;
            this.chkBWake.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "End Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Start Date";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(269, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 18;
            this.button4.Text = "CANCEL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Wake up time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wake up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(147, 249);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(205, 26);
            this.txtRoomNumber.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(147, 150);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(205, 26);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(147, 199);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(205, 26);
            this.txtLastName.TabIndex = 6;
            // 
            // dntPickerend
            // 
            this.dntPickerend.Location = new System.Drawing.Point(147, 97);
            this.dntPickerend.Name = "dntPickerend";
            this.dntPickerend.Size = new System.Drawing.Size(201, 26);
            this.dntPickerend.TabIndex = 5;
            // 
            // dntPickerStart
            // 
            this.dntPickerStart.Location = new System.Drawing.Point(147, 47);
            this.dntPickerStart.Name = "dntPickerStart";
            this.dntPickerStart.Size = new System.Drawing.Size(201, 26);
            this.dntPickerStart.TabIndex = 4;
            // 
            // txtBookingNr
            // 
            this.txtBookingNr.Location = new System.Drawing.Point(192, 23);
            this.txtBookingNr.Name = "txtBookingNr";
            this.txtBookingNr.Size = new System.Drawing.Size(117, 26);
            this.txtBookingNr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter booking number: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookingNr);
            this.Name = "EditForm";
            this.Text = "Hotel Savaj Editform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotSavDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotSavDBDataSet hotSavDBDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotSavDBDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private HotSavDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HotSavDBDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dntPickerend;
        private System.Windows.Forms.DateTimePicker dntPickerStart;
        private System.Windows.Forms.DateTimePicker dntPickerWake;
        private System.Windows.Forms.CheckBox chkBWake;
        private System.Windows.Forms.TextBox txtBookingNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}