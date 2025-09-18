namespace leave_management_system.Dashboard.Manager
{
    partial class ManagerManage
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
            this.MPendding = new System.Windows.Forms.Label();
            this.MdataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.MdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MPendding
            // 
            this.MPendding.AutoSize = true;
            this.MPendding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MPendding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.MPendding.Location = new System.Drawing.Point(20, 20);
            this.MPendding.Name = "MPendding";
            this.MPendding.Size = new System.Drawing.Size(364, 28);
            this.MPendding.TabIndex = 0;
            this.MPendding.Text = "Manage View Pending Leave Request";
            // 
            // MdataGridView1
            // 
            this.MdataGridView1.AllowUserToAddRows = false;
            this.MdataGridView1.AllowUserToDeleteRows = false;
            this.MdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.MdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.MdataGridView1.Location = new System.Drawing.Point(10, 60);
            this.MdataGridView1.Name = "MdataGridView1";
            this.MdataGridView1.RowHeadersVisible = false;
            this.MdataGridView1.RowHeadersWidth = 51;
            this.MdataGridView1.RowTemplate.Height = 24;
            this.MdataGridView1.Size = new System.Drawing.Size(1055, 200);
            this.MdataGridView1.TabIndex = 1;
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
            // ManagerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.MdataGridView1);
            this.Controls.Add(this.MPendding);
            this.Name = "ManagerManage";
            this.Size = new System.Drawing.Size(1158, 576);
            ((System.ComponentModel.ISupportInitialize)(this.MdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label MPendding;
        private System.Windows.Forms.DataGridView MdataGridView1;
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
