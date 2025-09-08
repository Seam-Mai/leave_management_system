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
    public partial class SettingChangePassword : System.Windows.Forms.Form
    {
        public SettingChangePassword()
        {
            InitializeComponent();
        }

        private void btnsave_MouseEnter(object sender, System.EventArgs e)
        {
            btnsave.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
        }

        private void btnsave_MouseLeave(object sender, System.EventArgs e)
        {
            btnsave.BackColor = System.Drawing.Color.FromArgb(0, 122, 204); 
        }

        private void btncancel_MouseEnter(object sender, System.EventArgs e)
        {
            btncancel.BackColor = System.Drawing.Color.FromArgb(255, 82, 82); 
        }

        private void btncancel_MouseLeave(object sender, System.EventArgs e)
        {
            btncancel.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); 
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}