namespace leave_management_system.Security
{
    partial class AdminPassword
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.lblConfirmPassword);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.lblNewPassword);
            this.panel1.Controls.Add(this.txtOldPassword);
            this.panel1.Controls.Add(this.lblOldPassword);
            this.panel1.Location = new System.Drawing.Point(180, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 250);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(200, 190);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 30);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(200, 137);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 22);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(60, 140);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(118, 16);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(200, 87);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 22);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(60, 90);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(100, 16);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "New Password:";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(200, 37);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(200, 22);
            this.txtOldPassword.TabIndex = 1;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(60, 40);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(94, 16);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Old Password:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(308, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Admin Change Password";
            // 
            // AdminPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 421);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPassword";
            this.Text = "Change Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
    }
}
