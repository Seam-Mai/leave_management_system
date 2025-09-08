
using leave_management_system.Dashboard;
using leave_management_system.Dashboard.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace leave_management_system.Security
{
    public partial class Setting : System.Windows.Forms.UserControl
    {
        private SettingChangePassword settingChangePasswordUC;
        private EmployeeDashboard employeeDashboard;
       

        public Setting()
        {
            InitializeComponent();
            settingChangePasswordUC = new SettingChangePassword();
           
        }
     

        private void btnpassword_MouseEnter(object sender, System.EventArgs e)
        {
            btnpassword.BackColor = System.Drawing.Color.FromArgb(30, 144, 255); 
        }

        private void btnpassword_MouseLeave(object sender, System.EventArgs e)
        {
            btnpassword.BackColor = System.Drawing.Color.FromArgb(0, 122, 204); 
        }

        private void Setting_Load(object sender, System.EventArgs e)
        {
           
        }
        private void btnthem_MouseEnter(object sender, System.EventArgs e)
        {
            btnthem.BackColor = System.Drawing.Color.FromArgb(30, 144, 255); 
        }

        private void btnthem_MouseLeave(object sender, System.EventArgs e)
        {
            btnthem.BackColor = System.Drawing.Color.FromArgb(0, 122, 204); 
        }

        private void btnpassword_Click(object sender, EventArgs e) => settingChangePasswordUC.ShowDialog();



        private void btnthem_Click(object sender, EventArgs e)
        {
          
            if (employeeDashboard != null)
            {
                employeeDashboard.ChangeThem();
            }
            else
            {
                MessageBox.Show("EmployeeDashboard Change The Them Come Soon!.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}