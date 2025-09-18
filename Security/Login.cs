using leave_management_system.Dashboard;
using leave_management_system.Dashboard.HR;
using leave_management_system.Dashboard.Manager;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace leave_management_system.Security
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Server=SEAM-MAI\MSIDB;Database=leave_system;Integrated Security=true;Encrypt=False";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // CORRECTED QUERY: Use the exact column names from your database
                    string query = @"SELECT u.user_id, u.username, u.full_name, u.email, u.position, r.role_name, u.role_id 
                                     FROM Users u 
                                     INNER JOIN Roles r ON u.role_id = r.role_id
                                     WHERE u.username = @username AND u.password = @password";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Save user info into global session
                        GlobalUserInfo.CurrentUser = new UserInfo
                        {
                            UserId = Convert.ToInt32(reader["user_id"]),
                            Username = reader["username"].ToString(),
                            DisplayName = reader["full_name"].ToString(),
                            Email = reader["email"].ToString(),
                            RoleId = Convert.ToInt32(reader["role_id"]),
                            RoleName = reader["role_name"].ToString(), // Changed from position to role_name
                            LastLogin = DateTime.Now
                        };

                        reader.Close();

                        MessageBox.Show($"Welcome {GlobalUserInfo.CurrentUser.DisplayName}!",
                            "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect based on role
                        RedirectToRoleDashboard(GlobalUserInfo.CurrentUser.RoleId);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RedirectToRoleDashboard(int roleId)
        {
            try
            {
                switch (roleId)
                {
                    case 1:// Employee
                        EmployeeDashboard empDash = new EmployeeDashboard();
                        empDash.Show();
                        this.Hide();
                        break;

                    case 2: // HR 
                       
                        HRDashboard hRDashboard = new HRDashboard();
                        hRDashboard.Show();
                        
                        this.Hide();
                        break;

                    case 3:// Manager 
                        ManagerDashboard mgrDash = new ManagerDashboard();
                        mgrDash.Show();
                        this.Hide();
                        break;

                    case 4: // Admin

                        Register adminDash = new Register();
                        adminDash.Show();
                        this.Hide();
                        break;

                    default:
                        MessageBox.Show("Unknown role. Please contact administrator.",
                            "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening dashboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}