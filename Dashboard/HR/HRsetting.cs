using leave_management_system.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leave_management_system.Dashboard.HR
{
    public partial class HRsetting : UserControl
    {
        private SettingChangePassword settingChangePasswordUC;
        private EmployeeDashboard employeeDashboard;

        public HRsetting()
        {
            InitializeComponent();
            settingChangePasswordUC = new SettingChangePassword();
        }

        private void SECbtnpassword_MouseEnter(object sender, EventArgs e)
        {
            SECbtnpassword.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
        }

        private void SECbtnpassword_MouseLeave(object sender, EventArgs e)
        {
            SECbtnpassword.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            // You can initialize default values here if needed
        }

        private void SECbtnthem_MouseEnter(object sender, EventArgs e)
        {
            SECbtnthem.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
        }

        private void SECbtnthem_MouseLeave(object sender, EventArgs e)
        {
            SECbtnthem.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
        }

        private void SECbtnpassword_Click(object sender, EventArgs e)
        {
            // Assuming SettingChangePassword is a Form
            settingChangePasswordUC.ShowDialog();
        }

        private void SECbtnthem_Click(object sender, EventArgs e)
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

