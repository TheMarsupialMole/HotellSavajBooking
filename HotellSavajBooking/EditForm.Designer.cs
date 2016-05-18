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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnNameNDateSearch = new System.Windows.Forms.Button();
            this.btnBookingSearch = new System.Windows.Forms.Button();
            this.txbBookingNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.btnNameNDateSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 165);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find booking by name and/or date";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(394, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(513, 144);
            this.listBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter booking date";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(106, 41);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(281, 26);
            this.txbName.TabIndex = 5;
            // 
            // btnNameNDateSearch
            // 
            this.btnNameNDateSearch.Location = new System.Drawing.Point(282, 126);
            this.btnNameNDateSearch.Name = "btnNameNDateSearch";
            this.btnNameNDateSearch.Size = new System.Drawing.Size(105, 32);
            this.btnNameNDateSearch.TabIndex = 6;
            this.btnNameNDateSearch.Text = "Search";
            this.btnNameNDateSearch.UseVisualStyleBackColor = true;
            this.btnNameNDateSearch.Click += new System.EventHandler(this.btnNameNDateSearch_Click);
            // 
            // btnBookingSearch
            // 
            this.btnBookingSearch.Location = new System.Drawing.Point(321, 3);
            this.btnBookingSearch.Name = "btnBookingSearch";
            this.btnBookingSearch.Size = new System.Drawing.Size(49, 31);
            this.btnBookingSearch.TabIndex = 12;
            this.btnBookingSearch.Text = "GO";
            this.btnBookingSearch.UseVisualStyleBackColor = true;
            this.btnBookingSearch.Click += new System.EventHandler(this.btnBookingSearch_Click);
            // 
            // txbBookingNr
            // 
            this.txbBookingNr.Location = new System.Drawing.Point(202, 3);
            this.txbBookingNr.Name = "txbBookingNr";
            this.txbBookingNr.Size = new System.Drawing.Size(100, 26);
            this.txbBookingNr.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter booking number";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBookingSearch);
            this.Controls.Add(this.txbBookingNr);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnNameNDateSearch;
        private System.Windows.Forms.Button btnBookingSearch;
        private System.Windows.Forms.TextBox txbBookingNr;
        private System.Windows.Forms.Label label1;
    }
}