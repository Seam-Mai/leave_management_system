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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPassword = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtnew = new System.Windows.Forms.TextBox();
            this.txtold = new System.Windows.Forms.TextBox();
            this.txtnewpassword = new System.Windows.Forms.Label();
            this.txtoldpassword = new System.Windows.Forms.Label();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelPassword.Controls.Add(this.btnsave);
            this.panelPassword.Controls.Add(this.btncancel);
            this.panelPassword.Controls.Add(this.txtnew);
            this.panelPassword.Controls.Add(this.txtold);
            this.panelPassword.Controls.Add(this.txtnewpassword);
            this.panelPassword.Controls.Add(this.txtoldpassword);
            this.panelPassword.Location = new System.Drawing.Point(202, 74);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(400, 308);
            this.panelPassword.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(250, 200);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 35);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.MouseEnter += new System.EventHandler(this.btnsave_MouseEnter);
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(150, 200);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 35);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            this.btncancel.MouseEnter += new System.EventHandler(this.btncancel_MouseEnter);
            this.btncancel.MouseLeave += new System.EventHandler(this.btncancel_MouseLeave);
            // 
            // txtnew
            // 
            this.txtnew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnew.Location = new System.Drawing.Point(150, 150);
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(200, 30);
            this.txtnew.TabIndex = 4;
            this.txtnew.UseSystemPasswordChar = true;
            // 
            // txtold
            // 
            this.txtold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtold.Location = new System.Drawing.Point(150, 90);
            this.txtold.Name = "txtold";
            this.txtold.Size = new System.Drawing.Size(200, 30);
            this.txtold.TabIndex = 3;
            this.txtold.UseSystemPasswordChar = true;
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.AutoSize = true;
            this.txtnewpassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpassword.Location = new System.Drawing.Point(25, 150);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(119, 23);
            this.txtnewpassword.TabIndex = 2;
            this.txtnewpassword.Text = "New Password";
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.AutoSize = true;
            this.txtoldpassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldpassword.Location = new System.Drawing.Point(25, 93);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(112, 23);
            this.txtoldpassword.TabIndex = 1;
            this.txtoldpassword.Text = "Old Password";
            // 
            // SettingChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPassword);
            this.Name = "SettingChangePassword";
            this.Text = "Change Password";
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtnew;
        private System.Windows.Forms.TextBox txtold;
        private System.Windows.Forms.Label txtnewpassword;
        private System.Windows.Forms.Label txtoldpassword;
    }
}