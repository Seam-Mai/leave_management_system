using System;
using System.Windows.Forms;
using leave_management_system.Dashboard.Employee;

namespace leave_management_system.Dashboard
{
    public partial class EmployeeDashboard : Form
    {
        // UserControls
        private PenddingEmployee penddingUC;
        private RequestLeave requestLeaveUC;
        private Attendance attendanceUC; // declare

        public EmployeeDashboard()
        {
            InitializeComponent();

            // Initialize UserControls
            penddingUC = new PenddingEmployee();
            requestLeaveUC = new RequestLeave();
            attendanceUC = new Attendance(); // initialize

            // Load default view (options buttons)
            LoadDefaultView();

            // Attach sidebar button events
            btnProfile.Click += BtnProfile_Click;
            btnLeaveRequest.Click += BtnLeaveRequest_Click;
            btnAttendance.Click += BtnAttendance_Click;
        }

        // ================= Default view =================
        private void LoadDefaultView()
        {
            panelMain.Controls.Clear();

            int panelWidth = panelMain.Width;
            int panelHeight = panelMain.Height;

            int btnWidth = 200;
            int btnHeight = 60;
            int spacing = 30;

            // Correct total width for 3 buttons
            int totalWidth = (btnWidth * 3) + (spacing * 2);

            // Center horizontally and vertically
            int startX = (panelWidth - totalWidth) / 2;
            int startY = (panelHeight - btnHeight) / 2;

            // ================= Buttons =================
            Button btnPendding = new Button();
            btnPendding.Text = "Pendding Requests";
            btnPendding.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnPendding.Location = new System.Drawing.Point(startX, startY);
            btnPendding.Click += (s, e) => LoadUserControl(penddingUC);
            panelMain.Controls.Add(btnPendding);

            Button btnRequestLeave = new Button();
            btnRequestLeave.Text = "Request Leave";
            btnRequestLeave.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnRequestLeave.Location = new System.Drawing.Point(startX + btnWidth + spacing, startY);
            btnRequestLeave.Click += (s, e) => LoadUserControl(requestLeaveUC);
            panelMain.Controls.Add(btnRequestLeave);

            Button btnAttendance = new Button();
            btnAttendance.Text = "Attendance";
            btnAttendance.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnAttendance.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY);
            btnAttendance.Click += (s, e) => LoadUserControl(attendanceUC);
            panelMain.Controls.Add(btnAttendance);
        }
        // ================= Load UserControl =================
        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill; // ensure it fills panel
            panelMain.Controls.Add(uc);
        }

        // ================= Sidebar button clicks =================
        private void BtnProfile_Click(object sender, EventArgs e) => LoadUserControl(penddingUC);

        private void BtnLeaveRequest_Click(object sender, EventArgs e) => LoadUserControl(requestLeaveUC);

        private void BtnAttendance_Click(object sender, EventArgs e) => LoadUserControl(attendanceUC);
    }
}
