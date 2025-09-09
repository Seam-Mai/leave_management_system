namespace leave_management_system.Security
{
    partial class Register
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

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnchangeuseradmin = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(40);
            this.panelMain.Size = new System.Drawing.Size(1155, 731);
            this.panelMain.TabIndex = 0;
            this.panelMain.UseWaitCursor = true;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.btnRegister);
            this.panelForm.Controls.Add(this.btnCancel);
            this.panelForm.Controls.Add(this.cmbRole);
            this.panelForm.Controls.Add(this.txtPosition);
            this.panelForm.Controls.Add(this.txtConfirmPassword);
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.txtEmail);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.txtFullName);
            this.panelForm.Controls.Add(this.lblRole);
            this.panelForm.Controls.Add(this.lblPosition);
            this.panelForm.Controls.Add(this.lblConfirmPassword);
            this.panelForm.Controls.Add(this.lblPassword);
            this.panelForm.Controls.Add(this.lblEmail);
            this.panelForm.Controls.Add(this.lblUsername);
            this.panelForm.Controls.Add(this.lblFullName);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(40, 140);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(60, 40, 60, 40);
            this.panelForm.Size = new System.Drawing.Size(1075, 551);
            this.panelForm.TabIndex = 1;
            this.panelForm.UseWaitCursor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(60, 460);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 45);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.UseWaitCursor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(230, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.UseWaitCursor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(580, 375);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(350, 31);
            this.cmbRole.TabIndex = 7;
            this.cmbRole.UseWaitCursor = true;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosition.Location = new System.Drawing.Point(60, 375);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(350, 30);
            this.txtPosition.TabIndex = 6;
            this.txtPosition.UseWaitCursor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(580, 285);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(350, 30);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.UseWaitCursor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(60, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(350, 30);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(580, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 30);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseWaitCursor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(60, 195);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 30);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.UseWaitCursor = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(60, 105);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(870, 30);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.UseWaitCursor = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblRole.Location = new System.Drawing.Point(580, 345);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(45, 23);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Role";
            this.lblRole.UseWaitCursor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblPosition.Location = new System.Drawing.Point(60, 345);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(73, 23);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Position";
            this.lblPosition.UseWaitCursor = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(580, 255);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(156, 23);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.UseWaitCursor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblPassword.Location = new System.Drawing.Point(60, 255);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 23);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.UseWaitCursor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblEmail.Location = new System.Drawing.Point(580, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.UseWaitCursor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblUsername.Location = new System.Drawing.Point(60, 165);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.UseWaitCursor = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblFullName.Location = new System.Drawing.Point(60, 75);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 23);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.UseWaitCursor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnchangeuseradmin);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(40, 40);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1075, 100);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.UseWaitCursor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(50, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(349, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "User Registration";
            this.lblTitle.UseWaitCursor = true;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitle.Location = new System.Drawing.Point(55, 65);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(384, 28);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Create a new account for the system access";
            this.lblSubtitle.UseWaitCursor = true;
            // 
            // btnchangeuseradmin
            // 
            this.btnchangeuseradmin.Location = new System.Drawing.Point(903, 15);
            this.btnchangeuseradmin.Name = "btnchangeuseradmin";
            this.btnchangeuseradmin.Size = new System.Drawing.Size(151, 35);
            this.btnchangeuseradmin.TabIndex = 2;
            this.btnchangeuseradmin.Text = "Change Password ";
            this.btnchangeuseradmin.UseVisualStyleBackColor = true;
            this.btnchangeuseradmin.Click += new System.EventHandler(this.btnchangeuseradmin_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 731);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register - Leave Management System";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panelMain.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnchangeuseradmin;
    }
}