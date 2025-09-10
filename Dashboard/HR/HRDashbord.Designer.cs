using leave_management_system.Security;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace leave_management_system.Dashboard.HR
{
    partial class HRDashboard
    {
        private Panel HRpanelSidebar;
        private Panel HRpanelHeader;
        private Panel HRpanelMain;
        private Button HRbtnProfile;
        private Button HRbtnLeaveRequest;
        private Button HRbtnAttendance;
        private Button HRbtnLogout;
        private Button HRbtnToggleSidebar;
        private Button HRSYSTEM;
        private Button HRbtnSettings;
        private Button HRbtnReports;
        private bool sidebarExpanded = true;
        private Label HRtxtname;
        private PictureBox HRpictureBox1;

        private void InitializeComponent()
        {
            this.HRpanelSidebar = new System.Windows.Forms.Panel();
            this.HRbtnManage = new System.Windows.Forms.Button();
            this.HRSYSTEM = new System.Windows.Forms.Button();
            this.HRbtnToggleSidebar = new System.Windows.Forms.Button();
            this.HRbtnProfile = new System.Windows.Forms.Button();
            this.HRbtnLeaveRequest = new System.Windows.Forms.Button();
            this.HRbtnAttendance = new System.Windows.Forms.Button();
            this.HRbtnReports = new System.Windows.Forms.Button();
            this.HRbtnSettings = new System.Windows.Forms.Button();
            this.HRbtnLogout = new System.Windows.Forms.Button();
            this.HRpanelHeader = new System.Windows.Forms.Panel();
            this.HRpictureBox1 = new System.Windows.Forms.PictureBox();
            this.HRtxtname = new System.Windows.Forms.Label();
            this.HRpanelMain = new System.Windows.Forms.Panel();
            this.HRpanelSidebar.SuspendLayout();
            this.HRpanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HRpanelSidebar
            // 
            this.HRpanelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.HRpanelSidebar.Controls.Add(this.HRbtnManage);
            this.HRpanelSidebar.Controls.Add(this.HRSYSTEM);
            this.HRpanelSidebar.Controls.Add(this.HRbtnToggleSidebar);
            this.HRpanelSidebar.Controls.Add(this.HRbtnProfile);
            this.HRpanelSidebar.Controls.Add(this.HRbtnLeaveRequest);
            this.HRpanelSidebar.Controls.Add(this.HRbtnAttendance);
            this.HRpanelSidebar.Controls.Add(this.HRbtnReports);
            this.HRpanelSidebar.Controls.Add(this.HRbtnSettings);
            this.HRpanelSidebar.Controls.Add(this.HRbtnLogout);
            this.HRpanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.HRpanelSidebar.Location = new System.Drawing.Point(0, 0);
            this.HRpanelSidebar.Name = "HRpanelSidebar";
            this.HRpanelSidebar.Size = new System.Drawing.Size(250, 700);
            this.HRpanelSidebar.TabIndex = 0;
            // 
            // HRbtnManage
            // 
            this.HRbtnManage.FlatAppearance.BorderSize = 0;
            this.HRbtnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.HRbtnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnManage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HRbtnManage.ForeColor = System.Drawing.Color.White;
            this.HRbtnManage.Location = new System.Drawing.Point(0, 466);
            this.HRbtnManage.Name = "HRbtnManage";
            this.HRbtnManage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HRbtnManage.Size = new System.Drawing.Size(250, 50);
            this.HRbtnManage.TabIndex = 8;
            this.HRbtnManage.Text = "📝  Manage Leave";
            this.HRbtnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HRbtnManage.UseVisualStyleBackColor = true;
            this.HRbtnManage.Click += new System.EventHandler(this.HRBtnManage_Click);
            // 
            // HRSYSTEM
            // 
            this.HRSYSTEM.FlatAppearance.BorderSize = 0;
            this.HRSYSTEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRSYSTEM.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.HRSYSTEM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.HRSYSTEM.Location = new System.Drawing.Point(0, 20);
            this.HRSYSTEM.Name = "HRSYSTEM";
            this.HRSYSTEM.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HRSYSTEM.Size = new System.Drawing.Size(250, 60);
            this.HRSYSTEM.TabIndex = 0;
            this.HRSYSTEM.Text = "📋 HR Leave System";
            this.HRSYSTEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HRSYSTEM.UseVisualStyleBackColor = true;
            // 
            // HRbtnToggleSidebar
            // 
            this.HRbtnToggleSidebar.FlatAppearance.BorderSize = 0;
            this.HRbtnToggleSidebar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.HRbtnToggleSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnToggleSidebar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.HRbtnToggleSidebar.ForeColor = System.Drawing.Color.White;
            this.HRbtnToggleSidebar.Location = new System.Drawing.Point(0, 90);
            this.HRbtnToggleSidebar.Name = "HRbtnToggleSidebar";
            this.HRbtnToggleSidebar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HRbtnToggleSidebar.Size = new System.Drawing.Size(250, 50);
            this.HRbtnToggleSidebar.TabIndex = 1;
            this.HRbtnToggleSidebar.Text = "☰  Menu";
            this.HRbtnToggleSidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HRbtnToggleSidebar.UseVisualStyleBackColor = true;
            this.HRbtnToggleSidebar.Click += new System.EventHandler(this.HRbtnToggleSidebar_Click);
            // 
            // HRbtnProfile
            // 
            this.HRbtnProfile.FlatAppearance.BorderSize = 0;
            this.HRbtnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.HRbtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnProfile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HRbtnProfile.ForeColor = System.Drawing.Color.White;
            this.HRbtnProfile.Location = new System.Drawing.Point(0, 160);
            this.HRbtnProfile.Name = "HRbtnProfile";
            this.HRbtnProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HRbtnProfile.Size = new System.Drawing.Size(250, 50);
            this.HRbtnProfile.TabIndex = 2;
            this.HRbtnProfile.Text = "🏠  Home";
            this.HRbtnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HRbtnProfile.UseVisualStyleBackColor = true;
            this.HRbtnProfile.Click += new System.EventHandler(this.HRBtnProfile_Click);
            // 
            // HRbtnLeaveRequest
            // 
            this.HRbtnLeaveRequest.FlatAppearance.BorderSize = 0;
            this.HRbtnLeaveRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.HRbtnLeaveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HRbtnLeaveRequest.ForeColor = System.Drawing.Color.White;
            this.HRbtnLeaveRequest.Location = new System.Drawing.Point(0, 220);
            this.HRbtnLeaveRequest.Name = "HRbtnLeaveRequest";
            this.HRbtnLeaveRequest.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HRbtnLeaveRequest.Size = new System.Drawing.Size(250, 50);
            this.HRbtnLeaveRequest.TabIndex = 3;
            this.HRbtnLeaveRequest.Text = "📝  Leave Requests";
            this.HRbtnLeaveRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HRbtnLeaveRequest.UseVisualStyleBackColor = true;
            this.HRbtnLeaveRequest.Click += new System.EventHandler(this.HRBtnLeaveRequest_Click);
            // 
            // HRbtnAttendance
            // 
            this.HRbtnAttendance.FlatAppearance.BorderSize = 0;
            this.HRbtnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.HRbtnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnAttendance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HRbtnAttendance.ForeColor = System.Drawing.Color.White;
            this.HRbtnAttendance.Location = new System.Drawing.Point(0, 280);
            this.HRbtnAttendance.Name = "HRbtnAttendance";
            this.HRbtnAttendance.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HRbtnAttendance.Size = new System.Drawing.Size(250, 50);
            this.HRbtnAttendance.TabIndex = 4;
            this.HRbtnAttendance.Text = "📅  Attendance";
            this.HRbtnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HRbtnAttendance.UseVisualStyleBackColor = true;
            this.HRbtnAttendance.Click += new System.EventHandler(this.HRBtnAttendance_Click);
            // 
            // HRbtnReports
            // 
            this.HRbtnReports.FlatAppearance.BorderSize = 0;
            this.HRbtnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.HRbtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnReports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HRbtnReports.ForeColor = System.Drawing.Color.White;
            this.HRbtnReports.Location = new System.Drawing.Point(0, 340);
            this.HRbtnReports.Name = "HRbtnReports";
            this.HRbtnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HRbtnReports.Size = new System.Drawing.Size(250, 50);
            this.HRbtnReports.TabIndex = 5;
            this.HRbtnReports.Text = "📊  Reports";
            this.HRbtnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HRbtnReports.UseVisualStyleBackColor = true;
            this.HRbtnReports.Click += new System.EventHandler(this.HRBtnReports_Click);
            // 
            // HRbtnSettings
            // 
            this.HRbtnSettings.FlatAppearance.BorderSize = 0;
            this.HRbtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.HRbtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HRbtnSettings.ForeColor = System.Drawing.Color.White;
            this.HRbtnSettings.Location = new System.Drawing.Point(0, 400);
            this.HRbtnSettings.Name = "HRbtnSettings";
            this.HRbtnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HRbtnSettings.Size = new System.Drawing.Size(250, 50);
            this.HRbtnSettings.TabIndex = 6;
            this.HRbtnSettings.Text = "⚙️  Settings";
            this.HRbtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HRbtnSettings.UseVisualStyleBackColor = true;
            this.HRbtnSettings.Click += new System.EventHandler(this.HRBtnSettings_Click);
            // 
            // HRbtnLogout
            // 
            this.HRbtnLogout.FlatAppearance.BorderSize = 0;
            this.HRbtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.HRbtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtnLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HRbtnLogout.ForeColor = System.Drawing.Color.White;
            this.HRbtnLogout.Location = new System.Drawing.Point(0, 620);
            this.HRbtnLogout.Name = "HRbtnLogout";
            this.HRbtnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.HRbtnLogout.Size = new System.Drawing.Size(250, 50);
            this.HRbtnLogout.TabIndex = 7;
            this.HRbtnLogout.Text = "🚪  Logout";
            this.HRbtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HRbtnLogout.UseVisualStyleBackColor = true;
            this.HRbtnLogout.Click += new System.EventHandler(this.HRBtnLogout_Click);
            // 
            // HRpanelHeader
            // 
            this.HRpanelHeader.BackColor = System.Drawing.Color.Teal;
            this.HRpanelHeader.Controls.Add(this.HRpictureBox1);
            this.HRpanelHeader.Controls.Add(this.HRtxtname);
            this.HRpanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.HRpanelHeader.Location = new System.Drawing.Point(250, 0);
            this.HRpanelHeader.Name = "HRpanelHeader";
            this.HRpanelHeader.Size = new System.Drawing.Size(830, 55);
            this.HRpanelHeader.TabIndex = 1;
            // 
            // HRpictureBox1
            // 
            this.HRpictureBox1.Location = new System.Drawing.Point(673, 9);
            this.HRpictureBox1.Name = "HRpictureBox1";
            this.HRpictureBox1.Size = new System.Drawing.Size(34, 37);
            this.HRpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HRpictureBox1.TabIndex = 1;
            this.HRpictureBox1.TabStop = false;
            // 
            // HRtxtname
            // 
            this.HRtxtname.AutoSize = true;
            this.HRtxtname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HRtxtname.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.HRtxtname.Location = new System.Drawing.Point(724, 20);
            this.HRtxtname.Name = "HRtxtname";
            this.HRtxtname.Size = new System.Drawing.Size(68, 16);
            this.HRtxtname.TabIndex = 0;
            this.HRtxtname.Text = "Seam Mai";
            this.HRtxtname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HRpanelMain
            // 
            this.HRpanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.HRpanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HRpanelMain.Location = new System.Drawing.Point(250, 55);
            this.HRpanelMain.Name = "HRpanelMain";
            this.HRpanelMain.Size = new System.Drawing.Size(830, 645);
            this.HRpanelMain.TabIndex = 2;
            // 
            // HRDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.HRpanelMain);
            this.Controls.Add(this.HRpanelHeader);
            this.Controls.Add(this.HRpanelSidebar);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "HRDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Dashboard - Leave Management System";
            this.HRpanelSidebar.ResumeLayout(false);
            this.HRpanelHeader.ResumeLayout(false);
            this.HRpanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRpictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void HRbtnToggleSidebar_Click(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                // Collapse sidebar - hide text, show only icons
                this.HRpanelSidebar.Width = 80;

                // Update button texts to show only icons
                this.HRSYSTEM.Text = "📋";
                this.HRbtnToggleSidebar.Text = "☰";
                this.HRbtnProfile.Text = "🏠";
                this.HRbtnLeaveRequest.Text = "📝";
                this.HRbtnAttendance.Text = "📅";
                this.HRbtnReports.Text = "📊";
                this.HRbtnSettings.Text = "⚙️";
                this.HRbtnManage.Text = "📝";
                this.HRbtnLogout.Text = "🚪";

                // Update button sizes and alignment
                this.HRSYSTEM.Width = 80;
                this.HRbtnToggleSidebar.Width = 80;
                this.HRbtnProfile.Width = 80;
                this.HRbtnLeaveRequest.Width = 80;
                this.HRbtnAttendance.Width = 80;
                this.HRbtnReports.Width = 80;
                this.HRbtnSettings.Width = 80;
                this.HRbtnLogout.Width = 80;

                // Center align text for icons only
                this.HRSYSTEM.TextAlign = ContentAlignment.MiddleCenter;
                this.HRbtnToggleSidebar.TextAlign = ContentAlignment.MiddleCenter;
                this.HRbtnProfile.TextAlign = ContentAlignment.MiddleCenter;
                this.HRbtnLeaveRequest.TextAlign = ContentAlignment.MiddleCenter;
                this.HRbtnAttendance.TextAlign = ContentAlignment.MiddleCenter;
                this.HRbtnReports.TextAlign = ContentAlignment.MiddleCenter;
                this.HRbtnSettings.TextAlign = ContentAlignment.MiddleCenter;
                this.HRbtnLogout.TextAlign = ContentAlignment.MiddleCenter;

                // Remove padding
                this.HRSYSTEM.Padding = new Padding(0);
                this.HRbtnToggleSidebar.Padding = new Padding(0);
                this.HRbtnProfile.Padding = new Padding(0);
                this.HRbtnLeaveRequest.Padding = new Padding(0);
                this.HRbtnAttendance.Padding = new Padding(0);
                this.HRbtnReports.Padding = new Padding(0);
                this.HRbtnSettings.Padding = new Padding(0);
                this.HRbtnLogout.Padding = new Padding(0);

                sidebarExpanded = false;
            }
            else
            {
                // Expand sidebar - show text with icons
                this.HRpanelSidebar.Width = 250;

                // Update button texts to show icons with text
                this.HRSYSTEM.Text = "📋  Leave System";
                this.HRbtnToggleSidebar.Text = "☰  Menu";
                this.HRbtnProfile.Text = "🏠  Home";
                this.HRbtnLeaveRequest.Text = "📝  Leave Requests";
                this.HRbtnAttendance.Text = "📅  Attendance";
                this.HRbtnReports.Text = "📊  Reports";
                this.HRbtnSettings.Text = "⚙️  Settings";
                this.HRbtnManage.Text = "📝  Manage Leave";
                this.HRbtnLogout.Text = "🚪  Logout";

                // Update button sizes
                this.HRSYSTEM.Width = 250;
                this.HRbtnToggleSidebar.Width = 250;
                this.HRbtnProfile.Width = 250;
                this.HRbtnLeaveRequest.Width = 250;
                this.HRbtnAttendance.Width = 250;
                this.HRbtnReports.Width = 250;
                this.HRbtnSettings.Width = 250;
                this.HRbtnLogout.Width = 250;

                // Left align text with padding
                this.HRSYSTEM.TextAlign = ContentAlignment.MiddleLeft;
                this.HRbtnToggleSidebar.TextAlign = ContentAlignment.MiddleLeft;
                this.HRbtnProfile.TextAlign = ContentAlignment.MiddleLeft;
                this.HRbtnLeaveRequest.TextAlign = ContentAlignment.MiddleLeft;
                this.HRbtnAttendance.TextAlign = ContentAlignment.MiddleLeft;
                this.HRbtnReports.TextAlign = ContentAlignment.MiddleLeft;
                this.HRbtnSettings.TextAlign = ContentAlignment.MiddleLeft;
                this.HRbtnLogout.TextAlign = ContentAlignment.MiddleLeft;

                // Add padding
                this.HRSYSTEM.Padding = new Padding(15, 0, 0, 0);
                this.HRbtnToggleSidebar.Padding = new Padding(15, 0, 0, 0);
                this.HRbtnProfile.Padding = new Padding(15, 0, 0, 0);
                this.HRbtnLeaveRequest.Padding = new Padding(15, 0, 0, 0);
                this.HRbtnAttendance.Padding = new Padding(15, 0, 0, 0);
                this.HRbtnReports.Padding = new Padding(15, 0, 0, 0);
                this.HRbtnSettings.Padding = new Padding(15, 0, 0, 0);
                this.HRbtnLogout.Padding = new Padding(15, 0, 0, 0);

                sidebarExpanded = true;
            }
        }

        private void HRBtnLogout_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            Close();
            login.Show();
          
        }

        private Button HRbtnManage;
    }
}