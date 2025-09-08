using System;
using System.Drawing;
using System.Windows.Forms;

namespace leave_management_system.Dashboard
{
    partial class EmployeeDashboard
    {
        private Panel panelSidebar;
        private Panel panelHeader;
        private Panel panelMain;
        private Button btnProfile;
        private Button btnLeaveRequest;
        private Button btnAttendance;
        private Button btnLogout;
        private Button btnToggleSidebar;
        private Button SYSTEM;
        private Button btnSettings;
        private Button btnReports;
        private bool sidebarExpanded = true;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.SYSTEM = new System.Windows.Forms.Button();
            this.btnToggleSidebar = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLeaveRequest = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.panelSidebar.Controls.Add(this.SYSTEM);
            this.panelSidebar.Controls.Add(this.btnToggleSidebar);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnLeaveRequest);
            this.panelSidebar.Controls.Add(this.btnAttendance);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 700);
            this.panelSidebar.TabIndex = 0;
            // 
            // SYSTEM
            // 
            this.SYSTEM.FlatAppearance.BorderSize = 0;
            this.SYSTEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SYSTEM.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.SYSTEM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.SYSTEM.Location = new System.Drawing.Point(0, 20);
            this.SYSTEM.Name = "SYSTEM";
            this.SYSTEM.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.SYSTEM.Size = new System.Drawing.Size(250, 60);
            this.SYSTEM.TabIndex = 0;
            this.SYSTEM.Text = "📋  Leave System";
            this.SYSTEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SYSTEM.UseVisualStyleBackColor = true;
            // 
            // btnToggleSidebar
            // 
            this.btnToggleSidebar.FlatAppearance.BorderSize = 0;
            this.btnToggleSidebar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnToggleSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleSidebar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnToggleSidebar.ForeColor = System.Drawing.Color.White;
            this.btnToggleSidebar.Location = new System.Drawing.Point(0, 90);
            this.btnToggleSidebar.Name = "btnToggleSidebar";
            this.btnToggleSidebar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnToggleSidebar.Size = new System.Drawing.Size(250, 50);
            this.btnToggleSidebar.TabIndex = 1;
            this.btnToggleSidebar.Text = "☰  Menu";
            this.btnToggleSidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleSidebar.UseVisualStyleBackColor = true;
            this.btnToggleSidebar.Click += new System.EventHandler(this.btnToggleSidebar_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 160);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(250, 50);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "🏠  Home";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnLeaveRequest
            // 
            this.btnLeaveRequest.FlatAppearance.BorderSize = 0;
            this.btnLeaveRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnLeaveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLeaveRequest.ForeColor = System.Drawing.Color.White;
            this.btnLeaveRequest.Location = new System.Drawing.Point(0, 220);
            this.btnLeaveRequest.Name = "btnLeaveRequest";
            this.btnLeaveRequest.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLeaveRequest.Size = new System.Drawing.Size(250, 50);
            this.btnLeaveRequest.TabIndex = 3;
            this.btnLeaveRequest.Text = "📝  Leave Requests";
            this.btnLeaveRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaveRequest.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(0, 280);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAttendance.Size = new System.Drawing.Size(250, 50);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "📅  Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 340);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(250, 50);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "📊  Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 400);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(250, 50);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "⚙️  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 620);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "🚪  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Teal;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.txtname);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(830, 55);
            this.panelHeader.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtname.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtname.Location = new System.Drawing.Point(724, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(68, 16);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "Seam Mai";
            this.txtname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 55);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(830, 645);
            this.panelMain.TabIndex = 2;
            // 
            // EmployeeDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard - Leave Management System";
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                // Collapse sidebar - hide text, show only icons
                this.panelSidebar.Width = 80;

                // Update button texts to show only icons
                this.SYSTEM.Text = "📋";
                this.btnToggleSidebar.Text = "☰";
                this.btnProfile.Text = "🏠";
                this.btnLeaveRequest.Text = "📝";
                this.btnAttendance.Text = "📅";
                this.btnReports.Text = "📊";
                this.btnSettings.Text = "⚙️";
                this.btnLogout.Text = "🚪";

                // Update button sizes and alignment
                this.SYSTEM.Width = 80;
                this.btnToggleSidebar.Width = 80;
                this.btnProfile.Width = 80;
                this.btnLeaveRequest.Width = 80;
                this.btnAttendance.Width = 80;
                this.btnReports.Width = 80;
                this.btnSettings.Width = 80;
                this.btnLogout.Width = 80;

                // Center align text for icons only
                this.SYSTEM.TextAlign = ContentAlignment.MiddleCenter;
                this.btnToggleSidebar.TextAlign = ContentAlignment.MiddleCenter;
                this.btnProfile.TextAlign = ContentAlignment.MiddleCenter;
                this.btnLeaveRequest.TextAlign = ContentAlignment.MiddleCenter;
                this.btnAttendance.TextAlign = ContentAlignment.MiddleCenter;
                this.btnReports.TextAlign = ContentAlignment.MiddleCenter;
                this.btnSettings.TextAlign = ContentAlignment.MiddleCenter;
                this.btnLogout.TextAlign = ContentAlignment.MiddleCenter;

                // Remove padding
                this.SYSTEM.Padding = new Padding(0);
                this.btnToggleSidebar.Padding = new Padding(0);
                this.btnProfile.Padding = new Padding(0);
                this.btnLeaveRequest.Padding = new Padding(0);
                this.btnAttendance.Padding = new Padding(0);
                this.btnReports.Padding = new Padding(0);
                this.btnSettings.Padding = new Padding(0);
                this.btnLogout.Padding = new Padding(0);

                sidebarExpanded = false;
            }
            else
            {
                // Expand sidebar - show text with icons
                this.panelSidebar.Width = 250;

                // Update button texts to show icons with text
                this.SYSTEM.Text = "📋  Leave System";
                this.btnToggleSidebar.Text = "☰  Menu";
                this.btnProfile.Text = "🏠  Home";
                this.btnLeaveRequest.Text = "📝  Leave Requests";
                this.btnAttendance.Text = "📅  Attendance";
                this.btnReports.Text = "📊  Reports";
                this.btnSettings.Text = "⚙️  Settings";
                this.btnLogout.Text = "🚪  Logout";

                // Update button sizes
                this.SYSTEM.Width = 250;
                this.btnToggleSidebar.Width = 250;
                this.btnProfile.Width = 250;
                this.btnLeaveRequest.Width = 250;
                this.btnAttendance.Width = 250;
                this.btnReports.Width = 250;
                this.btnSettings.Width = 250;
                this.btnLogout.Width = 250;

                // Left align text with padding
                this.SYSTEM.TextAlign = ContentAlignment.MiddleLeft;
                this.btnToggleSidebar.TextAlign = ContentAlignment.MiddleLeft;
                this.btnProfile.TextAlign = ContentAlignment.MiddleLeft;
                this.btnLeaveRequest.TextAlign = ContentAlignment.MiddleLeft;
                this.btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
                this.btnReports.TextAlign = ContentAlignment.MiddleLeft;
                this.btnSettings.TextAlign = ContentAlignment.MiddleLeft;
                this.btnLogout.TextAlign = ContentAlignment.MiddleLeft;

                // Add padding
                this.SYSTEM.Padding = new Padding(15, 0, 0, 0);
                this.btnToggleSidebar.Padding = new Padding(15, 0, 0, 0);
                this.btnProfile.Padding = new Padding(15, 0, 0, 0);
                this.btnLeaveRequest.Padding = new Padding(15, 0, 0, 0);
                this.btnAttendance.Padding = new Padding(15, 0, 0, 0);
                this.btnReports.Padding = new Padding(15, 0, 0, 0);
                this.btnSettings.Padding = new Padding(15, 0, 0, 0);
                this.btnLogout.Padding = new Padding(15, 0, 0, 0);

                sidebarExpanded = true;
            }
        }

        private Label txtname;
        private PictureBox pictureBox1;
    }
}