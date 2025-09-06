using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace leave_management_system.Security
{
    public partial class Register : Form
    {
        private string connectionString = @"Data Source=SEAM-MAI\MSIDB;Initial Catalog=leave_system;Integrated Security=True;Encrypt=False;";

        public Register()
        {
            try
            {
                InitializeComponent();
                this.FormClosing += Register_FormClosing;

                // Test database connection
                TestDatabaseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Configuration error: {ex.Message}\nPlease check App.config.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TestDatabaseConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Database connected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LoadRoles();
            SetupFormValidation();
        }

        private void LoadRoles()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if Roles table exists
                    string checkTableQuery = @"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES 
                                            WHERE TABLE_NAME = 'Roles'";
                    using (SqlCommand checkCommand = new SqlCommand(checkTableQuery, connection))
                    {
                        if ((int)checkCommand.ExecuteScalar() == 0)
                        {
                            CreateRolesTable(connection);
                            InsertDefaultRoles(connection);
                        }
                    }

                    string query = "SELECT role_id, role_name FROM Roles ORDER BY role_name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            InsertDefaultRoles(connection);
                            adapter.Fill(dt);
                        }

                        cmbRole.Items.Clear();
                        cmbRole.DisplayMember = "role_name";
                        cmbRole.ValueMember = "role_id";
                        cmbRole.DataSource = dt;
                        cmbRole.SelectedIndex = -1;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error loading roles: {ex.Message}\nPlease check your database connection.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddDefaultRoles();
            }
            catch (TypeInitializationException ex)
            {
                MessageBox.Show($"Error: BCrypt-Official may not be properly installed. Run 'dotnet add package BCrypt-Official' or install via NuGet Package Manager.\nDetails: {ex.Message}",
                    "Dependency Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddDefaultRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error loading roles: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddDefaultRoles();
            }
        }

        private void CreateRolesTable(SqlConnection connection)
        {
            string createTableQuery = @"
                CREATE TABLE Roles (
                    role_id INT PRIMARY KEY IDENTITY(1,1),
                    role_name NVARCHAR(50) NOT NULL UNIQUE
                )";

            using (SqlCommand command = new SqlCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void InsertDefaultRoles(SqlConnection connection)
        {
            string insertRolesQuery = @"
                IF NOT EXISTS (SELECT 1 FROM Roles WHERE role_name IN ('Admin', 'Manager', 'Employee', 'HR'))
                BEGIN
                    INSERT INTO Roles (role_name) VALUES 
                    ('Admin'),
                    ('Manager'),
                    ('Employee'),
                    ('HR')
                END";

            using (SqlCommand command = new SqlCommand(insertRolesQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void AddDefaultRoles()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("role_id", typeof(int));
            dt.Columns.Add("role_name", typeof(string));

            dt.Rows.Add(1, "Admin");
            dt.Rows.Add(2, "Manager");
            dt.Rows.Add(3, "Employee");
            dt.Rows.Add(4, "HR");

            cmbRole.Items.Clear();
            cmbRole.DisplayMember = "role_name";
            cmbRole.ValueMember = "role_id";
            cmbRole.DataSource = dt;
            cmbRole.SelectedIndex = -1;

            MessageBox.Show("Using default roles due to database issue.\nPlease set up the database properly for production use.",
                "Using Default Roles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetupFormValidation()
        {
            txtFullName.Enter += TextBox_Enter;
            txtUsername.Enter += TextBox_Enter;
            txtEmail.Enter += TextBox_Enter;
            txtPassword.Enter += TextBox_Enter;
            txtConfirmPassword.Enter += TextBox_Enter;
            txtPosition.Enter += TextBox_Enter;

            txtFullName.Leave += TextBox_Leave;
            txtUsername.Leave += TextBox_Leave;
            txtEmail.Leave += TextBox_Leave;
            txtPassword.Leave += TextBox_Leave;
            txtConfirmPassword.Leave += TextBox_Leave;
            txtPosition.Leave += TextBox_Leave;

            txtEmail.TextChanged += ValidateEmail;
            txtPassword.TextChanged += ValidatePassword;
            txtConfirmPassword.TextChanged += ValidatePasswordMatch;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BackColor = Color.FromArgb(239, 246, 255);
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BackColor = Color.White;
            }
        }

        private void ValidateEmail(object sender, EventArgs e)
        {
            if (sender is TextBox emailBox && !string.IsNullOrEmpty(emailBox.Text))
            {
                emailBox.BackColor = IsValidEmail(emailBox.Text) ?
                    Color.White : Color.FromArgb(254, 226, 226);
            }
        }

        private void ValidatePassword(object sender, EventArgs e)
        {
            if (sender is TextBox passwordBox && !string.IsNullOrEmpty(passwordBox.Text))
            {
                passwordBox.BackColor = IsValidPassword(passwordBox.Text) ?
                    Color.White : Color.FromArgb(254, 226, 226);
            }
        }

        private void ValidatePasswordMatch(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.BackColor = txtPassword.Text == txtConfirmPassword.Text ?
                    Color.White : Color.FromArgb(254, 226, 226);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.Compiled);
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPassword(string password)
        {
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", RegexOptions.Compiled);
            return regex.IsMatch(password);
        }

        private bool ValidateForm()
        {
            ResetFieldColors();
            bool isValid = true;
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                txtFullName.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Full Name is required\n";
                isValid = false;
            }
            else if (txtFullName.Text.Length > 100)
            {
                txtFullName.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Full Name cannot exceed 100 characters\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Username is required\n";
                isValid = false;
            }
            else if (txtUsername.Text.Length < 3 || txtUsername.Text.Length > 50)
            {
                txtUsername.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Username must be between 3 and 50 characters\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Email is required\n";
                isValid = false;
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                txtEmail.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Please enter a valid email address\n";
                isValid = false;
            }
            else if (txtEmail.Text.Length > 100)
            {
                txtEmail.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Email cannot exceed 100 characters\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Password is required\n";
                isValid = false;
            }
            else if (!IsValidPassword(txtPassword.Text))
            {
                txtPassword.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Password must be at least 8 characters with uppercase, lowercase, number, and special character\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                txtConfirmPassword.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Please confirm your password\n";
                isValid = false;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                txtConfirmPassword.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Passwords do not match\n";
                isValid = false;
            }

            if (cmbRole.SelectedValue == null)
            {
                errorMessage += "• Please select a role\n";
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(txtPosition.Text) && txtPosition.Text.Length > 100)
            {
                txtPosition.BackColor = Color.FromArgb(254, 226, 226);
                errorMessage += "• Position cannot exceed 100 characters\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Please fix the following errors:\n\n" + errorMessage,
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValid;
        }

        private void ResetFieldColors()
        {
            txtFullName.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
            txtConfirmPassword.BackColor = Color.White;
            txtPosition.BackColor = Color.White;
        }

        private bool IsUserExists(string username, string email, out string existingField)
        {
            existingField = string.Empty;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT username, email FROM Users WHERE username = @username OR email = @email";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;
                        command.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = email;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                existingField = reader["username"].ToString().Equals(username, StringComparison.OrdinalIgnoreCase)
                                    ? "username" : "email";
                                return true;
                            }
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error checking user existence: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error checking user existence: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private void InitializeLeaveBalances(int userId, SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO LeaveBalance (user_id, leave_type_id, allocated_days, used_days)
                SELECT @userId, leave_type_id, ISNULL(max_days, 0), 0
                FROM LeaveTypes
                WHERE NOT EXISTS (
                    SELECT 1 FROM LeaveBalance 
                    WHERE user_id = @userId AND leave_type_id = LeaveTypes.leave_type_id
                )";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                command.ExecuteNonQuery();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (IsUserExists(username, email, out string existingField))
            {
                if (existingField == "username")
                {
                    txtUsername.BackColor = Color.FromArgb(254, 226, 226);
                    MessageBox.Show("Username already exists. Please choose a different username.",
                        "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }
                else
                {
                    txtEmail.BackColor = Color.FromArgb(254, 226, 226);
                    MessageBox.Show("Email already exists. Please use a different email address.",
                        "Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                }
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insert user
                            string query = @"
                                INSERT INTO Users (full_name, username, password, email, position, role_id)
                                OUTPUT INSERTED.user_id
                                VALUES (@fullName, @username, @password, @email, @position, @roleId)";

                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.Add("@fullName", SqlDbType.NVarChar, 100).Value = txtFullName.Text.Trim();
                                command.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;
                                command.Parameters.Add("@password", SqlDbType.NVarChar, 255).Value = txtPassword.Text.Trim();
                                command.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = email;
                                command.Parameters.Add("@position", SqlDbType.NVarChar, 100).Value = string.IsNullOrWhiteSpace(txtPosition.Text) ? (object)DBNull.Value : txtPosition.Text.Trim();
                                command.Parameters.Add("@roleId", SqlDbType.Int).Value = Convert.ToInt32(cmbRole.SelectedValue);

                                int userId = (int)command.ExecuteScalar();

                                // Initialize leave balances
                                InitializeLeaveBalances(userId, connection, transaction);

                                transaction.Commit();

                                MessageBox.Show("User registered successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm();
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error registering user: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TypeInitializationException ex)
            {
                MessageBox.Show($"Error: BCrypt-Official may not be properly installed. Run 'dotnet add package BCrypt-Official' or install via NuGet Package Manager.\nDetails: {ex.Message}",
                    "Dependency Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error registering user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtPosition.Clear();
            cmbRole.SelectedIndex = -1;
            ResetFieldColors();
            txtFullName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel registration?",
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                btnCancel_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Enter))
            {
                btnRegister_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HasUnsavedData())
            {
                DialogResult result = MessageBox.Show("You have unsaved changes. Are you sure you want to close?",
                    "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private bool HasUnsavedData()
        {
            return !string.IsNullOrWhiteSpace(txtFullName.Text) ||
                   !string.IsNullOrWhiteSpace(txtUsername.Text) ||
                   !string.IsNullOrWhiteSpace(txtEmail.Text) ||
                   !string.IsNullOrWhiteSpace(txtPassword.Text) ||
                   !string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                   !string.IsNullOrWhiteSpace(txtPosition.Text) ||
                   cmbRole.SelectedIndex != -1;
        }
    }
}