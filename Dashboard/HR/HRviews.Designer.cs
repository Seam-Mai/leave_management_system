namespace leave_management_system.Dashboard.HR
{
    partial class HRviews
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HRtxtreport = new System.Windows.Forms.Label();
            this.HRdataGridView1 = new System.Windows.Forms.DataGridView();
            this.HRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HREndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRNoOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRAttachment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRbtnPrevious = new System.Windows.Forms.Button();
            this.HRbtnNext = new System.Windows.Forms.Button();
            this.HRlblPage = new System.Windows.Forms.Label();
            this.HRtxtSearch = new System.Windows.Forms.TextBox();
            this.HRbtnSearch = new System.Windows.Forms.Button();
            this.HRbtnreaset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HRdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HRtxtreport
            // 
            this.HRtxtreport.AutoSize = true;
            this.HRtxtreport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRtxtreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRtxtreport.Location = new System.Drawing.Point(20, 20);
            this.HRtxtreport.Name = "HRtxtreport";
            this.HRtxtreport.Size = new System.Drawing.Size(262, 28);
            this.HRtxtreport.TabIndex = 0;
            this.HRtxtreport.Text = "Report and View All Leave";
            // 
            // HRdataGridView1
            // 
            this.HRdataGridView1.AllowUserToAddRows = false;
            this.HRdataGridView1.AllowUserToDeleteRows = false;
            this.HRdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.HRdataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HRdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HRdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HRdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HRID,
            this.HRFullName,
            this.HRLeaveType,
            this.HRStartDate,
            this.HREndDate,
            this.HRNoOfDays,
            this.HRReason,
            this.HRAttachment,
            this.HRStatus,
            this.HRAction});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HRdataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.HRdataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.HRdataGridView1.Location = new System.Drawing.Point(25, 127);
            this.HRdataGridView1.Name = "HRdataGridView1";
            this.HRdataGridView1.RowHeadersVisible = false;
            this.HRdataGridView1.RowHeadersWidth = 51;
            this.HRdataGridView1.RowTemplate.Height = 24;
            this.HRdataGridView1.Size = new System.Drawing.Size(999, 225);
            this.HRdataGridView1.TabIndex = 1;
            this.HRdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HRdataGridView1_CellContentClick);
            // 
            // HRID
            // 
            this.HRID.HeaderText = "ID";
            this.HRID.MinimumWidth = 6;
            this.HRID.Name = "HRID";
            this.HRID.Width = 125;
            // 
            // HRFullName
            // 
            this.HRFullName.HeaderText = "FullName";
            this.HRFullName.MinimumWidth = 6;
            this.HRFullName.Name = "HRFullName";
            this.HRFullName.Width = 125;
            // 
            // HRLeaveType
            // 
            this.HRLeaveType.HeaderText = "LeaveType";
            this.HRLeaveType.MinimumWidth = 6;
            this.HRLeaveType.Name = "HRLeaveType";
            this.HRLeaveType.Width = 125;
            // 
            // HRStartDate
            // 
            this.HRStartDate.HeaderText = "StartDate";
            this.HRStartDate.MinimumWidth = 6;
            this.HRStartDate.Name = "HRStartDate";
            this.HRStartDate.Width = 125;
            // 
            // HREndDate
            // 
            this.HREndDate.HeaderText = "EndDate";
            this.HREndDate.MinimumWidth = 6;
            this.HREndDate.Name = "HREndDate";
            this.HREndDate.Width = 125;
            // 
            // HRNoOfDays
            // 
            this.HRNoOfDays.HeaderText = "NoOfDays";
            this.HRNoOfDays.MinimumWidth = 6;
            this.HRNoOfDays.Name = "HRNoOfDays";
            this.HRNoOfDays.Width = 125;
            // 
            // HRReason
            // 
            this.HRReason.HeaderText = "Reason";
            this.HRReason.MinimumWidth = 6;
            this.HRReason.Name = "HRReason";
            this.HRReason.Width = 125;
            // 
            // HRAttachment
            // 
            this.HRAttachment.HeaderText = "Attachment";
            this.HRAttachment.MinimumWidth = 6;
            this.HRAttachment.Name = "HRAttachment";
            this.HRAttachment.Width = 125;
            // 
            // HRStatus
            // 
            this.HRStatus.HeaderText = "Status";
            this.HRStatus.MinimumWidth = 6;
            this.HRStatus.Name = "HRStatus";
            this.HRStatus.Width = 125;
            // 
            // HRAction
            // 
            this.HRAction.HeaderText = "Action";
            this.HRAction.MinimumWidth = 6;
            this.HRAction.Name = "HRAction";
            this.HRAction.Width = 125;
            // 
            // HRbtnPrevious
            // 
            this.HRbtnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.HRbtnPrevious.FlatAppearance.BorderSize = 0;
            this.HRbtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRbtnPrevious.ForeColor = System.Drawing.Color.White;
            this.HRbtnPrevious.Location = new System.Drawing.Point(36, 374);
            this.HRbtnPrevious.Name = "HRbtnPrevious";
            this.HRbtnPrevious.Size = new System.Drawing.Size(100, 30);
            this.HRbtnPrevious.TabIndex = 2;
            this.HRbtnPrevious.Text = "Previous";
            this.HRbtnPrevious.UseVisualStyleBackColor = false;
            this.HRbtnPrevious.Click += new System.EventHandler(this.HRbtnPrevious_Click);
            // 
            // HRbtnNext
            // 
            this.HRbtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.HRbtnNext.FlatAppearance.BorderSize = 0;
            this.HRbtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRbtnNext.ForeColor = System.Drawing.Color.White;
            this.HRbtnNext.Location = new System.Drawing.Point(146, 374);
            this.HRbtnNext.Name = "HRbtnNext";
            this.HRbtnNext.Size = new System.Drawing.Size(100, 30);
            this.HRbtnNext.TabIndex = 3;
            this.HRbtnNext.Text = "Next";
            this.HRbtnNext.UseVisualStyleBackColor = false;
            this.HRbtnNext.Click += new System.EventHandler(this.HRbtnNext_Click);
            // 
            // HRlblPage
            // 
            this.HRlblPage.AutoSize = true;
            this.HRlblPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRlblPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRlblPage.Location = new System.Drawing.Point(256, 379);
            this.HRlblPage.Name = "HRlblPage";
            this.HRlblPage.Size = new System.Drawing.Size(83, 20);
            this.HRlblPage.TabIndex = 4;
            this.HRlblPage.Text = "Page 1 of 1";
            // 
            // HRtxtSearch
            // 
            this.HRtxtSearch.Location = new System.Drawing.Point(537, 72);
            this.HRtxtSearch.Multiline = true;
            this.HRtxtSearch.Name = "HRtxtSearch";
            this.HRtxtSearch.Size = new System.Drawing.Size(240, 37);
            this.HRtxtSearch.TabIndex = 5;
            this.HRtxtSearch.TextChanged += new System.EventHandler(this.HRtxtSearch_TextChanged);
            // 
            // HRbtnSearch
            // 
            this.HRbtnSearch.Location = new System.Drawing.Point(792, 73);
            this.HRbtnSearch.Name = "HRbtnSearch";
            this.HRbtnSearch.Size = new System.Drawing.Size(89, 36);
            this.HRbtnSearch.TabIndex = 6;
            this.HRbtnSearch.Text = "Search";
            this.HRbtnSearch.UseVisualStyleBackColor = true;
            // 
            // HRbtnreaset
            // 
            this.HRbtnreaset.Location = new System.Drawing.Point(887, 72);
            this.HRbtnreaset.Name = "HRbtnreaset";
            this.HRbtnreaset.Size = new System.Drawing.Size(89, 36);
            this.HRbtnreaset.TabIndex = 7;
            this.HRbtnreaset.Text = "Reaset";
            this.HRbtnreaset.UseVisualStyleBackColor = true;
            this.HRbtnreaset.Click += new System.EventHandler(this.HRbtnReset_Click);
            // 
            // HRviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.HRbtnreaset);
            this.Controls.Add(this.HRbtnSearch);
            this.Controls.Add(this.HRtxtSearch);
            this.Controls.Add(this.HRlblPage);
            this.Controls.Add(this.HRbtnNext);
            this.Controls.Add(this.HRbtnPrevious);
            this.Controls.Add(this.HRdataGridView1);
            this.Controls.Add(this.HRtxtreport);
            this.Name = "HRviews";
            this.Size = new System.Drawing.Size(1174, 591);
            ((System.ComponentModel.ISupportInitialize)(this.HRdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HRtxtreport;
        
        private System.Windows.Forms.Button HRbtnPrevious;
        private System.Windows.Forms.Button HRbtnNext;
        private System.Windows.Forms.Label HRlblPage;
        private System.Windows.Forms.DataGridView HRdataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HREndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRNoOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRAttachment;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRAction;
        private System.Windows.Forms.TextBox HRtxtSearch;
        private System.Windows.Forms.Button HRbtnSearch;
        private System.Windows.Forms.Button HRbtnreaset;
    }
}
