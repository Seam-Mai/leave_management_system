using System.Windows.Forms;

namespace leave_management_system.Dashboard.HR
{
    partial class HRrequestLeave
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
            this.HRtxt_request = new System.Windows.Forms.Label();
            this.HRcomleavetype = new System.Windows.Forms.ComboBox();
            this.HRdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.HRdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.HRleavepanel1 = new System.Windows.Forms.Panel();
            this.HRtxtfilechose = new System.Windows.Forms.Label();
            this.HRbtnchosefile = new System.Windows.Forms.Button();
            this.HRtxtreason = new System.Windows.Forms.Label();
            this.HRtextBox1 = new System.Windows.Forms.TextBox();
            this.HRtxtleavetakendays = new System.Windows.Forms.Label();
            this.HRtxtenddate = new System.Windows.Forms.Label();
            this.HRtxtstartdate = new System.Windows.Forms.Label();
            this.HRtxtleavetype = new System.Windows.Forms.Label();
            this.HRdataGridView1 = new System.Windows.Forms.DataGridView();
            this.HRleavepanel2 = new System.Windows.Forms.Panel();
            this.HRdataGridView2 = new System.Windows.Forms.DataGridView();
            this.HRtxtsearch = new System.Windows.Forms.Label();
            this.HRcomsort = new System.Windows.Forms.ComboBox();
            this.HRbtnsubmit = new System.Windows.Forms.Button();
            this.HRbtnclear = new System.Windows.Forms.Button();
            this.HRbtnaddown = new System.Windows.Forms.Button();
            this.HRtxthistory = new System.Windows.Forms.Label();
            this.HRleavepanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRdataGridView1)).BeginInit();
            this.HRleavepanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRdataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // HRtxt_request
            // 
            this.HRtxt_request.AutoSize = true;
            this.HRtxt_request.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxt_request.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRtxt_request.Location = new System.Drawing.Point(20, 16);
            this.HRtxt_request.Name = "HRtxt_request";
            this.HRtxt_request.Size = new System.Drawing.Size(201, 37);
            this.HRtxt_request.TabIndex = 0;
            this.HRtxt_request.Text = "Request Leave";
            this.HRtxt_request.Click += new System.EventHandler(this.txt_request_Click_1);
            // 
            // HRcomleavetype
            // 
            this.HRcomleavetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HRcomleavetype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRcomleavetype.FormattingEnabled = true;
            this.HRcomleavetype.Items.AddRange(new object[] {
            "Sick Leave",
            "Annual Leave",
            "Special Leave",
            "Unpaid Leave"});
            this.HRcomleavetype.Location = new System.Drawing.Point(30, 48);
            this.HRcomleavetype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRcomleavetype.Name = "HRcomleavetype";
            this.HRcomleavetype.Size = new System.Drawing.Size(200, 28);
            this.HRcomleavetype.TabIndex = 1;
            this.HRcomleavetype.SelectedIndexChanged += new System.EventHandler(this.comleavetype_SelectedIndexChanged);
            // 
            // HRdateTimePicker1
            // 
            this.HRdateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HRdateTimePicker1.Location = new System.Drawing.Point(280, 48);
            this.HRdateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRdateTimePicker1.Name = "HRdateTimePicker1";
            this.HRdateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.HRdateTimePicker1.TabIndex = 2;
            this.HRdateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // HRdateTimePicker2
            // 
            this.HRdateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRdateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HRdateTimePicker2.Location = new System.Drawing.Point(530, 48);
            this.HRdateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRdateTimePicker2.Name = "HRdateTimePicker2";
            this.HRdateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.HRdateTimePicker2.TabIndex = 3;
            this.HRdateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // HRleavepanel1
            // 
            this.HRleavepanel1.BackColor = System.Drawing.Color.White;
            this.HRleavepanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HRleavepanel1.Controls.Add(this.HRtxtfilechose);
            this.HRleavepanel1.Controls.Add(this.HRbtnchosefile);
            this.HRleavepanel1.Controls.Add(this.HRtxtreason);
            this.HRleavepanel1.Controls.Add(this.HRtextBox1);
            this.HRleavepanel1.Controls.Add(this.HRtxtleavetakendays);
            this.HRleavepanel1.Controls.Add(this.HRtxtenddate);
            this.HRleavepanel1.Controls.Add(this.HRtxtstartdate);
            this.HRleavepanel1.Controls.Add(this.HRtxtleavetype);
            this.HRleavepanel1.Controls.Add(this.HRdataGridView1);
            this.HRleavepanel1.Controls.Add(this.HRcomleavetype);
            this.HRleavepanel1.Controls.Add(this.HRdateTimePicker2);
            this.HRleavepanel1.Controls.Add(this.HRdateTimePicker1);
            this.HRleavepanel1.Location = new System.Drawing.Point(41, 55);
            this.HRleavepanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRleavepanel1.Name = "HRleavepanel1";
            this.HRleavepanel1.Size = new System.Drawing.Size(1019, 320);
            this.HRleavepanel1.TabIndex = 4;
            // 
            // HRtxtfilechose
            // 
            this.HRtxtfilechose.AutoSize = true;
            this.HRtxtfilechose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxtfilechose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.HRtxtfilechose.Location = new System.Drawing.Point(760, 284);
            this.HRtxtfilechose.Name = "HRtxtfilechose";
            this.HRtxtfilechose.Size = new System.Drawing.Size(54, 20);
            this.HRtxtfilechose.TabIndex = 12;
            this.HRtxtfilechose.Text = "No file";
            // 
            // HRbtnchosefile
            // 
            this.HRbtnchosefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.HRbtnchosefile.FlatAppearance.BorderSize = 0;
            this.HRbtnchosefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnchosefile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRbtnchosefile.ForeColor = System.Drawing.Color.White;
            this.HRbtnchosefile.Location = new System.Drawing.Point(760, 248);
            this.HRbtnchosefile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRbtnchosefile.Name = "HRbtnchosefile";
            this.HRbtnchosefile.Size = new System.Drawing.Size(100, 28);
            this.HRbtnchosefile.TabIndex = 11;
            this.HRbtnchosefile.Text = "Choose File";
            this.HRbtnchosefile.UseVisualStyleBackColor = false;
            // 
            // HRtxtreason
            // 
            this.HRtxtreason.AutoSize = true;
            this.HRtxtreason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxtreason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRtxtreason.Location = new System.Drawing.Point(30, 228);
            this.HRtxtreason.Name = "HRtxtreason";
            this.HRtxtreason.Size = new System.Drawing.Size(60, 20);
            this.HRtxtreason.TabIndex = 10;
            this.HRtxtreason.Text = "Reason";
            // 
            // HRtextBox1
            // 
            this.HRtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HRtextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtextBox1.Location = new System.Drawing.Point(30, 248);
            this.HRtextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRtextBox1.Multiline = true;
            this.HRtextBox1.Name = "HRtextBox1";
            this.HRtextBox1.Size = new System.Drawing.Size(700, 56);
            this.HRtextBox1.TabIndex = 9;
            // 
            // HRtxtleavetakendays
            // 
            this.HRtxtleavetakendays.AutoSize = true;
            this.HRtxtleavetakendays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxtleavetakendays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRtxtleavetakendays.Location = new System.Drawing.Point(26, 78);
            this.HRtxtleavetakendays.Name = "HRtxtleavetakendays";
            this.HRtxtleavetakendays.Size = new System.Drawing.Size(132, 20);
            this.HRtxtleavetakendays.TabIndex = 8;
            this.HRtxtleavetakendays.Text = "Leave Taken Days";
            // 
            // HRtxtenddate
            // 
            this.HRtxtenddate.AutoSize = true;
            this.HRtxtenddate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxtenddate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRtxtenddate.Location = new System.Drawing.Point(530, 28);
            this.HRtxtenddate.Name = "HRtxtenddate";
            this.HRtxtenddate.Size = new System.Drawing.Size(70, 20);
            this.HRtxtenddate.TabIndex = 7;
            this.HRtxtenddate.Text = "End Date";
            // 
            // HRtxtstartdate
            // 
            this.HRtxtstartdate.AutoSize = true;
            this.HRtxtstartdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxtstartdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRtxtstartdate.Location = new System.Drawing.Point(280, 28);
            this.HRtxtstartdate.Name = "HRtxtstartdate";
            this.HRtxtstartdate.Size = new System.Drawing.Size(76, 20);
            this.HRtxtstartdate.TabIndex = 6;
            this.HRtxtstartdate.Text = "Start Date";
            // 
            // HRtxtleavetype
            // 
            this.HRtxtleavetype.AutoSize = true;
            this.HRtxtleavetype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxtleavetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRtxtleavetype.Location = new System.Drawing.Point(30, 28);
            this.HRtxtleavetype.Name = "HRtxtleavetype";
            this.HRtxtleavetype.Size = new System.Drawing.Size(82, 20);
            this.HRtxtleavetype.TabIndex = 5;
            this.HRtxtleavetype.Text = "Leave Type";
            // 
            // HRdataGridView1
            // 
            this.HRdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.HRdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HRdataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.HRdataGridView1.Location = new System.Drawing.Point(30, 106);
            this.HRdataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRdataGridView1.Name = "HRdataGridView1";
            this.HRdataGridView1.RowHeadersVisible = false;
            this.HRdataGridView1.RowHeadersWidth = 51;
            this.HRdataGridView1.RowTemplate.Height = 24;
            this.HRdataGridView1.Size = new System.Drawing.Size(959, 120);
            this.HRdataGridView1.TabIndex = 4;
            // 
            // HRleavepanel2
            // 
            this.HRleavepanel2.BackColor = System.Drawing.Color.White;
            this.HRleavepanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HRleavepanel2.Controls.Add(this.HRdataGridView2);
            this.HRleavepanel2.Controls.Add(this.HRtxtsearch);
            this.HRleavepanel2.Controls.Add(this.HRcomsort);
            this.HRleavepanel2.Controls.Add(this.HRbtnsubmit);
            this.HRleavepanel2.Controls.Add(this.HRbtnclear);
            this.HRleavepanel2.Controls.Add(this.HRbtnaddown);
            this.HRleavepanel2.Location = new System.Drawing.Point(41, 441);
            this.HRleavepanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRleavepanel2.Name = "HRleavepanel2";
            this.HRleavepanel2.Size = new System.Drawing.Size(1019, 240);
            this.HRleavepanel2.TabIndex = 5;
            // 
            // HRdataGridView2
            // 
            this.HRdataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.HRdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HRdataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.HRdataGridView2.Location = new System.Drawing.Point(30, 80);
            this.HRdataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRdataGridView2.Name = "HRdataGridView2";
            this.HRdataGridView2.RowHeadersVisible = false;
            this.HRdataGridView2.RowHeadersWidth = 51;
            this.HRdataGridView2.RowTemplate.Height = 24;
            this.HRdataGridView2.Size = new System.Drawing.Size(959, 80);
            this.HRdataGridView2.TabIndex = 6;
            // 
            // HRtxtsearch
            // 
            this.HRtxtsearch.AutoSize = true;
            this.HRtxtsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRtxtsearch.Location = new System.Drawing.Point(30, 28);
            this.HRtxtsearch.Name = "HRtxtsearch";
            this.HRtxtsearch.Size = new System.Drawing.Size(60, 20);
            this.HRtxtsearch.TabIndex = 5;
            this.HRtxtsearch.Text = "Sort By";
            // 
            // HRcomsort
            // 
            this.HRcomsort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HRcomsort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRcomsort.FormattingEnabled = true;
            this.HRcomsort.Items.AddRange(new object[] {
            "HR",
            "MANAGER"});
            this.HRcomsort.Location = new System.Drawing.Point(30, 48);
            this.HRcomsort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRcomsort.Name = "HRcomsort";
            this.HRcomsort.Size = new System.Drawing.Size(200, 28);
            this.HRcomsort.TabIndex = 4;
            // 
            // HRbtnsubmit
            // 
            this.HRbtnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.HRbtnsubmit.FlatAppearance.BorderSize = 0;
            this.HRbtnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnsubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRbtnsubmit.ForeColor = System.Drawing.Color.White;
            this.HRbtnsubmit.Location = new System.Drawing.Point(889, 47);
            this.HRbtnsubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRbtnsubmit.Name = "HRbtnsubmit";
            this.HRbtnsubmit.Size = new System.Drawing.Size(100, 28);
            this.HRbtnsubmit.TabIndex = 3;
            this.HRbtnsubmit.Text = "Submit";
            this.HRbtnsubmit.UseVisualStyleBackColor = false;
            // 
            // HRbtnclear
            // 
            this.HRbtnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.HRbtnclear.FlatAppearance.BorderSize = 0;
            this.HRbtnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnclear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRbtnclear.ForeColor = System.Drawing.Color.White;
            this.HRbtnclear.Location = new System.Drawing.Point(760, 47);
            this.HRbtnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRbtnclear.Name = "HRbtnclear";
            this.HRbtnclear.Size = new System.Drawing.Size(100, 28);
            this.HRbtnclear.TabIndex = 1;
            this.HRbtnclear.Text = "Clear";
            this.HRbtnclear.UseVisualStyleBackColor = false;
            // 
            // HRbtnaddown
            // 
            this.HRbtnaddown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.HRbtnaddown.FlatAppearance.BorderSize = 0;
            this.HRbtnaddown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnaddown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRbtnaddown.ForeColor = System.Drawing.Color.White;
            this.HRbtnaddown.Location = new System.Drawing.Point(236, 48);
            this.HRbtnaddown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRbtnaddown.Name = "HRbtnaddown";
            this.HRbtnaddown.Size = new System.Drawing.Size(100, 28);
            this.HRbtnaddown.TabIndex = 0;
            this.HRbtnaddown.Text = "Add Own";
            this.HRbtnaddown.UseVisualStyleBackColor = false;
            this.HRbtnaddown.Click += new System.EventHandler(this.btnaddown_Click);
            // 
            // HRtxthistory
            // 
            this.HRtxthistory.AutoSize = true;
            this.HRtxthistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxthistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRtxthistory.Location = new System.Drawing.Point(22, 411);
            this.HRtxthistory.Name = "HRtxthistory";
            this.HRtxthistory.Size = new System.Drawing.Size(142, 28);
            this.HRtxthistory.TabIndex = 6;
            this.HRtxthistory.Text = "Leave History";
            // 
            // RequestLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.HRtxthistory);
            this.Controls.Add(this.HRleavepanel2);
            this.Controls.Add(this.HRleavepanel1);
            this.Controls.Add(this.HRtxt_request);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RequestLeave";
            this.Size = new System.Drawing.Size(1147, 710);
            this.Load += new System.EventHandler(this.RequestLeaveLoad);
            this.HRleavepanel1.ResumeLayout(false);
            this.HRleavepanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRdataGridView1)).EndInit();
            this.HRleavepanel2.ResumeLayout(false);
            this.HRleavepanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRdataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HRtxt_request;
        private ComboBox HRcomleavetype;
        private DateTimePicker HRdateTimePicker1;
        private DateTimePicker HRdateTimePicker2;
        private Panel HRleavepanel1;
        private DataGridView HRdataGridView1;
        private Label HRtxtfilechose;
        private Button HRbtnchosefile;
        private Label HRtxtreason;
        private TextBox HRtextBox1;
        private Label HRtxtleavetakendays;
        private Label HRtxtenddate;
        private Label HRtxtstartdate;
        private Label HRtxtleavetype;
        private Panel HRleavepanel2;
        private DataGridView HRdataGridView2;
        private Label HRtxtsearch;
        private ComboBox HRcomsort;
        private Button HRbtnsubmit;
        private Button HRbtnclear;
        private Button HRbtnaddown;
        private Label HRtxthistory;
    }
}
