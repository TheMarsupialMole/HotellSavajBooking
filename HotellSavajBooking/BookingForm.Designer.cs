namespace HotellSavajBooking
{
    partial class BookingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.dtpWakeupTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.checkWakeupCall = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkMinibar = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypOfRoom = new System.Windows.Forms.ComboBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listAvailableRooms = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Savaj Booking";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchRoom);
            this.groupBox1.Controls.Add(this.dtpWakeupTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkWakeupCall);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkMinibar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTypOfRoom);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking information";
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Location = new System.Drawing.Point(10, 220);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(236, 23);
            this.btnSearchRoom.TabIndex = 8;
            this.btnSearchRoom.Text = "Search for available rooms";
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpWakeupTime
            // 
            this.dtpWakeupTime.CustomFormat = "HH:mm";
            this.dtpWakeupTime.Enabled = false;
            this.dtpWakeupTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWakeupTime.Location = new System.Drawing.Point(149, 194);
            this.dtpWakeupTime.Name = "dtpWakeupTime";
            this.dtpWakeupTime.ShowUpDown = true;
            this.dtpWakeupTime.Size = new System.Drawing.Size(97, 20);
            this.dtpWakeupTime.TabIndex = 7;
            this.dtpWakeupTime.Value = new System.DateTime(2016, 5, 18, 7, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "End date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(149, 123);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpEndDate.Size = new System.Drawing.Size(97, 20);
            this.dtpEndDate.TabIndex = 4;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(149, 97);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(97, 20);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Start date";
            // 
            // checkWakeupCall
            // 
            this.checkWakeupCall.AutoSize = true;
            this.checkWakeupCall.Location = new System.Drawing.Point(202, 171);
            this.checkWakeupCall.Name = "checkWakeupCall";
            this.checkWakeupCall.Size = new System.Drawing.Size(44, 17);
            this.checkWakeupCall.TabIndex = 6;
            this.checkWakeupCall.Text = "Yes";
            this.checkWakeupCall.UseVisualStyleBackColor = true;
            this.checkWakeupCall.CheckedChanged += new System.EventHandler(this.checkWakeupCall_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Do you want a wakeup call?";
            // 
            // checkMinibar
            // 
            this.checkMinibar.AutoSize = true;
            this.checkMinibar.Location = new System.Drawing.Point(202, 149);
            this.checkMinibar.Name = "checkMinibar";
            this.checkMinibar.Size = new System.Drawing.Size(44, 17);
            this.checkMinibar.TabIndex = 5;
            this.checkMinibar.Text = "Yes";
            this.checkMinibar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Do you want a mini bar?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type of room";
            // 
            // cbTypOfRoom
            // 
            this.cbTypOfRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypOfRoom.FormattingEnabled = true;
            this.cbTypOfRoom.Location = new System.Drawing.Point(82, 70);
            this.cbTypOfRoom.Name = "cbTypOfRoom";
            this.cbTypOfRoom.Size = new System.Drawing.Size(164, 21);
            this.cbTypOfRoom.TabIndex = 2;
            this.cbTypOfRoom.SelectedIndexChanged += new System.EventHandler(this.cbTypOfRoom_SelectedIndexChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(82, 19);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(164, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(82, 44);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(164, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First name";
            // 
            // listAvailableRooms
            // 
            this.listAvailableRooms.FormattingEnabled = true;
            this.listAvailableRooms.Location = new System.Drawing.Point(6, 19);
            this.listAvailableRooms.Name = "listAvailableRooms";
            this.listAvailableRooms.Size = new System.Drawing.Size(119, 186);
            this.listAvailableRooms.TabIndex = 2;
            this.listAvailableRooms.SelectedIndexChanged += new System.EventHandler(this.listAvailableRooms_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBookRoom);
            this.groupBox2.Controls.Add(this.listAvailableRooms);
            this.groupBox2.Location = new System.Drawing.Point(285, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 259);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available rooms";
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(6, 220);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(119, 23);
            this.btnBookRoom.TabIndex = 3;
            this.btnBookRoom.Text = "Book selected room";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Savaj Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookingForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypOfRoom;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkWakeupCall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkMinibar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpWakeupTime;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.ListBox listAvailableRooms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBookRoom;
    }
}