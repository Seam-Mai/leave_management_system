namespace leave_management_system.Security
{
    partial class SettingChangePassword
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
            this.SuspendLayout();
            // 
            // SettingChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SettingChangePassword";
            this.Size = new System.Drawing.Size(900, 322);
            this.ResumeLayout(false);

            this.panelPassword = new System.Windows.Forms.Panel();
            this.btnchnagepassword = new System.Windows.Forms.Button();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.txtold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtoldpassword = new System.Windows.Forms.Label();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelPassword.Controls.Add(this.btnchnagepassword);
            this.panelPassword.Controls.Add(this.txtconfirm);
            this.panelPassword.Controls.Add(this.txtold);
            this.panelPassword.Controls.Add(this.label2);
            this.panelPassword.Controls.Add(this.txtoldpassword);
            this.panelPassword.Location = new System.Drawing.Point(173, 90);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(438, 291);
            this.panelPassword.TabIndex = 0;
            // 
            // btnchnagepassword
            // 
            this.btnchnagepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnchnagepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchnagepassword.ForeColor = System.Drawing.Color.White;
            this.btnchnagepassword.Location = new System.Drawing.Point(150, 200);
            this.btnchnagepassword.Name = "btnchnagepassword";
            this.btnchnagepassword.Size = new System.Drawing.Size(150, 35);
            this.btnchnagepassword.TabIndex = 4;
            this.btnchnagepassword.Text = "Change Password";
            this.btnchnagepassword.UseVisualStyleBackColor = false;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirm.Location = new System.Drawing.Point(163, 150);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(200, 30);
            this.txtconfirm.TabIndex = 3;
            this.txtconfirm.UseSystemPasswordChar = true;
            // 
            // txtold
            // 
            this.txtold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtold.Location = new System.Drawing.Point(163, 90);
            this.txtold.Name = "txtold";
            this.txtold.Size = new System.Drawing.Size(200, 30);
            this.txtold.TabIndex = 2;
            this.txtold.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.AutoSize = true;
            this.txtoldpassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldpassword.Location = new System.Drawing.Point(36, 97);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(112, 23);
            this.txtoldpassword.TabIndex = 0;
            this.txtoldpassword.Text = "Old Password";
            // 
            // SettingChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPassword);
            this.Name = "SettingChangePasswordForm";
            this.Text = "Change Password";
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

       

#endregion

        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button btnchnagepassword;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.TextBox txtold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtoldpassword;
    }
}

