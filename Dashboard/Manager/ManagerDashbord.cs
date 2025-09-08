using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace leave_management_system.Dashboard.Manager
{
    public partial class ManagerDashboard : Form
    {
        // UserControls
        private ManagerPendding managerpendingUC;
        private ManagerrequestLeave managerrequestLeaveUC;
        private Managerattendance managerattendanceUC;
        private ManagerView managerviewsUC;
        private ManagerSetting managersettingUC;
        private ManagerManage managerMangeUC;

        public ManagerDashboard()
        {
            InitializeComponent();

            // Initialize UserControls
            try
            {
                managerpendingUC = new ManagerPendding();
                managerrequestLeaveUC = new ManagerrequestLeave();
                managerattendanceUC = new Managerattendance();
                managerviewsUC = new ManagerView();
                managersettingUC = new ManagerSetting();
                managerMangeUC = new ManagerManage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing UserControls: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            LoadDefaultView();

            // Attach sidebar button events
            ManagerbtnProfile.Click += ManagerBtnProfile_Click;
            ManagerbtnLeaveRequest.Click += ManagerBtnLeaveRequest_Click;
            ManagerbtnAttendance.Click += ManagerBtnAttendance_Click;
            ManagerbtnReports.Click += ManagerBtnReports_Click;
            ManagerbtnSettings.Click += ManagerBtnSettings_Click;
            ManagerbtnManage.Click += ManagerBtnManage_Click;
            ManagerbtnLogout.Click += ManagerBtnLogout_Click;
        }

        // ================= Default view =================
        private void LoadDefaultView()
        {
            ManagerpanelMain.Controls.Clear();

            int panelWidth = ManagerpanelMain.Width;
            int panelHeight = ManagerpanelMain.Height;

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
            Button ManagerbtnPending = new Button();
            ManagerbtnPending.Text = "Pending Requests";
            ManagerbtnPending.Size = new System.Drawing.Size(btnWidth, btnHeight);
            ManagerbtnPending.Location = new System.Drawing.Point(startX, startY);
            ManagerbtnPending.Click += (s, e) => LoadUserControl(managerpendingUC);
            ManagerpanelMain.Controls.Add(ManagerbtnPending);

            Button ManagerbtnRequestLeave = new Button();
            ManagerbtnRequestLeave.Text = "Request Leave";
            ManagerbtnRequestLeave.Size = new System.Drawing.Size(btnWidth, btnHeight);
            ManagerbtnRequestLeave.Location = new System.Drawing.Point(startX + btnWidth + spacing, startY);
            ManagerbtnRequestLeave.Click += (s, e) => LoadUserControl(managerrequestLeaveUC);
            ManagerpanelMain.Controls.Add(ManagerbtnRequestLeave);

            Button ManagerbtnAttendance = new Button();
            ManagerbtnAttendance.Text = "Attendance";
            ManagerbtnAttendance.Size = new System.Drawing.Size(btnWidth, btnHeight);
            ManagerbtnAttendance.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY);
            ManagerbtnAttendance.Click += (s, e) => LoadUserControl(managerattendanceUC);
            ManagerpanelMain.Controls.Add(ManagerbtnAttendance);

            Button ManagerbtnManage = new Button();
            ManagerbtnManage.Text = "Manage HR";
            ManagerbtnManage.Size = new System.Drawing.Size(btnWidth, btnHeight);
            ManagerbtnManage.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 3, startY);
            ManagerbtnManage.Click += (s, e) => LoadUserControl(managerMangeUC);
            ManagerpanelMain.Controls.Add(ManagerbtnManage);
        }

        // ================= Load UserControl =================
        private void LoadUserControl(UserControl uc)
        {
            ManagerpanelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            ManagerpanelMain.Controls.Add(uc);
        }

        // ================= Change Theme =================
        public void ChangeThem()
        {
            ManagerpanelSidebar.BackColor = Color.LightGray;
            ManagerpanelHeader.BackColor = Color.LightGray;
        }

        // ================= Sidebar button clicks =================
        private void ManagerBtnProfile_Click(object sender, EventArgs e) => LoadUserControl(managerpendingUC);

        private void ManagerBtnLeaveRequest_Click(object sender, EventArgs e) => LoadUserControl(managerrequestLeaveUC);

        private void ManagerBtnAttendance_Click(object sender, EventArgs e) => LoadUserControl(managerattendanceUC);

        private void ManagerBtnReports_Click(object sender, EventArgs e) => LoadUserControl(managerviewsUC);

        private void ManagerBtnSettings_Click(object sender, EventArgs e) => LoadUserControl(managersettingUC);

        private void ManagerBtnManage_Click(object sender, EventArgs e) => LoadUserControl(managerMangeUC);

        private void ManagerBtnLogout_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }
    }
}