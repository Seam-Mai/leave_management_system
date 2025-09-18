namespace leave_management_system.Dashboard.HR
{
    partial class HRpending
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
            this.HRPendding = new System.Windows.Forms.Label();
            this.HRdataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.HRdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HRPendding
            // 
            this.HRPendding.AutoSize = true;
            this.HRPendding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.HRPendding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HRPendding.Location = new System.Drawing.Point(20, 20);
            this.HRPendding.Name = "HRPendding";
            this.HRPendding.Size = new System.Drawing.Size(282, 28);
            this.HRPendding.TabIndex = 0;
            this.HRPendding.Text = "View Pending Leave Request";
            // 
            // HRdataGridView1
            // 
            this.HRdataGridView1.AllowUserToAddRows = false;
            this.HRdataGridView1.AllowUserToDeleteRows = false;
            this.HRdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.HRdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HRdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.HRdataGridView1.Location = new System.Drawing.Point(10, 60);
            this.HRdataGridView1.Name = "HRdataGridView1";
            this.HRdataGridView1.RowHeadersVisible = false;
            this.HRdataGridView1.RowHeadersWidth = 51;
            this.HRdataGridView1.RowTemplate.Height = 24;
            this.HRdataGridView1.Size = new System.Drawing.Size(1055, 200);
            this.HRdataGridView1.TabIndex = 1;
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
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "START DATE";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "END DATE";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // NoOfDays
            // 
            this.NoOfDays.HeaderText = "NO OF DAYS";
            this.NoOfDays.MinimumWidth = 6;
            this.NoOfDays.Name = "NoOfDays";
            this.NoOfDays.ReadOnly = true;
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
            // 
            // Status
            // 
            this.Status.HeaderText = "STATUS";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "ACTION";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // HRpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.HRdataGridView1);
            this.Controls.Add(this.HRPendding);
            this.Name = "HRpending";
            this.Size = new System.Drawing.Size(1158, 576);
            ((System.ComponentModel.ISupportInitialize)(this.HRdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label HRPendding;
        private System.Windows.Forms.DataGridView HRdataGridView1;
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

