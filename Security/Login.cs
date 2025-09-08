using leave_management_system.Dashboard;
using leave_management_system.Dashboard.HR;
using leave_management_system.Dashboard.Manager;
using System;
using System.Data;
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

            // Basic validation
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

                
                    string query = @"SELECT u.role_id, u.username 
                                    FROM Users u 
                                    JOIN Roles r ON u.role_id = r.role_id 
                                    WHERE u.username = @username AND u.password = @password";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                      
                        int roleId = Convert.ToInt32(reader["role_id"]);
                        string userName = reader["username"].ToString();

                        reader.Close();

                     
                        MessageBox.Show($"Welcome {userName}!", "Login Successful",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                      
                        RedirectToRoleDashboard(roleId);
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
                    case 1: // Admin
                        Register adminDash = new Register();
                        adminDash.Show();
                        this.Hide();
                        break;

                    case 2: // Manager
                        ManagerDashboard mgrDash = new ManagerDashboard();
                        mgrDash.Show();
                        this.Hide();
                        break;

                    case 3: // Employee
                        EmployeeDashboard empDash = new EmployeeDashboard();
                        empDash.Show();
                        this.Hide();
                        break;

                    case 4: // HR
                        HRDashboard hrDash = new HRDashboard();
                        hrDash.Show();
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