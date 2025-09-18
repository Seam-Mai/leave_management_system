namespace leave_management_system.Dashboard.HR
{
    partial class HRsetting
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
            this.SECtxtsetting = new System.Windows.Forms.Label();
            this.SECpanelSettings = new System.Windows.Forms.Panel();
            this.SECbtnpassword = new System.Windows.Forms.Button();
            this.SECtxtpassword = new System.Windows.Forms.Label();
            this.SECtitlethem = new System.Windows.Forms.Label();
            this.SECbtnthem = new System.Windows.Forms.Button();
            this.SECpanelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // SECtxtsetting
            // 
            this.SECtxtsetting.AutoSize = true;
            this.SECtxtsetting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SECtxtsetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SECtxtsetting.Location = new System.Drawing.Point(50, 30);
            this.SECtxtsetting.Name = "SECtxtsetting";
            this.SECtxtsetting.Size = new System.Drawing.Size(134, 41);
            this.SECtxtsetting.TabIndex = 0;
            this.SECtxtsetting.Text = "Settings";
            // 
            // SECpanelSettings
            // 
            this.SECpanelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.SECpanelSettings.Controls.Add(this.SECbtnpassword);
            this.SECpanelSettings.Controls.Add(this.SECtxtpassword);
            this.SECpanelSettings.Controls.Add(this.SECtitlethem);
            this.SECpanelSettings.Controls.Add(this.SECbtnthem);
            this.SECpanelSettings.Location = new System.Drawing.Point(50, 80);
            this.SECpanelSettings.Name = "SECpanelSettings";
            this.SECpanelSettings.Size = new System.Drawing.Size(999, 300);
            this.SECpanelSettings.TabIndex = 1;
            // 
            // SECbtnpassword
            // 
            this.SECbtnpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SECbtnpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SECbtnpassword.ForeColor = System.Drawing.Color.White;
            this.SECbtnpassword.Location = new System.Drawing.Point(150, 110);
            this.SECbtnpassword.Name = "SECbtnpassword";
            this.SECbtnpassword.Size = new System.Drawing.Size(100, 30);
            this.SECbtnpassword.TabIndex = 6;
            this.SECbtnpassword.Text = "Change Password";
            this.SECbtnpassword.UseVisualStyleBackColor = false;
            this.SECbtnpassword.Click += new System.EventHandler(this.SECbtnpassword_Click);
            this.SECbtnpassword.MouseEnter += new System.EventHandler(this.SECbtnpassword_MouseEnter);
            this.SECbtnpassword.MouseLeave += new System.EventHandler(this.SECbtnpassword_MouseLeave);
            // 
            // SECtxtpassword
            // 
            this.SECtxtpassword.AutoSize = true;
            this.SECtxtpassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SECtxtpassword.Location = new System.Drawing.Point(30, 110);
            this.SECtxtpassword.Name = "SECtxtpassword";
            this.SECtxtpassword.Size = new System.Drawing.Size(80, 23);
            this.SECtxtpassword.TabIndex = 5;
            this.SECtxtpassword.Text = "Password";
            // 
            // SECtitlethem
            // 
            this.SECtitlethem.AutoSize = true;
            this.SECtitlethem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SECtitlethem.Location = new System.Drawing.Point(30, 50);
            this.SECtitlethem.Name = "SECtitlethem";
            this.SECtitlethem.Size = new System.Drawing.Size(62, 23);
            this.SECtitlethem.TabIndex = 1;
            this.SECtitlethem.Text = "Theme";
            // 
            // SECbtnthem
            // 
            this.SECbtnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SECbtnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SECbtnthem.ForeColor = System.Drawing.Color.White;
            this.SECbtnthem.Location = new System.Drawing.Point(150, 50);
            this.SECbtnthem.Name = "SECbtnthem";
            this.SECbtnthem.Size = new System.Drawing.Size(100, 30);
            this.SECbtnthem.TabIndex = 3;
            this.SECbtnthem.Text = "Change Theme";
            this.SECbtnthem.UseVisualStyleBackColor = false;
            this.SECbtnthem.Click += new System.EventHandler(this.SECbtnthem_Click);
            this.SECbtnthem.MouseEnter += new System.EventHandler(this.SECbtnthem_MouseEnter);
            this.SECbtnthem.MouseLeave += new System.EventHandler(this.SECbtnthem_MouseLeave);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SECpanelSettings);
            this.Controls.Add(this.SECtxtsetting);
            this.Name = "Setting";
            this.Size = new System.Drawing.Size(1158, 582);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.SECpanelSettings.ResumeLayout(false);
            this.SECpanelSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SECtxtsetting;
        private System.Windows.Forms.Panel SECpanelSettings;
        private System.Windows.Forms.Button SECbtnthem;
        private System.Windows.Forms.Label SECtitlethem;
        private System.Windows.Forms.Label SECtxtpassword;
        private System.Windows.Forms.Button SECbtnpassword;
    }
}
