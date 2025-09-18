namespace leave_management_system.Dashboard.Manager
{
    partial class ManagerSetting
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
            this.Mtxtsetting = new System.Windows.Forms.Label();
            this.MpanelSettings = new System.Windows.Forms.Panel();
            this.Mbtnpassword = new System.Windows.Forms.Button();
            this.Mtxtpassword = new System.Windows.Forms.Label();
            this.Mtitlethem = new System.Windows.Forms.Label();
            this.Mbtnthem = new System.Windows.Forms.Button();
            this.MpanelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mtxtsetting
            // 
            this.Mtxtsetting.AutoSize = true;
            this.Mtxtsetting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtsetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Mtxtsetting.Location = new System.Drawing.Point(50, 30);
            this.Mtxtsetting.Name = "Mtxtsetting";
            this.Mtxtsetting.Size = new System.Drawing.Size(134, 41);
            this.Mtxtsetting.TabIndex = 0;
            this.Mtxtsetting.Text = "Settings";
            // 
            // MpanelSettings
            // 
            this.MpanelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.MpanelSettings.Controls.Add(this.Mbtnpassword);
            this.MpanelSettings.Controls.Add(this.Mtxtpassword);
            this.MpanelSettings.Controls.Add(this.Mtitlethem);
            this.MpanelSettings.Controls.Add(this.Mbtnthem);
            this.MpanelSettings.Location = new System.Drawing.Point(50, 80);
            this.MpanelSettings.Name = "MpanelSettings";
            this.MpanelSettings.Size = new System.Drawing.Size(999, 300);
            this.MpanelSettings.TabIndex = 1;
            // 
            // Mbtnpassword
            // 
            this.Mbtnpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Mbtnpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mbtnpassword.ForeColor = System.Drawing.Color.White;
            this.Mbtnpassword.Location = new System.Drawing.Point(150, 110);
            this.Mbtnpassword.Name = "Mbtnpassword";
            this.Mbtnpassword.Size = new System.Drawing.Size(150, 30);
            this.Mbtnpassword.TabIndex = 6;
            this.Mbtnpassword.Text = "Change Password";
            this.Mbtnpassword.UseVisualStyleBackColor = false;
            this.Mbtnpassword.Click += new System.EventHandler(this.Mbtnpassword_Click);
            this.Mbtnpassword.MouseEnter += new System.EventHandler(this.Mbtnpassword_MouseEnter);
            this.Mbtnpassword.MouseLeave += new System.EventHandler(this.Mbtnpassword_MouseLeave);
            // 
            // Mtxtpassword
            // 
            this.Mtxtpassword.AutoSize = true;
            this.Mtxtpassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxtpassword.Location = new System.Drawing.Point(30, 110);
            this.Mtxtpassword.Name = "Mtxtpassword";
            this.Mtxtpassword.Size = new System.Drawing.Size(80, 23);
            this.Mtxtpassword.TabIndex = 5;
            this.Mtxtpassword.Text = "Password";
            // 
            // Mtitlethem
            // 
            this.Mtitlethem.AutoSize = true;
            this.Mtitlethem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtitlethem.Location = new System.Drawing.Point(30, 50);
            this.Mtitlethem.Name = "Mtitlethem";
            this.Mtitlethem.Size = new System.Drawing.Size(62, 23);
            this.Mtitlethem.TabIndex = 1;
            this.Mtitlethem.Text = "Theme";
            // 
            // Mbtnthem
            // 
            this.Mbtnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Mbtnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mbtnthem.ForeColor = System.Drawing.Color.White;
            this.Mbtnthem.Location = new System.Drawing.Point(150, 50);
            this.Mbtnthem.Name = "Mbtnthem";
            this.Mbtnthem.Size = new System.Drawing.Size(150, 30);
            this.Mbtnthem.TabIndex = 3;
            this.Mbtnthem.Text = "Change Theme";
            this.Mbtnthem.UseVisualStyleBackColor = false;
            this.Mbtnthem.Click += new System.EventHandler(this.Mbtnthem_Click);
            this.Mbtnthem.MouseEnter += new System.EventHandler(this.Mbtnthem_MouseEnter);
            this.Mbtnthem.MouseLeave += new System.EventHandler(this.Mbtnthem_MouseLeave);
            // 
            // ManagerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MpanelSettings);
            this.Controls.Add(this.Mtxtsetting);
            this.Name = "ManagerSetting";
            this.Size = new System.Drawing.Size(1158, 582);
            this.Load += new System.EventHandler(this.ManagerSetting_Load);
            this.MpanelSettings.ResumeLayout(false);
            this.MpanelSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mtxtsetting;
        private System.Windows.Forms.Panel MpanelSettings;
        private System.Windows.Forms.Button Mbtnthem;
        private System.Windows.Forms.Label Mtitlethem;
        private System.Windows.Forms.Label Mtxtpassword;
        private System.Windows.Forms.Button Mbtnpassword;
    }
}
