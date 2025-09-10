using System;
using System.Windows.Forms;


namespace leave_management_system.Dashboard.Employee
{
    partial class RequestLeave
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_request = new System.Windows.Forms.Label();
            this.comleavetype = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.leavepanel1 = new System.Windows.Forms.Panel();
            this.txtfilechose = new System.Windows.Forms.Label();
            this.btnchosefile = new System.Windows.Forms.Button();
            this.txtreason = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtleavetakendays = new System.Windows.Forms.Label();
            this.txtenddate = new System.Windows.Forms.Label();
            this.txtstartdate = new System.Windows.Forms.Label();
            this.txtleavetype = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leavepanel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.Label();
            this.comsort = new System.Windows.Forms.ComboBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnaddown = new System.Windows.Forms.Button();
            this.txthistory = new System.Windows.Forms.Label();
            this.leavepanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.leavepanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_request
            // 
            this.txt_request.AutoSize = true;
            this.txt_request.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_request.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txt_request.Location = new System.Drawing.Point(20, 16);
            this.txt_request.Name = "txt_request";
            this.txt_request.Size = new System.Drawing.Size(201, 37);
            this.txt_request.TabIndex = 0;
            this.txt_request.Text = "Request Leave";
            this.txt_request.Click += new System.EventHandler(this.txt_request_Click_1);
            // 
            // comleavetype
            // 
            this.comleavetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comleavetype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comleavetype.FormattingEnabled = true;
            this.comleavetype.Items.AddRange(new object[] {
            "Sick Leave",
            "Annual Leave",
            "Special Leave",
            "Unpaid Leave"});
            this.comleavetype.Location = new System.Drawing.Point(30, 48);
            this.comleavetype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comleavetype.Name = "comleavetype";
            this.comleavetype.Size = new System.Drawing.Size(200, 28);
            this.comleavetype.TabIndex = 1;
            this.comleavetype.SelectedIndexChanged += new System.EventHandler(this.comleavetype_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 48);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(530, 48);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // leavepanel1
            // 
            this.leavepanel1.BackColor = System.Drawing.Color.White;
            this.leavepanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leavepanel1.Controls.Add(this.txtfilechose);
            this.leavepanel1.Controls.Add(this.btnchosefile);
            this.leavepanel1.Controls.Add(this.txtreason);
            this.leavepanel1.Controls.Add(this.textBox1);
            this.leavepanel1.Controls.Add(this.txtleavetakendays);
            this.leavepanel1.Controls.Add(this.txtenddate);
            this.leavepanel1.Controls.Add(this.txtstartdate);
            this.leavepanel1.Controls.Add(this.txtleavetype);
            this.leavepanel1.Controls.Add(this.dataGridView1);
            this.leavepanel1.Controls.Add(this.comleavetype);
            this.leavepanel1.Controls.Add(this.dateTimePicker2);
            this.leavepanel1.Controls.Add(this.dateTimePicker1);
            this.leavepanel1.Location = new System.Drawing.Point(41, 55);
            this.leavepanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leavepanel1.Name = "leavepanel1";
            this.leavepanel1.Size = new System.Drawing.Size(1019, 320);
            this.leavepanel1.TabIndex = 4;
            // 
            // txtfilechose
            // 
            this.txtfilechose.AutoSize = true;
            this.txtfilechose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilechose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtfilechose.Location = new System.Drawing.Point(760, 284);
            this.txtfilechose.Name = "txtfilechose";
            this.txtfilechose.Size = new System.Drawing.Size(54, 20);
            this.txtfilechose.TabIndex = 12;
            this.txtfilechose.Text = "No file";
            // 
            // btnchosefile
            // 
            this.btnchosefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.btnchosefile.FlatAppearance.BorderSize = 0;
            this.btnchosefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchosefile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchosefile.ForeColor = System.Drawing.Color.White;
            this.btnchosefile.Location = new System.Drawing.Point(760, 248);
            this.btnchosefile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnchosefile.Name = "btnchosefile";
            this.btnchosefile.Size = new System.Drawing.Size(100, 28);
            this.btnchosefile.TabIndex = 11;
            this.btnchosefile.Text = "Choose File";
            this.btnchosefile.UseVisualStyleBackColor = false;
            // 
            // txtreason
            // 
            this.txtreason.AutoSize = true;
            this.txtreason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtreason.Location = new System.Drawing.Point(30, 228);
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(60, 20);
            this.txtreason.TabIndex = 10;
            this.txtreason.Text = "Reason";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 248);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(700, 56);
            this.textBox1.TabIndex = 9;
            // 
            // txtleavetakendays
            // 
            this.txtleavetakendays.AutoSize = true;
            this.txtleavetakendays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleavetakendays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtleavetakendays.Location = new System.Drawing.Point(26, 78);
            this.txtleavetakendays.Name = "txtleavetakendays";
            this.txtleavetakendays.Size = new System.Drawing.Size(132, 20);
            this.txtleavetakendays.TabIndex = 8;
            this.txtleavetakendays.Text = "Leave Taken Days";
            // 
            // txtenddate
            // 
            this.txtenddate.AutoSize = true;
            this.txtenddate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenddate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtenddate.Location = new System.Drawing.Point(530, 28);
            this.txtenddate.Name = "txtenddate";
            this.txtenddate.Size = new System.Drawing.Size(70, 20);
            this.txtenddate.TabIndex = 7;
            this.txtenddate.Text = "End Date";
            // 
            // txtstartdate
            // 
            this.txtstartdate.AutoSize = true;
            this.txtstartdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstartdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtstartdate.Location = new System.Drawing.Point(280, 28);
            this.txtstartdate.Name = "txtstartdate";
            this.txtstartdate.Size = new System.Drawing.Size(76, 20);
            this.txtstartdate.TabIndex = 6;
            this.txtstartdate.Text = "Start Date";
            // 
            // txtleavetype
            // 
            this.txtleavetype.AutoSize = true;
            this.txtleavetype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleavetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtleavetype.Location = new System.Drawing.Point(30, 28);
            this.txtleavetype.Name = "txtleavetype";
            this.txtleavetype.Size = new System.Drawing.Size(82, 20);
            this.txtleavetype.TabIndex = 5;
            this.txtleavetype.Text = "Leave Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView1.Location = new System.Drawing.Point(30, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 120);
            this.dataGridView1.TabIndex = 4;
            // 
            // leavepanel2
            // 
            this.leavepanel2.BackColor = System.Drawing.Color.White;
            this.leavepanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leavepanel2.Controls.Add(this.dataGridView2);
            this.leavepanel2.Controls.Add(this.txtsearch);
            this.leavepanel2.Controls.Add(this.comsort);
            this.leavepanel2.Controls.Add(this.btnsubmit);
            this.leavepanel2.Controls.Add(this.btnclear);
            this.leavepanel2.Controls.Add(this.btnaddown);
            this.leavepanel2.Location = new System.Drawing.Point(41, 441);
            this.leavepanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leavepanel2.Name = "leavepanel2";
            this.leavepanel2.Size = new System.Drawing.Size(1019, 240);
            this.leavepanel2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView2.Location = new System.Drawing.Point(30, 80);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(959, 80);
            this.dataGridView2.TabIndex = 6;
            // 
            // txtsearch
            // 
            this.txtsearch.AutoSize = true;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtsearch.Location = new System.Drawing.Point(30, 28);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(60, 20);
            this.txtsearch.TabIndex = 5;
            this.txtsearch.Text = "Sort By";
            // 
            // comsort
            // 
            this.comsort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comsort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comsort.FormattingEnabled = true;
            this.comsort.Items.AddRange(new object[] {
            "HR",
            "MANAGER"});
            this.comsort.Location = new System.Drawing.Point(30, 48);
            this.comsort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comsort.Name = "comsort";
            this.comsort.Size = new System.Drawing.Size(200, 28);
            this.comsort.TabIndex = 4;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnsubmit.FlatAppearance.BorderSize = 0;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.Location = new System.Drawing.Point(889, 47);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(100, 28);
            this.btnsubmit.TabIndex = 3;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(760, 47);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 28);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // btnaddown
            // 
            this.btnaddown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnaddown.FlatAppearance.BorderSize = 0;
            this.btnaddown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddown.ForeColor = System.Drawing.Color.White;
            this.btnaddown.Location = new System.Drawing.Point(236, 48);
            this.btnaddown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddown.Name = "btnaddown";
            this.btnaddown.Size = new System.Drawing.Size(100, 28);
            this.btnaddown.TabIndex = 0;
            this.btnaddown.Text = "Add Own";
            this.btnaddown.UseVisualStyleBackColor = false;
            this.btnaddown.Click += new System.EventHandler(this.btnaddown_Click);
            // 
            // txthistory
            // 
            this.txthistory.AutoSize = true;
            this.txthistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txthistory.Location = new System.Drawing.Point(22, 411);
            this.txthistory.Name = "txthistory";
            this.txthistory.Size = new System.Drawing.Size(142, 28);
            this.txthistory.TabIndex = 6;
            this.txthistory.Text = "Leave History";
            // 
            // RequestLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.txthistory);
            this.Controls.Add(this.leavepanel2);
            this.Controls.Add(this.leavepanel1);
            this.Controls.Add(this.txt_request);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RequestLeave";
            this.Size = new System.Drawing.Size(1147, 710);
            this.Load += new System.EventHandler(this.RequestLeaveLoad);
            this.leavepanel1.ResumeLayout(false);
            this.leavepanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.leavepanel2.ResumeLayout(false);
            this.leavepanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txt_request;
        private ComboBox comleavetype;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Panel leavepanel1;
        private DataGridView dataGridView1;
        private Label txtfilechose;
        private Button btnchosefile;
        private Label txtreason;
        private TextBox textBox1;
        private Label txtleavetakendays;
        private Label txtenddate;
        private Label txtstartdate;
        private Label txtleavetype;
        private Panel leavepanel2;
        private DataGridView dataGridView2;
        private Label txtsearch;
        private ComboBox comsort;
        private Button btnsubmit;
        private Button btnclear;
        private Button btnaddown;
        private Label txthistory;

        private void RequestLeaveLoad(object sender, EventArgs e)

        {

            try
            {

                dateTimePicker1.MinDate = DateTime.Today;
                dateTimePicker2.MinDate = dateTimePicker1.Value;
                comleavetype.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
            // Initialize DataGridView1 columns
            this.dataGridView1.Columns.Add("Id", "ID");
            this.dataGridView1.Columns.Add("LeaveType", "Leave Type");
            this.dataGridView1.Columns.Add("StartDate", "Start Date");
            this.dataGridView1.Columns.Add("EndDate", "End Date");

            // Initialize DataGridView2 columns
            this.dataGridView2.Columns.Add("Id", "ID");
            this.dataGridView2.Columns.Add("Type", "Type");
            this.dataGridView2.Columns.Add("StartDate", "Start Date");
            this.dataGridView2.Columns.Add("EndDate", "End Date");
            this.dataGridView2.Columns.Add("BalanceDay", "Balance Day");
            this.dataGridView2.Columns.Add("Reason", "Reason");
        }

        private void comleavetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLeaveTakenDays();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateLeaveTakenDays();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateLeaveTakenDays();
        }

        private void UpdateLeaveTakenDays()
        {
            if (comleavetype.SelectedIndex != -1 && dateTimePicker1.Value <= dateTimePicker2.Value)
            {
                dataGridView1.Rows.Clear();
                int id = dataGridView1.Rows.Count + 1;
                dataGridView1.Rows.Add(id, comleavetype.SelectedItem, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            }
        }

        private void btnaddown_Click(object sender, EventArgs e)
        {
            if (comleavetype.SelectedIndex != -1 && !string.IsNullOrEmpty(textBox1.Text) && dateTimePicker1.Value <= dateTimePicker2.Value)
            {
                int id = dataGridView2.Rows.Count + 1;
                TimeSpan duration = dateTimePicker2.Value - dateTimePicker1.Value;
                int balanceDay = (int)duration.TotalDays + 1; // Including start and end date
                dataGridView2.Rows.Add(id, comleavetype.SelectedItem, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), balanceDay, textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please fill all fields correctly and ensure Start Date is not after End Date.");
            }
        }
    }
}