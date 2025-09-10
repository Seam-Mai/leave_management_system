using System;
using System.Drawing;
using System.Windows.Forms;


namespace leave_management_system.Dashboard.Manager
{
   
    
        partial class ManagerDashboard
        {
            private Panel ManagerpanelSidebar;
            private Panel ManagerpanelHeader;
            private Panel ManagerpanelMain;
            private Button ManagerbtnProfile;
            private Button ManagerbtnLeaveRequest;
            private Button ManagerbtnAttendance;
            private Button ManagerbtnLogout;
            private Button ManagerbtnToggleSidebar;
            private Button ManagerSYSTEM;
            private Button ManagerbtnSettings;
            private Button ManagerbtnReports;
            private Button ManagerbtnManage;
            private bool sidebarExpanded = true;
            private Label Managertxtname;
            private PictureBox ManagerpictureBox1;

            private void InitializeComponent()
            {
            this.ManagerpanelSidebar = new System.Windows.Forms.Panel();
            this.ManagerbtnManage = new System.Windows.Forms.Button();
            this.ManagerSYSTEM = new System.Windows.Forms.Button();
            this.ManagerbtnToggleSidebar = new System.Windows.Forms.Button();
            this.ManagerbtnProfile = new System.Windows.Forms.Button();
            this.ManagerbtnLeaveRequest = new System.Windows.Forms.Button();
            this.ManagerbtnAttendance = new System.Windows.Forms.Button();
            this.ManagerbtnReports = new System.Windows.Forms.Button();
            this.ManagerbtnSettings = new System.Windows.Forms.Button();
            this.ManagerbtnLogout = new System.Windows.Forms.Button();
            this.ManagerpanelHeader = new System.Windows.Forms.Panel();
            this.ManagerpictureBox1 = new System.Windows.Forms.PictureBox();
            this.Managertxtname = new System.Windows.Forms.Label();
            this.ManagerpanelMain = new System.Windows.Forms.Panel();
            this.ManagerpanelSidebar.SuspendLayout();
            this.ManagerpanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerpanelSidebar
            // 
            this.ManagerpanelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ManagerpanelSidebar.Controls.Add(this.ManagerbtnManage);
            this.ManagerpanelSidebar.Controls.Add(this.ManagerSYSTEM);
            this.ManagerpanelSidebar.Controls.Add(this.ManagerbtnToggleSidebar);
            this.ManagerpanelSidebar.Controls.Add(this.ManagerbtnProfile);
            this.ManagerpanelSidebar.Controls.Add(this.ManagerbtnLeaveRequest);
            this.ManagerpanelSidebar.Controls.Add(this.ManagerbtnAttendance);
            this.ManagerpanelSidebar.Controls.Add(this.ManagerbtnReports);
            this.ManagerpanelSidebar.Controls.Add(this.ManagerbtnSettings);
            this.ManagerpanelSidebar.Controls.Add(this.ManagerbtnLogout);
            this.ManagerpanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ManagerpanelSidebar.Location = new System.Drawing.Point(0, 0);
            this.ManagerpanelSidebar.Name = "ManagerpanelSidebar";
            this.ManagerpanelSidebar.Size = new System.Drawing.Size(250, 700);
            this.ManagerpanelSidebar.TabIndex = 0;
            // 
            // ManagerbtnManage
            // 
            this.ManagerbtnManage.FlatAppearance.BorderSize = 0;
            this.ManagerbtnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ManagerbtnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerbtnManage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManagerbtnManage.ForeColor = System.Drawing.Color.White;
            this.ManagerbtnManage.Location = new System.Drawing.Point(0, 466);
            this.ManagerbtnManage.Name = "ManagerbtnManage";
            this.ManagerbtnManage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ManagerbtnManage.Size = new System.Drawing.Size(250, 50);
            this.ManagerbtnManage.TabIndex = 8;
            this.ManagerbtnManage.Text = "👥  Manage Leave";
            this.ManagerbtnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerbtnManage.UseVisualStyleBackColor = true;
            this.ManagerbtnManage.Click += new System.EventHandler(this.ManagerBtnManage_Click);
            // 
            // ManagerSYSTEM
            // 
            this.ManagerSYSTEM.FlatAppearance.BorderSize = 0;
            this.ManagerSYSTEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerSYSTEM.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.ManagerSYSTEM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ManagerSYSTEM.Location = new System.Drawing.Point(0, 20);
            this.ManagerSYSTEM.Name = "ManagerSYSTEM";
            this.ManagerSYSTEM.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ManagerSYSTEM.Size = new System.Drawing.Size(250, 60);
            this.ManagerSYSTEM.TabIndex = 0;
            this.ManagerSYSTEM.Text = "📋 Manager Leave System";
            this.ManagerSYSTEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerSYSTEM.UseVisualStyleBackColor = true;
            // 
            // ManagerbtnToggleSidebar
            // 
            this.ManagerbtnToggleSidebar.FlatAppearance.BorderSize = 0;
            this.ManagerbtnToggleSidebar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ManagerbtnToggleSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerbtnToggleSidebar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ManagerbtnToggleSidebar.ForeColor = System.Drawing.Color.White;
            this.ManagerbtnToggleSidebar.Location = new System.Drawing.Point(0, 90);
            this.ManagerbtnToggleSidebar.Name = "ManagerbtnToggleSidebar";
            this.ManagerbtnToggleSidebar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ManagerbtnToggleSidebar.Size = new System.Drawing.Size(250, 50);
            this.ManagerbtnToggleSidebar.TabIndex = 1;
            this.ManagerbtnToggleSidebar.Text = "☰  Menu";
            this.ManagerbtnToggleSidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerbtnToggleSidebar.UseVisualStyleBackColor = true;
            this.ManagerbtnToggleSidebar.Click += new System.EventHandler(this.ManagerbtnToggleSidebar_Click);
            // 
            // ManagerbtnProfile
            // 
            this.ManagerbtnProfile.FlatAppearance.BorderSize = 0;
            this.ManagerbtnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ManagerbtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerbtnProfile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManagerbtnProfile.ForeColor = System.Drawing.Color.White;
            this.ManagerbtnProfile.Location = new System.Drawing.Point(0, 160);
            this.ManagerbtnProfile.Name = "ManagerbtnProfile";
            this.ManagerbtnProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ManagerbtnProfile.Size = new System.Drawing.Size(250, 50);
            this.ManagerbtnProfile.TabIndex = 2;
            this.ManagerbtnProfile.Text = "🏠  Home";
            this.ManagerbtnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerbtnProfile.UseVisualStyleBackColor = true;
            this.ManagerbtnProfile.Click += new System.EventHandler(this.ManagerBtnProfile_Click);
            // 
            // ManagerbtnLeaveRequest
            // 
            this.ManagerbtnLeaveRequest.FlatAppearance.BorderSize = 0;
            this.ManagerbtnLeaveRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ManagerbtnLeaveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerbtnLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManagerbtnLeaveRequest.ForeColor = System.Drawing.Color.White;
            this.ManagerbtnLeaveRequest.Location = new System.Drawing.Point(0, 220);
            this.ManagerbtnLeaveRequest.Name = "ManagerbtnLeaveRequest";
            this.ManagerbtnLeaveRequest.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ManagerbtnLeaveRequest.Size = new System.Drawing.Size(250, 50);
            this.ManagerbtnLeaveRequest.TabIndex = 3;
            this.ManagerbtnLeaveRequest.Text = "📝  Leave Requests";
            this.ManagerbtnLeaveRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerbtnLeaveRequest.UseVisualStyleBackColor = true;
            this.ManagerbtnLeaveRequest.Click += new System.EventHandler(this.ManagerBtnLeaveRequest_Click);
            // 
            // ManagerbtnAttendance
            // 
            this.ManagerbtnAttendance.FlatAppearance.BorderSize = 0;
            this.ManagerbtnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ManagerbtnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerbtnAttendance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManagerbtnAttendance.ForeColor = System.Drawing.Color.White;
            this.ManagerbtnAttendance.Location = new System.Drawing.Point(0, 280);
            this.ManagerbtnAttendance.Name = "ManagerbtnAttendance";
            this.ManagerbtnAttendance.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ManagerbtnAttendance.Size = new System.Drawing.Size(250, 50);
            this.ManagerbtnAttendance.TabIndex = 4;
            this.ManagerbtnAttendance.Text = "📅  Attendance";
            this.ManagerbtnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerbtnAttendance.UseVisualStyleBackColor = true;
            this.ManagerbtnAttendance.Click += new System.EventHandler(this.ManagerBtnAttendance_Click);
            // 
            // ManagerbtnReports
            // 
            this.ManagerbtnReports.FlatAppearance.BorderSize = 0;
            this.ManagerbtnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ManagerbtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerbtnReports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManagerbtnReports.ForeColor = System.Drawing.Color.White;
            this.ManagerbtnReports.Location = new System.Drawing.Point(0, 340);
            this.ManagerbtnReports.Name = "ManagerbtnReports";
            this.ManagerbtnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ManagerbtnReports.Size = new System.Drawing.Size(250, 50);
            this.ManagerbtnReports.TabIndex = 5;
            this.ManagerbtnReports.Text = "📊  Reports";
            this.ManagerbtnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerbtnReports.UseVisualStyleBackColor = true;
            this.ManagerbtnReports.Click += new System.EventHandler(this.ManagerBtnReports_Click);
            // 
            // ManagerbtnSettings
            // 
            this.ManagerbtnSettings.FlatAppearance.BorderSize = 0;
            this.ManagerbtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ManagerbtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerbtnSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManagerbtnSettings.ForeColor = System.Drawing.Color.White;
            this.ManagerbtnSettings.Location = new System.Drawing.Point(0, 400);
            this.ManagerbtnSettings.Name = "ManagerbtnSettings";
            this.ManagerbtnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ManagerbtnSettings.Size = new System.Drawing.Size(250, 50);
            this.ManagerbtnSettings.TabIndex = 6;
            this.ManagerbtnSettings.Text = "⚙️  Settings";
            this.ManagerbtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerbtnSettings.UseVisualStyleBackColor = true;
            this.ManagerbtnSettings.Click += new System.EventHandler(this.ManagerBtnSettings_Click);
            // 
            // ManagerbtnLogout
            // 
            this.ManagerbtnLogout.FlatAppearance.BorderSize = 0;
            this.ManagerbtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.ManagerbtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerbtnLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManagerbtnLogout.ForeColor = System.Drawing.Color.White;
            this.ManagerbtnLogout.Location = new System.Drawing.Point(0, 620);
            this.ManagerbtnLogout.Name = "ManagerbtnLogout";
            this.ManagerbtnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ManagerbtnLogout.Size = new System.Drawing.Size(250, 50);
            this.ManagerbtnLogout.TabIndex = 7;
            this.ManagerbtnLogout.Text = "🚪  Logout";
            this.ManagerbtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerbtnLogout.UseVisualStyleBackColor = true;
            this.ManagerbtnLogout.Click += new System.EventHandler(this.ManagerbtnLogout_Click_1);
            // 
            // ManagerpanelHeader
            // 
            this.ManagerpanelHeader.BackColor = System.Drawing.Color.Teal;
            this.ManagerpanelHeader.Controls.Add(this.ManagerpictureBox1);
            this.ManagerpanelHeader.Controls.Add(this.Managertxtname);
            this.ManagerpanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerpanelHeader.Location = new System.Drawing.Point(250, 0);
            this.ManagerpanelHeader.Name = "ManagerpanelHeader";
            this.ManagerpanelHeader.Size = new System.Drawing.Size(830, 55);
            this.ManagerpanelHeader.TabIndex = 1;
            // 
            // ManagerpictureBox1
            // 
            this.ManagerpictureBox1.Location = new System.Drawing.Point(673, 9);
            this.ManagerpictureBox1.Name = "ManagerpictureBox1";
            this.ManagerpictureBox1.Size = new System.Drawing.Size(34, 37);
            this.ManagerpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManagerpictureBox1.TabIndex = 1;
            this.ManagerpictureBox1.TabStop = false;
            // 
            // Managertxtname
            // 
            this.Managertxtname.AutoSize = true;
            this.Managertxtname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Managertxtname.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Managertxtname.Location = new System.Drawing.Point(724, 20);
            this.Managertxtname.Name = "Managertxtname";
            this.Managertxtname.Size = new System.Drawing.Size(68, 16);
            this.Managertxtname.TabIndex = 0;
            this.Managertxtname.Text = "Seam Mai";
            this.Managertxtname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManagerpanelMain
            // 
            this.ManagerpanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ManagerpanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagerpanelMain.Location = new System.Drawing.Point(250, 55);
            this.ManagerpanelMain.Name = "ManagerpanelMain";
            this.ManagerpanelMain.Size = new System.Drawing.Size(830, 645);
            this.ManagerpanelMain.TabIndex = 2;
            // 
            // ManagerDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.ManagerpanelMain);
            this.Controls.Add(this.ManagerpanelHeader);
            this.Controls.Add(this.ManagerpanelSidebar);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Dashboard - Leave Management System";
            this.ManagerpanelSidebar.ResumeLayout(false);
            this.ManagerpanelHeader.ResumeLayout(false);
            this.ManagerpanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerpictureBox1)).EndInit();
            this.ResumeLayout(false);

            }

            private void ManagerbtnToggleSidebar_Click(object sender, EventArgs e)
            {
                if (sidebarExpanded)
                {
                    // Collapse sidebar - hide text, show only icons
                    this.ManagerpanelSidebar.Width = 80;

                    // Update button texts to show only icons
                    this.ManagerSYSTEM.Text = "📋";
                    this.ManagerbtnToggleSidebar.Text = "☰";
                    this.ManagerbtnProfile.Text = "🏠";
                    this.ManagerbtnLeaveRequest.Text = "📝";
                    this.ManagerbtnAttendance.Text = "📅";
                    this.ManagerbtnReports.Text = "📊";
                    this.ManagerbtnSettings.Text = "⚙️";
                    this.ManagerbtnManage.Text = "👥";
                    this.ManagerbtnLogout.Text = "🚪";

                    // Update button sizes and alignment
                    this.ManagerSYSTEM.Width = 80;
                    this.ManagerbtnToggleSidebar.Width = 80;
                    this.ManagerbtnProfile.Width = 80;
                    this.ManagerbtnLeaveRequest.Width = 80;
                    this.ManagerbtnAttendance.Width = 80;
                    this.ManagerbtnReports.Width = 80;
                    this.ManagerbtnSettings.Width = 80;
                    this.ManagerbtnManage.Width = 80;
                    this.ManagerbtnLogout.Width = 80;

                    // Center align text for icons only
                    this.ManagerSYSTEM.TextAlign = ContentAlignment.MiddleCenter;
                    this.ManagerbtnToggleSidebar.TextAlign = ContentAlignment.MiddleCenter;
                    this.ManagerbtnProfile.TextAlign = ContentAlignment.MiddleCenter;
                    this.ManagerbtnLeaveRequest.TextAlign = ContentAlignment.MiddleCenter;
                    this.ManagerbtnAttendance.TextAlign = ContentAlignment.MiddleCenter;
                    this.ManagerbtnReports.TextAlign = ContentAlignment.MiddleCenter;
                    this.ManagerbtnSettings.TextAlign = ContentAlignment.MiddleCenter;
                    this.ManagerbtnManage.TextAlign = ContentAlignment.MiddleCenter;
                    this.ManagerbtnLogout.TextAlign = ContentAlignment.MiddleCenter;

                    // Remove padding
                    this.ManagerSYSTEM.Padding = new Padding(0);
                    this.ManagerbtnToggleSidebar.Padding = new Padding(0);
                    this.ManagerbtnProfile.Padding = new Padding(0);
                    this.ManagerbtnLeaveRequest.Padding = new Padding(0);
                    this.ManagerbtnAttendance.Padding = new Padding(0);
                    this.ManagerbtnReports.Padding = new Padding(0);
                    this.ManagerbtnSettings.Padding = new Padding(0);
                    this.ManagerbtnManage.Padding = new Padding(0);
                    this.ManagerbtnLogout.Padding = new Padding(0);

                    sidebarExpanded = false;
                }
                else
                {
                    // Expand sidebar - show text with icons
                    this.ManagerpanelSidebar.Width = 250;

                    // Update button texts to show icons with text
                    this.ManagerSYSTEM.Text = "📋 Manager Leave System";
                    this.ManagerbtnToggleSidebar.Text = "☰  Menu";
                    this.ManagerbtnProfile.Text = "🏠  Home";
                    this.ManagerbtnLeaveRequest.Text = "📝  Leave Requests";
                    this.ManagerbtnAttendance.Text = "📅  Attendance";
                    this.ManagerbtnReports.Text = "📊  Reports";
                    this.ManagerbtnSettings.Text = "⚙️  Settings";
                    this.ManagerbtnManage.Text = "👥  Manage Leave";
                    this.ManagerbtnLogout.Text = "🚪  Logout";

                    // Update button sizes
                    this.ManagerSYSTEM.Width = 250;
                    this.ManagerbtnToggleSidebar.Width = 250;
                    this.ManagerbtnProfile.Width = 250;
                    this.ManagerbtnLeaveRequest.Width = 250;
                    this.ManagerbtnAttendance.Width = 250;
                    this.ManagerbtnReports.Width = 250;
                    this.ManagerbtnSettings.Width = 250;
                    this.ManagerbtnManage.Width = 250;
                    this.ManagerbtnLogout.Width = 250;

                    // Left align text with padding
                    this.ManagerSYSTEM.TextAlign = ContentAlignment.MiddleLeft;
                    this.ManagerbtnToggleSidebar.TextAlign = ContentAlignment.MiddleLeft;
                    this.ManagerbtnProfile.TextAlign = ContentAlignment.MiddleLeft;
                    this.ManagerbtnLeaveRequest.TextAlign = ContentAlignment.MiddleLeft;
                    this.ManagerbtnAttendance.TextAlign = ContentAlignment.MiddleLeft;
                    this.ManagerbtnReports.TextAlign = ContentAlignment.MiddleLeft;
                    this.ManagerbtnSettings.TextAlign = ContentAlignment.MiddleLeft;
                    this.ManagerbtnManage.TextAlign = ContentAlignment.MiddleLeft;
                    this.ManagerbtnLogout.TextAlign = ContentAlignment.MiddleLeft;

                    // Add padding
                    this.ManagerSYSTEM.Padding = new Padding(15, 0, 0, 0);
                    this.ManagerbtnToggleSidebar.Padding = new Padding(15, 0, 0, 0);
                    this.ManagerbtnProfile.Padding = new Padding(15, 0, 0, 0);
                    this.ManagerbtnLeaveRequest.Padding = new Padding(15, 0, 0, 0);
                    this.ManagerbtnAttendance.Padding = new Padding(15, 0, 0, 0);
                    this.ManagerbtnReports.Padding = new Padding(15, 0, 0, 0);
                    this.ManagerbtnSettings.Padding = new Padding(15, 0, 0, 0);
                    this.ManagerbtnManage.Padding = new Padding(15, 0, 0, 0);
                    this.ManagerbtnLogout.Padding = new Padding(15, 0, 0, 0);

                    sidebarExpanded = true;
                }
            }

          
          
        }
    }