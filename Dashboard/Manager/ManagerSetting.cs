using leave_management_system.Dashboard.HR;
using leave_management_system.Security;
using System;
using System.Windows.Forms;

namespace leave_management_system.Dashboard.Manager
{
    public partial class ManagerSetting : UserControl
    {
        private SettingChangePassword settingChangePasswordUC;
        private EmployeeDashboard employeeDashboard;

        public ManagerSetting()
        {
            InitializeComponent();
            settingChangePasswordUC = new SettingChangePassword();
        }

        private void Mbtnpassword_MouseEnter(object sender, EventArgs e)
        {
            Mbtnpassword.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
        }

        private void Mbtnpassword_MouseLeave(object sender, EventArgs e)
        {
            Mbtnpassword.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
        }

        private void ManagerSetting_Load(object sender, EventArgs e)
        {
            // You can initialize default values here if needed
        }

        private void Mbtnthem_MouseEnter(object sender, EventArgs e)
        {
            Mbtnthem.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
        }

        private void Mbtnthem_MouseLeave(object sender, EventArgs e)
        {
            Mbtnthem.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
        }

        private void Mbtnpassword_Click(object sender, EventArgs e)
        {
            // Assuming SettingChangePassword is a Form
            settingChangePasswordUC.ShowDialog();
        }

        private void Mbtnthem_Click(object sender, EventArgs e)
        {
            if (employeeDashboard != null)
            {
                employeeDashboard.ChangeThem();
            }
            else
            {
                MessageBox.Show("EmployeeDashboard Change The Theme will come soon!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
