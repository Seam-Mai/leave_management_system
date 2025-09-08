using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using leave_management_system.Dashboard.Employee;
using leave_management_system.Security;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace leave_management_system.Dashboard.HR
{
    public partial class HRDashboard : Form
    {
        // UserControls
        private HRpending hrpendingUC;
        private HRrequestLeave hrrequestLeaveUC;
        private HRattendance hrattendanceUC;
        private HRviews hrviewsUC;
        private HRsetting hrsettingUC;
        private HRMange hRMangeUC;

        public HRDashboard()
        {
            InitializeComponent();

            // Initialize UserControls
            try
            {
                hrpendingUC = new HRpending();
                hrrequestLeaveUC = new HRrequestLeave();
                hrattendanceUC = new HRattendance();
                hrviewsUC = new HRviews();
                hrsettingUC = new HRsetting();
                hRMangeUC = new HRMange();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing UserControls: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Load default view (options buttons)
            LoadDefaultView();

            // Attach sidebar button events
            HRbtnProfile.Click += HRBtnProfile_Click;
            HRbtnLeaveRequest.Click += HRBtnLeaveRequest_Click;
            HRbtnAttendance.Click += HRBtnAttendance_Click;
            HRbtnReports.Click += HRBtnReports_Click;
            HRbtnSettings.Click += HRBtnSettings_Click;
            HRbtnManage.Click += HRBtnManage_Click;
            
        }

        // ================= Default view =================
        private void LoadDefaultView()
        {
            HRpanelMain.Controls.Clear();

            int panelWidth = HRpanelMain.Width;
            int panelHeight = HRpanelMain.Height;

            int btnWidth = 150;
            int btnHeight = 40;
            int spacing = 20;

            // Correct total width for 4 buttons
            int totalWidth = (btnWidth * 4) + (spacing * 3);

            // Center horizontally and vertically
            int startX = (panelWidth - totalWidth) / 2;
            int startY = (panelHeight - btnHeight) / 2;

            // Move buttons up a bit
            startY -= 200;

            // ================= Buttons =================
            Button HRbtnPending = new Button();
            HRbtnPending.Text = "Pending Requests";
            HRbtnPending.Size = new System.Drawing.Size(btnWidth, btnHeight);
            HRbtnPending.Location = new System.Drawing.Point(startX, startY);
            HRbtnPending.Click += (s, e) => LoadUserControl(hrpendingUC);
            HRpanelMain.Controls.Add(HRbtnPending);

            Button HRbtnRequestLeave = new Button();
            HRbtnRequestLeave.Text = "Request Leave";
            HRbtnRequestLeave.Size = new System.Drawing.Size(btnWidth, btnHeight);
            HRbtnRequestLeave.Location = new System.Drawing.Point(startX + btnWidth + spacing, startY);
            HRbtnRequestLeave.Click += (s, e) => LoadUserControl(hrrequestLeaveUC);
            HRpanelMain.Controls.Add(HRbtnRequestLeave);

            Button HRbtnAttendance = new Button();
            HRbtnAttendance.Text = "Attendance";
            HRbtnAttendance.Size = new System.Drawing.Size(btnWidth, btnHeight);
            HRbtnAttendance.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY);
            HRbtnAttendance.Click += (s, e) => LoadUserControl(hrattendanceUC);
            HRpanelMain.Controls.Add(HRbtnAttendance);

            Button HRbtnManage = new Button();
            HRbtnManage.Text = "Manage HR";
            HRbtnManage.Size = new System.Drawing.Size(btnWidth, btnHeight);
            HRbtnManage.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 3, startY);
            HRbtnManage.Click += (s, e) => LoadUserControl(hRMangeUC);
            HRpanelMain.Controls.Add(HRbtnManage);
        }

        // ================= Load UserControl =================
        private void LoadUserControl(UserControl uc)
        {
            HRpanelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            HRpanelMain.Controls.Add(uc);
        }

        // ================= Change Theme =================
        public void ChangeThem()
        {
            HRpanelSidebar.BackColor = Color.LightGray;
            HRpanelHeader.BackColor = Color.LightGray;
        }

        // ================= Sidebar button clicks =================
        private void HRBtnProfile_Click(object sender, EventArgs e) => LoadUserControl(hrpendingUC);

        private void HRBtnLeaveRequest_Click(object sender, EventArgs e) => LoadUserControl(hrrequestLeaveUC);

        private void HRBtnAttendance_Click(object sender, EventArgs e) => LoadUserControl(hrattendanceUC);

        private void HRBtnReports_Click(object sender, EventArgs e) => LoadUserControl(hrviewsUC);

        private void HRBtnSettings_Click(object sender, EventArgs e) => LoadUserControl(hrsettingUC);

        private void HRBtnManage_Click(object sender, EventArgs e) => LoadUserControl(hRMangeUC);

    }
}