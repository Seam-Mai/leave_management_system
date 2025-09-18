using System.Windows.Forms;

namespace leave_management_system.Dashboard.Manager
{
    partial class ManagerrequestLeave
    {/// <summary> 
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
            this.Mtxt_request = new System.Windows.Forms.Label();
            this.Mcomleavetype = new System.Windows.Forms.ComboBox();
            this.MdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Mleavepanel1 = new System.Windows.Forms.Panel();
            this.Mtxtfilechose = new System.Windows.Forms.Label();
            this.Mbtnchosefile = new System.Windows.Forms.Button();
            this.Mtxtreason = new System.Windows.Forms.Label();
            this.MtextBox1 = new System.Windows.Forms.TextBox();
            this.Mtxtleavetakendays = new System.Windows.Forms.Label();
            this.Mtxtenddate = new System.Windows.Forms.Label();
            this.Mtxtstartdate = new System.Windows.Forms.Label();
            this.Mtxtleavetype = new System.Windows.Forms.Label();
            this.MdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mleavepanel2 = new System.Windows.Forms.Panel();
            this.MdataGridView2 = new System.Windows.Forms.DataGridView();
            this.Mtxtsearch = new System.Windows.Forms.Label();
            this.Mcomsort = new System.Windows.Forms.ComboBox();
            this.Mbtnsubmit = new System.Windows.Forms.Button();
            this.Mbtnclear = new System.Windows.Forms.Button();
            this.Mbtnaddown = new System.Windows.Forms.Button();
            this.Mtxthistory = new System.Windows.Forms.Label();
            this.Mleavepanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MdataGridView1)).BeginInit();
            this.Mleavepanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MdataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Mtxt_request
            // 
            this.Mtxt_request.AutoSize = true;
            this.Mtxt_request.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxt_request.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxt_request.Location = new System.Drawing.Point(20, 16);
            this.Mtxt_request.Name = "Mtxt_request";
            this.Mtxt_request.Size = new System.Drawing.Size(201, 37);
            this.Mtxt_request.TabIndex = 0;
            this.Mtxt_request.Text = "Request Leave";
            this.Mtxt_request.Click += new System.EventHandler(this.Mtxt_request_Click_1);
            // 
            // Mcomleavetype
            // 
            this.Mcomleavetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mcomleavetype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mcomleavetype.FormattingEnabled = true;
            this.Mcomleavetype.Items.AddRange(new object[] {
            "Sick Leave",
            "Annual Leave",
            "Special Leave",
            "Unpaid Leave"});
            this.Mcomleavetype.Location = new System.Drawing.Point(30, 48);
            this.Mcomleavetype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mcomleavetype.Name = "Mcomleavetype";
            this.Mcomleavetype.Size = new System.Drawing.Size(200, 28);
            this.Mcomleavetype.TabIndex = 1;
            this.Mcomleavetype.SelectedIndexChanged += new System.EventHandler(this.comleavetype_SelectedIndexChanged);
            // 
            // MdateTimePicker1
            // 
            this.MdateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MdateTimePicker1.Location = new System.Drawing.Point(280, 48);
            this.MdateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MdateTimePicker1.Name = "MdateTimePicker1";
            this.MdateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.MdateTimePicker1.TabIndex = 2;
            this.MdateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MdateTimePicker2
            // 
            this.MdateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MdateTimePicker2.Location = new System.Drawing.Point(530, 48);
            this.MdateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MdateTimePicker2.Name = "MdateTimePicker2";
            this.MdateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.MdateTimePicker2.TabIndex = 3;
            this.MdateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Mleavepanel1
            // 
            this.Mleavepanel1.BackColor = System.Drawing.Color.White;
            this.Mleavepanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mleavepanel1.Controls.Add(this.Mtxtfilechose);
            this.Mleavepanel1.Controls.Add(this.Mbtnchosefile);
            this.Mleavepanel1.Controls.Add(this.Mtxtreason);
            this.Mleavepanel1.Controls.Add(this.MtextBox1);
            this.Mleavepanel1.Controls.Add(this.Mtxtleavetakendays);
            this.Mleavepanel1.Controls.Add(this.Mtxtenddate);
            this.Mleavepanel1.Controls.Add(this.Mtxtstartdate);
            this.Mleavepanel1.Controls.Add(this.Mtxtleavetype);
            this.Mleavepanel1.Controls.Add(this.MdataGridView1);
            this.Mleavepanel1.Controls.Add(this.Mcomleavetype);
            this.Mleavepanel1.Controls.Add(this.MdateTimePicker2);
            this.Mleavepanel1.Controls.Add(this.MdateTimePicker1);
            this.Mleavepanel1.Location = new System.Drawing.Point(41, 55);
            this.Mleavepanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mleavepanel1.Name = "Mleavepanel1";
            this.Mleavepanel1.Size = new System.Drawing.Size(1019, 320);
            this.Mleavepanel1.TabIndex = 4;
            // 
            // Mtxtfilechose
            // 
            this.Mtxtfilechose.AutoSize = true;
            this.Mtxtfilechose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtfilechose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Mtxtfilechose.Location = new System.Drawing.Point(760, 284);
            this.Mtxtfilechose.Name = "Mtxtfilechose";
            this.Mtxtfilechose.Size = new System.Drawing.Size(54, 20);
            this.Mtxtfilechose.TabIndex = 12;
            this.Mtxtfilechose.Text = "No file";
            // 
            // Mbtnchosefile
            // 
            this.Mbtnchosefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.Mbtnchosefile.FlatAppearance.BorderSize = 0;
            this.Mbtnchosefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mbtnchosefile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mbtnchosefile.ForeColor = System.Drawing.Color.White;
            this.Mbtnchosefile.Location = new System.Drawing.Point(760, 248);
            this.Mbtnchosefile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mbtnchosefile.Name = "Mbtnchosefile";
            this.Mbtnchosefile.Size = new System.Drawing.Size(100, 28);
            this.Mbtnchosefile.TabIndex = 11;
            this.Mbtnchosefile.Text = "Choose File";
            this.Mbtnchosefile.UseVisualStyleBackColor = false;
            // 
            // Mtxtreason
            // 
            this.Mtxtreason.AutoSize = true;
            this.Mtxtreason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtreason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxtreason.Location = new System.Drawing.Point(30, 228);
            this.Mtxtreason.Name = "Mtxtreason";
            this.Mtxtreason.Size = new System.Drawing.Size(60, 20);
            this.Mtxtreason.TabIndex = 10;
            this.Mtxtreason.Text = "Reason";
            // 
            // MtextBox1
            // 
            this.MtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtextBox1.Location = new System.Drawing.Point(30, 248);
            this.MtextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MtextBox1.Multiline = true;
            this.MtextBox1.Name = "MtextBox1";
            this.MtextBox1.Size = new System.Drawing.Size(700, 56);
            this.MtextBox1.TabIndex = 9;
            // 
            // Mtxtleavetakendays
            // 
            this.Mtxtleavetakendays.AutoSize = true;
            this.Mtxtleavetakendays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtleavetakendays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxtleavetakendays.Location = new System.Drawing.Point(26, 78);
            this.Mtxtleavetakendays.Name = "Mtxtleavetakendays";
            this.Mtxtleavetakendays.Size = new System.Drawing.Size(132, 20);
            this.Mtxtleavetakendays.TabIndex = 8;
            this.Mtxtleavetakendays.Text = "Leave Taken Days";
            // 
            // Mtxtenddate
            // 
            this.Mtxtenddate.AutoSize = true;
            this.Mtxtenddate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtenddate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxtenddate.Location = new System.Drawing.Point(530, 28);
            this.Mtxtenddate.Name = "Mtxtenddate";
            this.Mtxtenddate.Size = new System.Drawing.Size(70, 20);
            this.Mtxtenddate.TabIndex = 7;
            this.Mtxtenddate.Text = "End Date";
            // 
            // Mtxtstartdate
            // 
            this.Mtxtstartdate.AutoSize = true;
            this.Mtxtstartdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtstartdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxtstartdate.Location = new System.Drawing.Point(280, 28);
            this.Mtxtstartdate.Name = "Mtxtstartdate";
            this.Mtxtstartdate.Size = new System.Drawing.Size(76, 20);
            this.Mtxtstartdate.TabIndex = 6;
            this.Mtxtstartdate.Text = "Start Date";
            // 
            // Mtxtleavetype
            // 
            this.Mtxtleavetype.AutoSize = true;
            this.Mtxtleavetype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtleavetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxtleavetype.Location = new System.Drawing.Point(30, 28);
            this.Mtxtleavetype.Name = "Mtxtleavetype";
            this.Mtxtleavetype.Size = new System.Drawing.Size(82, 20);
            this.Mtxtleavetype.TabIndex = 5;
            this.Mtxtleavetype.Text = "Leave Type";
            // 
            // MdataGridView1
            // 
            this.MdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.MdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MdataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MdataGridView1.Location = new System.Drawing.Point(30, 106);
            this.MdataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MdataGridView1.Name = "MdataGridView1";
            this.MdataGridView1.RowHeadersVisible = false;
            this.MdataGridView1.RowHeadersWidth = 51;
            this.MdataGridView1.RowTemplate.Height = 24;
            this.MdataGridView1.Size = new System.Drawing.Size(959, 120);
            this.MdataGridView1.TabIndex = 4;
            // 
            // Mleavepanel2
            // 
            this.Mleavepanel2.BackColor = System.Drawing.Color.White;
            this.Mleavepanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mleavepanel2.Controls.Add(this.MdataGridView2);
            this.Mleavepanel2.Controls.Add(this.Mtxtsearch);
            this.Mleavepanel2.Controls.Add(this.Mcomsort);
            this.Mleavepanel2.Controls.Add(this.Mbtnsubmit);
            this.Mleavepanel2.Controls.Add(this.Mbtnclear);
            this.Mleavepanel2.Controls.Add(this.Mbtnaddown);
            this.Mleavepanel2.Location = new System.Drawing.Point(41, 441);
            this.Mleavepanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mleavepanel2.Name = "Mleavepanel2";
            this.Mleavepanel2.Size = new System.Drawing.Size(1019, 240);
            this.Mleavepanel2.TabIndex = 5;
            // 
            // MdataGridView2
            // 
            this.MdataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.MdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MdataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MdataGridView2.Location = new System.Drawing.Point(30, 80);
            this.MdataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MdataGridView2.Name = "MdataGridView2";
            this.MdataGridView2.RowHeadersVisible = false;
            this.MdataGridView2.RowHeadersWidth = 51;
            this.MdataGridView2.RowTemplate.Height = 24;
            this.MdataGridView2.Size = new System.Drawing.Size(959, 80);
            this.MdataGridView2.TabIndex = 6;
            // 
            // Mtxtsearch
            // 
            this.Mtxtsearch.AutoSize = true;
            this.Mtxtsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxtsearch.Location = new System.Drawing.Point(30, 28);
            this.Mtxtsearch.Name = "Mtxtsearch";
            this.Mtxtsearch.Size = new System.Drawing.Size(60, 20);
            this.Mtxtsearch.TabIndex = 5;
            this.Mtxtsearch.Text = "Sort By";
            // 
            // Mcomsort
            // 
            this.Mcomsort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mcomsort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mcomsort.FormattingEnabled = true;
            this.Mcomsort.Items.AddRange(new object[] {
            "HR",
            "MANAGER"});
            this.Mcomsort.Location = new System.Drawing.Point(30, 48);
            this.Mcomsort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mcomsort.Name = "Mcomsort";
            this.Mcomsort.Size = new System.Drawing.Size(200, 28);
            this.Mcomsort.TabIndex = 4;
            // 
            // Mbtnsubmit
            // 
            this.Mbtnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.Mbtnsubmit.FlatAppearance.BorderSize = 0;
            this.Mbtnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mbtnsubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mbtnsubmit.ForeColor = System.Drawing.Color.White;
            this.Mbtnsubmit.Location = new System.Drawing.Point(889, 47);
            this.Mbtnsubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mbtnsubmit.Name = "Mbtnsubmit";
            this.Mbtnsubmit.Size = new System.Drawing.Size(100, 28);
            this.Mbtnsubmit.TabIndex = 3;
            this.Mbtnsubmit.Text = "Submit";
            this.Mbtnsubmit.UseVisualStyleBackColor = false;
            // 
            // Mbtnclear
            // 
            this.Mbtnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Mbtnclear.FlatAppearance.BorderSize = 0;
            this.Mbtnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mbtnclear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mbtnclear.ForeColor = System.Drawing.Color.White;
            this.Mbtnclear.Location = new System.Drawing.Point(760, 47);
            this.Mbtnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mbtnclear.Name = "Mbtnclear";
            this.Mbtnclear.Size = new System.Drawing.Size(100, 28);
            this.Mbtnclear.TabIndex = 1;
            this.Mbtnclear.Text = "Clear";
            this.Mbtnclear.UseVisualStyleBackColor = false;
            // 
            // Mbtnaddown
            // 
            this.Mbtnaddown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.Mbtnaddown.FlatAppearance.BorderSize = 0;
            this.Mbtnaddown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mbtnaddown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mbtnaddown.ForeColor = System.Drawing.Color.White;
            this.Mbtnaddown.Location = new System.Drawing.Point(236, 48);
            this.Mbtnaddown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mbtnaddown.Name = "Mbtnaddown";
            this.Mbtnaddown.Size = new System.Drawing.Size(100, 28);
            this.Mbtnaddown.TabIndex = 0;
            this.Mbtnaddown.Text = "Add Own";
            this.Mbtnaddown.UseVisualStyleBackColor = false;
            this.Mbtnaddown.Click += new System.EventHandler(this.btnaddown_Click);
            // 
            // Mtxthistory
            // 
            this.Mtxthistory.AutoSize = true;
            this.Mtxthistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxthistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxthistory.Location = new System.Drawing.Point(22, 411);
            this.Mtxthistory.Name = "Mtxthistory";
            this.Mtxthistory.Size = new System.Drawing.Size(142, 28);
            this.Mtxthistory.TabIndex = 6;
            this.Mtxthistory.Text = "Leave History";
            // 
            // RequestLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.Mtxthistory);
            this.Controls.Add(this.Mleavepanel2);
            this.Controls.Add(this.Mleavepanel1);
            this.Controls.Add(this.Mtxt_request);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RequestLeave";
            this.Size = new System.Drawing.Size(1147, 710);
            this.Load += new System.EventHandler(this.MrequestLeaveLoad);
            this.Mleavepanel1.ResumeLayout(false);
            this.Mleavepanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MdataGridView1)).EndInit();
            this.Mleavepanel2.ResumeLayout(false);
            this.Mleavepanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MdataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Mtxt_request;
        private ComboBox Mcomleavetype;
        private DateTimePicker MdateTimePicker1;
        private DateTimePicker MdateTimePicker2;
        private Panel Mleavepanel1;
        private DataGridView MdataGridView1;
        private Label Mtxtfilechose;
        private Button Mbtnchosefile;
        private Label Mtxtreason;
        private TextBox MtextBox1;
        private Label Mtxtleavetakendays;
        private Label Mtxtenddate;
        private Label Mtxtstartdate;
        private Label Mtxtleavetype;
        private Panel Mleavepanel2;
        private DataGridView MdataGridView2;
        private Label Mtxtsearch;
        private ComboBox Mcomsort;
        private Button Mbtnsubmit;
        private Button Mbtnclear;
        private Button Mbtnaddown;
        private Label Mtxthistory;
    }
}
