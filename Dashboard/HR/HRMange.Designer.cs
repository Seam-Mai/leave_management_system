namespace leave_management_system.Dashboard.HR
{
    partial class HRMange
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
            this.HRMPendding = new System.Windows.Forms.Label();
            this.HRMdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attachment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HRMdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HRMPendding
            // 
            this.HRMPendding.AutoSize = true;
            this.HRMPendding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.HRMPendding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRMPendding.Location = new System.Drawing.Point(20, 20);
            this.HRMPendding.Name = "HRMPendding";
            this.HRMPendding.Size = new System.Drawing.Size(364, 28);
            this.HRMPendding.TabIndex = 0;
            this.HRMPendding.Text = "Manage View Pending Leave Request";
            // 
            // HRMdataGridView1
            // 
            this.HRMdataGridView1.AllowUserToAddRows = false;
            this.HRMdataGridView1.AllowUserToDeleteRows = false;
            this.HRMdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.HRMdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HRMdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.LeaveType,
            this.StartDate,
            this.EndDate,
            this.NoOfDays,
            this.Reason,
            this.Attachment,
            this.Status,
            this.Action});
            this.HRMdataGridView1.Location = new System.Drawing.Point(10, 60);
            this.HRMdataGridView1.Name = "HRMdataGridView1";
            this.HRMdataGridView1.RowHeadersVisible = false;
            this.HRMdataGridView1.RowHeadersWidth = 51;
            this.HRMdataGridView1.RowTemplate.Height = 24;
            this.HRMdataGridView1.Size = new System.Drawing.Size(1055, 200);
            this.HRMdataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FULL NAME";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 150;
            // 
            // LeaveType
            // 
            this.LeaveType.HeaderText = "LEAVE TYPE";
            this.LeaveType.MinimumWidth = 6;
            this.LeaveType.Name = "LeaveType";
            this.LeaveType.ReadOnly = true;
            this.LeaveType.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "START DATE";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "END DATE";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 125;
            // 
            // NoOfDays
            // 
            this.NoOfDays.HeaderText = "NO OF DAYS";
            this.NoOfDays.MinimumWidth = 6;
            this.NoOfDays.Name = "NoOfDays";
            this.NoOfDays.ReadOnly = true;
            this.NoOfDays.Width = 125;
            // 
            // Reason
            // 
            this.Reason.HeaderText = "REASON";
            this.Reason.MinimumWidth = 6;
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Width = 150;
            // 
            // Attachment
            // 
            this.Attachment.HeaderText = "ATTACHMENT";
            this.Attachment.MinimumWidth = 6;
            this.Attachment.Name = "Attachment";
            this.Attachment.ReadOnly = true;
            this.Attachment.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "STATUS";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Action
            // 
            this.Action.HeaderText = "ACTION";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 125;
            // 
            // HRMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.HRMdataGridView1);
            this.Controls.Add(this.HRMPendding);
            this.Name = "HRMange";
            this.Size = new System.Drawing.Size(1158, 576);
            ((System.ComponentModel.ISupportInitialize)(this.HRMdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
      
        private System.Windows.Forms.Label HRMPendding;
        private System.Windows.Forms.DataGridView HRMdataGridView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attachment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}
