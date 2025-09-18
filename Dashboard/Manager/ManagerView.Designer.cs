namespace leave_management_system.Dashboard.Manager
{
    partial class ManagerView
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
            this.Mtxtreport = new System.Windows.Forms.Label();
            this.MdataGridView1 = new System.Windows.Forms.DataGridView();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MNoOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAttachment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MbtnPrevious = new System.Windows.Forms.Button();
            this.MbtnNext = new System.Windows.Forms.Button();
            this.MlblPage = new System.Windows.Forms.Label();
            this.MtxtSearch = new System.Windows.Forms.TextBox();
            this.MbtnSearch = new System.Windows.Forms.Button();
            this.MbtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mtxtreport
            // 
            this.Mtxtreport.AutoSize = true;
            this.Mtxtreport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Mtxtreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxtreport.Location = new System.Drawing.Point(20, 20);
            this.Mtxtreport.Name = "Mtxtreport";
            this.Mtxtreport.Size = new System.Drawing.Size(262, 28);
            this.Mtxtreport.TabIndex = 0;
            this.Mtxtreport.Text = "Report and View All Leave";
            // 
            // MdataGridView1
            // 
            this.MdataGridView1.AllowUserToAddRows = false;
            this.MdataGridView1.AllowUserToDeleteRows = false;
            this.MdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.MdataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MID,
            this.MFullName,
            this.MLeaveType,
            this.MStartDate,
            this.MEndDate,
            this.MNoOfDays,
            this.MReason,
            this.MAttachment,
            this.MStatus,
            this.MAction});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.MdataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.MdataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MdataGridView1.Location = new System.Drawing.Point(25, 127);
            this.MdataGridView1.Name = "MdataGridView1";
            this.MdataGridView1.RowHeadersVisible = false;
            this.MdataGridView1.RowTemplate.Height = 24;
            this.MdataGridView1.Size = new System.Drawing.Size(999, 225);
            this.MdataGridView1.TabIndex = 1;
            this.MdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MdataGridView1_CellContentClick);
            // 
            // MID
            // 
            this.MID.HeaderText = "ID";
            this.MID.MinimumWidth = 6;
            this.MID.Name = "MID";
            this.MID.Width = 125;
            // 
            // MFullName
            // 
            this.MFullName.HeaderText = "FullName";
            this.MFullName.MinimumWidth = 6;
            this.MFullName.Name = "MFullName";
            this.MFullName.Width = 125;
            // 
            // MLeaveType
            // 
            this.MLeaveType.HeaderText = "LeaveType";
            this.MLeaveType.MinimumWidth = 6;
            this.MLeaveType.Name = "MLeaveType";
            this.MLeaveType.Width = 125;
            // 
            // MStartDate
            // 
            this.MStartDate.HeaderText = "StartDate";
            this.MStartDate.MinimumWidth = 6;
            this.MStartDate.Name = "MStartDate";
            this.MStartDate.Width = 125;
            // 
            // MEndDate
            // 
            this.MEndDate.HeaderText = "EndDate";
            this.MEndDate.MinimumWidth = 6;
            this.MEndDate.Name = "MEndDate";
            this.MEndDate.Width = 125;
            // 
            // MNoOfDays
            // 
            this.MNoOfDays.HeaderText = "NoOfDays";
            this.MNoOfDays.MinimumWidth = 6;
            this.MNoOfDays.Name = "MNoOfDays";
            this.MNoOfDays.Width = 125;
            // 
            // MReason
            // 
            this.MReason.HeaderText = "Reason";
            this.MReason.MinimumWidth = 6;
            this.MReason.Name = "MReason";
            this.MReason.Width = 125;
            // 
            // MAttachment
            // 
            this.MAttachment.HeaderText = "Attachment";
            this.MAttachment.MinimumWidth = 6;
            this.MAttachment.Name = "MAttachment";
            this.MAttachment.Width = 125;
            // 
            // MStatus
            // 
            this.MStatus.HeaderText = "Status";
            this.MStatus.MinimumWidth = 6;
            this.MStatus.Name = "MStatus";
            this.MStatus.Width = 125;
            // 
            // MAction
            // 
            this.MAction.HeaderText = "Action";
            this.MAction.MinimumWidth = 6;
            this.MAction.Name = "MAction";
            this.MAction.Width = 125;
            // 
            // MbtnPrevious
            // 
            this.MbtnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.MbtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbtnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MbtnPrevious.ForeColor = System.Drawing.Color.White;
            this.MbtnPrevious.Location = new System.Drawing.Point(36, 374);
            this.MbtnPrevious.Name = "MbtnPrevious";
            this.MbtnPrevious.Size = new System.Drawing.Size(100, 30);
            this.MbtnPrevious.TabIndex = 2;
            this.MbtnPrevious.Text = "Previous";
            this.MbtnPrevious.UseVisualStyleBackColor = false;
            this.MbtnPrevious.Click += new System.EventHandler(this.MbtnPrevious_Click);
            // 
            // MbtnNext
            // 
            this.MbtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.MbtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbtnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MbtnNext.ForeColor = System.Drawing.Color.White;
            this.MbtnNext.Location = new System.Drawing.Point(146, 374);
            this.MbtnNext.Name = "MbtnNext";
            this.MbtnNext.Size = new System.Drawing.Size(100, 30);
            this.MbtnNext.TabIndex = 3;
            this.MbtnNext.Text = "Next";
            this.MbtnNext.UseVisualStyleBackColor = false;
            this.MbtnNext.Click += new System.EventHandler(this.MbtnNext_Click);
            // 
            // MlblPage
            // 
            this.MlblPage.AutoSize = true;
            this.MlblPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MlblPage.Location = new System.Drawing.Point(256, 379);
            this.MlblPage.Name = "MlblPage";
            this.MlblPage.Size = new System.Drawing.Size(83, 20);
            this.MlblPage.TabIndex = 4;
            this.MlblPage.Text = "Page 1 of 1";
            // 
            // MtxtSearch
            // 
            this.MtxtSearch.Location = new System.Drawing.Point(537, 72);
            this.MtxtSearch.Multiline = true;
            this.MtxtSearch.Name = "MtxtSearch";
            this.MtxtSearch.Size = new System.Drawing.Size(240, 37);
            this.MtxtSearch.TabIndex = 5;
            this.MtxtSearch.TextChanged += new System.EventHandler(this.MtxtSearch_TextChanged);
            // 
            // MbtnSearch
            // 
            this.MbtnSearch.Location = new System.Drawing.Point(792, 73);
            this.MbtnSearch.Name = "MbtnSearch";
            this.MbtnSearch.Size = new System.Drawing.Size(89, 36);
            this.MbtnSearch.TabIndex = 6;
            this.MbtnSearch.Text = "Search";
            this.MbtnSearch.UseVisualStyleBackColor = true;
            // 
            // MbtnReset
            // 
            this.MbtnReset.Location = new System.Drawing.Point(887, 72);
            this.MbtnReset.Name = "MbtnReset";
            this.MbtnReset.Size = new System.Drawing.Size(89, 36);
            this.MbtnReset.TabIndex = 7;
            this.MbtnReset.Text = "Reset";
            this.MbtnReset.UseVisualStyleBackColor = true;
            this.MbtnReset.Click += new System.EventHandler(this.MbtnReset_Click);
            // 
            // Mviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.MbtnReset);
            this.Controls.Add(this.MbtnSearch);
            this.Controls.Add(this.MtxtSearch);
            this.Controls.Add(this.MlblPage);
            this.Controls.Add(this.MbtnNext);
            this.Controls.Add(this.MbtnPrevious);
            this.Controls.Add(this.MdataGridView1);
            this.Controls.Add(this.Mtxtreport);
            this.Name = "Mviews";
            this.Size = new System.Drawing.Size(1174, 591);
            ((System.ComponentModel.ISupportInitialize)(this.MdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mtxtreport;
        private System.Windows.Forms.Button MbtnPrevious;
        private System.Windows.Forms.Button MbtnNext;
        private System.Windows.Forms.Label MlblPage;
        private System.Windows.Forms.DataGridView MdataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNoOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn MReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAttachment;
        private System.Windows.Forms.DataGridViewTextBoxColumn MStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAction;
        private System.Windows.Forms.TextBox MtxtSearch;
        private System.Windows.Forms.Button MbtnSearch;
        private System.Windows.Forms.Button MbtnReset;
    }
}
