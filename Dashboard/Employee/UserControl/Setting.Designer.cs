namespace leave_management_system.Security
{
    partial class Setting
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
            this.txtsetting = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnpassword = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.Label();
            this.titlethem = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsetting
            // 
            this.txtsetting.AutoSize = true;
            this.txtsetting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtsetting.Location = new System.Drawing.Point(50, 30);
            this.txtsetting.Name = "txtsetting";
            this.txtsetting.Size = new System.Drawing.Size(134, 41);
            this.txtsetting.TabIndex = 0;
            this.txtsetting.Text = "Settings";
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelSettings.Controls.Add(this.btnpassword);
            this.panelSettings.Controls.Add(this.txtpassword);
            this.panelSettings.Controls.Add(this.titlethem);
            this.panelSettings.Controls.Add(this.btnthem);
            this.panelSettings.Location = new System.Drawing.Point(50, 80);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(999, 300);
            this.panelSettings.TabIndex = 1;
            // 
            // btnpassword
            // 
            this.btnpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpassword.ForeColor = System.Drawing.Color.White;
            this.btnpassword.Location = new System.Drawing.Point(150, 110);
            this.btnpassword.Name = "btnpassword";
            this.btnpassword.Size = new System.Drawing.Size(100, 30);
            this.btnpassword.TabIndex = 6;
            this.btnpassword.Text = "Change Password";
            this.btnpassword.UseVisualStyleBackColor = false;
            this.btnpassword.Click += new System.EventHandler(this.btnpassword_Click);
            this.btnpassword.MouseEnter += new System.EventHandler(this.btnpassword_MouseEnter);
            this.btnpassword.MouseLeave += new System.EventHandler(this.btnpassword_MouseLeave);
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(30, 110);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(80, 23);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.Text = "Password";
            // 
            // titlethem
            // 
            this.titlethem.AutoSize = true;
            this.titlethem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlethem.Location = new System.Drawing.Point(30, 50);
            this.titlethem.Name = "titlethem";
            this.titlethem.Size = new System.Drawing.Size(62, 23);
            this.titlethem.TabIndex = 1;
            this.titlethem.Text = "Theme";
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(150, 50);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 30);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Change Theme";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            this.btnthem.MouseEnter += new System.EventHandler(this.btnthem_MouseEnter);
            this.btnthem.MouseLeave += new System.EventHandler(this.btnthem_MouseLeave);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.txtsetting);
            this.Name = "Setting";
            this.Size = new System.Drawing.Size(1158, 582);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtsetting;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label titlethem;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.Button btnpassword;
    }
}