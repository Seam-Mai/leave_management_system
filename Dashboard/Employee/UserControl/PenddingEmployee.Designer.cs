using System.Windows.Forms;

namespace leave_management_system.Dashboard.Employee
{
    partial class PenddingEmployee
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
            this.Pendding = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pendding
            // 
            this.Pendding.AutoSize = true;
            this.Pendding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pendding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Pendding.Location = new System.Drawing.Point(20, 20);
            this.Pendding.Name = "Pendding";
            this.Pendding.Size = new System.Drawing.Size(300, 28);
            this.Pendding.TabIndex = 0;
            this.Pendding.Text = "View Pending Leave Request";
            this.Pendding.Click += new System.EventHandler(this.Pendding_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "ID", HeaderText = "ID", Width = 50, ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "FullName", HeaderText = "FULL NAME", Width = 150, ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "LeaveType", HeaderText = "LEAVE TYPE", Width = 100, ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "StartDate", HeaderText = "START DATE", Width = 100, ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "EndDate", HeaderText = "END DATE", Width = 100, ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "NoOfDays", HeaderText = "NO OF DAYS", Width = 100, ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Reason", HeaderText = "REASON", Width = 150, ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Attachment", HeaderText = "ATTACHMENT", Width = 100, ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Status", HeaderText = "STATUS", Width = 100, ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Action", HeaderText = "Action", Width = 100, ReadOnly = true }});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 60); // Shifted left from 20 to 10
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 200);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PenddingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pendding);
            this.Name = "PenddingEmployee";
            this.Size = new System.Drawing.Size(1158, 576);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Pendding;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}