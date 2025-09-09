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
    public partial class AdminPassword : Form
    {
        public AdminPassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Come soon !.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
