using leave_management_system.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace leave_management_system.Dashboard.Manager
{
    public partial class ManagerrequestLeave : UserControl
    {
        string ConnectionString = @"Server=SEAM-MAI\MSIDB;Database=leave_system;Integrated Security=true;Encrypt=False";
        private int? selectedRequestId = null;
        private int currentUserId;

        public ManagerrequestLeave()
        {
            InitializeComponent();

            // Initialize with proper null checking
            if (GlobalUserInfo.CurrentUser != null)
            {
                currentUserId = GlobalUserInfo.CurrentUser.UserId;
            }
            else
            {
                MessageBox.Show("User not authenticated. Please login again.");
                currentUserId = 1; // Default to user ID 1 for testing - change this in production
            }
        }

        private void MrequestLeaveLoad(object sender, EventArgs e)
        {
            try
            {
                // Validate user authentication first
                if (currentUserId <= 0)
                {
                    MessageBox.Show("Invalid user session. Please login again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Display current user info (optional for debugging)
                if (GlobalUserInfo.CurrentUser != null)
                {
                    // Uncomment next line to see current user info
                    // MessageBox.Show($"Logged in as: {GlobalUserInfo.CurrentUser.Username} (ID: {currentUserId})", "User Info");
                }

                // Set minimum dates
                MdateTimePicker1.MinDate = DateTime.Today;
                MdateTimePicker2.MinDate = MdateTimePicker1.Value;

                // Initialize MdataGridView1 columns
                MdataGridView1.Columns.Clear();
                MdataGridView1.Columns.Add("Id", "ID");
                MdataGridView1.Columns.Add("LeaveType", "Leave Type");
                MdataGridView1.Columns.Add("StartDate", "Start Date");
                MdataGridView1.Columns.Add("EndDate", "End Date");
                MdataGridView1.Columns.Add("LeaveDays", "Leave Days");

                // Initialize MdataGridView2 columns
                MdataGridView2.Columns.Clear();
                MdataGridView2.Columns.Add("Id", "ID");
                MdataGridView2.Columns.Add("Type", "Type");
                MdataGridView2.Columns.Add("StartDate", "Start Date");
                MdataGridView2.Columns.Add("EndDate", "End Date");
                MdataGridView2.Columns.Add("BalanceDay", "Balance Day");
                MdataGridView2.Columns.Add("Reason", "Reason");
                MdataGridView2.Columns.Add("Status", "Status");

                // Add click event handler for MdataGridView2
                MdataGridView2.CellClick += dataGridView2_CellClick;

                // Add click event handlers for buttons
                Mbtnsubmit.Click += btnsubmit_Click;
                Mbtnclear.Click += btnclear_Click;
                Mbtnchosefile.Click += btnchosefile_Click;

                // Load leave types from database
                LoadLeaveTypes();

                // Load leave history ONLY for the current logged-in user
                LoadLeaveHistory(currentUserId);

                // Set default selection
                if (Mcomleavetype.Items.Count > 0)
                    Mcomleavetype.SelectedIndex = 0;
                else
                    MessageBox.Show("No leave types available.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void comleavetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLeaveTakenDays();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MdateTimePicker2.MinDate = MdateTimePicker1.Value;
            UpdateLeaveTakenDays();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateLeaveTakenDays();
        }

        private void UpdateLeaveTakenDays()
        {
            try
            {
                if (Mcomleavetype.SelectedIndex != -1 && MdateTimePicker1.Value <= MdateTimePicker2.Value)
                {
                    MdataGridView1.Rows.Clear();

                    TimeSpan duration = MdateTimePicker2.Value.Date - MdateTimePicker1.Value.Date;
                    int leaveDays = (int)duration.TotalDays + 1;

                    MdataGridView1.Rows.Add(
                        MdataGridView1.Rows.Count + 1,
                        Mcomleavetype.Text,
                        MdateTimePicker1.Value.ToShortDateString(),
                        MdateTimePicker2.Value.ToShortDateString(),
                        leaveDays
                    );

                    Mtxtleavetakendays.Text = $"Leave Taken Days: {leaveDays}";
                }
                else
                {
                    MdataGridView1.Rows.Clear();
                    Mtxtleavetakendays.Text = "Leave Taken Days: 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating leave days: " + ex.Message);
            }
        }

        private void btnaddown_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mcomleavetype.SelectedIndex == -1 || string.IsNullOrEmpty(MtextBox1.Text) || MdateTimePicker1.Value > MdateTimePicker2.Value)
                {
                    MessageBox.Show("Please fill all fields correctly and ensure Start Date is not after End Date.");
                    return;
                }

                TimeSpan duration = MdateTimePicker2.Value.Date - MdateTimePicker1.Value.Date;
                int balanceDay = (int)duration.TotalDays + 1;

                // Add to MdataGridView2 (preview before submission)
                MdataGridView2.Rows.Add(
                    MdataGridView2.Rows.Count + 1,
                        Mcomleavetype.Text,
                        MdateTimePicker1.Value.ToShortDateString(),
                    MdateTimePicker2.Value.ToShortDateString(),
                    balanceDay,
                    MtextBox1.Text,
                    "Pending"
                );

                MessageBox.Show("Leave request added to list. Click Submit to save to database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding leave: " + ex.Message);
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (MdataGridView2.Rows.Count == 0 || MdataGridView2.Rows[0].IsNewRow)
            {
                MessageBox.Show("Please click 'Add Own' first to add leave requests to the list.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Insert each row from MdataGridView2
                    foreach (DataGridViewRow row in MdataGridView2.Rows)
                    {
                        if (!row.IsNewRow && row.Cells["Type"].Value != null)
                        {
                            // Skip rows that already have an ID (already in database)
                            if (int.TryParse(row.Cells["Id"].Value?.ToString(), out int existingId) && existingId > 1000)
                            {
                                continue; // Skip existing records
                            }

                            // Get leave type ID from the combo box item that matches the type name
                            string leaveTypeName = row.Cells["Type"].Value.ToString();
                            int leaveTypeId = 0;

                            // Find the matching leave type in the combo box
                            foreach (dynamic item in Mcomleavetype.Items)
                            {
                                if (item.Name == leaveTypeName)
                                {
                                    leaveTypeId = item.Id;
                                    break;
                                }
                            }

                            if (leaveTypeId == 0)
                            {
                                MessageBox.Show($"Could not find leave type ID for: {leaveTypeName}");
                                continue;
                            }

                            string query = @"
                                INSERT INTO LeaveRequests (user_id, leave_type_id, start_date, end_date, reason, status, created_at)
                                VALUES (@user_id, @leave_type_id, @start_date, @end_date, @reason, @status, @created_at)";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@user_id", currentUserId);
                                cmd.Parameters.AddWithValue("@leave_type_id", leaveTypeId);
                                cmd.Parameters.AddWithValue("@start_date", DateTime.Parse(row.Cells["StartDate"].Value.ToString()));
                                cmd.Parameters.AddWithValue("@end_date", DateTime.Parse(row.Cells["EndDate"].Value.ToString()));
                                cmd.Parameters.AddWithValue("@reason", row.Cells["Reason"].Value.ToString());
                                cmd.Parameters.AddWithValue("@status", "Pending");
                                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    Console.WriteLine($"Successfully inserted leave request for {leaveTypeName}");
                                }
                            }
                        }
                    }
                    conn.Close();
                }

                MessageBox.Show("Leave request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLeaveHistory(currentUserId);
                ClearForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting leave request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            try
            {
                selectedRequestId = null;
                MtextBox1.Clear();
                Mtxtfilechose.Text = "No file";
                Mcomleavetype.SelectedIndex = Mcomleavetype.Items.Count > 0 ? 0 : -1;
                MdateTimePicker1.Value = DateTime.Today;
                MdateTimePicker2.Value = DateTime.Today;
                MdataGridView1.Rows.Clear();
                MdataGridView2.Rows.Clear();
                Mtxtleavetakendays.Text = "Leave Taken Days: 0";

                // Reload history after clearing
                LoadLeaveHistory(currentUserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing form: " + ex.Message);
            }
        }

        private void btnchosefile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Mtxtfilechose.Text = Path.GetFileName(openFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error choosing file: " + ex.Message);
            }
        }

        private void LoadLeaveTypes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT leave_type_id, leave_name FROM LeaveTypes ORDER BY leave_name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Mcomleavetype.Items.Clear();
                            while (reader.Read())
                            {
                                // Check for null values before reading
                                if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                                {
                                    Mcomleavetype.Items.Add(new
                                    {
                                        Id = reader.GetInt32(0),
                                        Name = reader.GetString(1)
                                    });
                                }
                            }
                        }
                    }
                }

                // Set display and value members after loading data
                Mcomleavetype.DisplayMember = "Name";
                Mcomleavetype.ValueMember = "Id";

                if (Mcomleavetype.Items.Count == 0)
                {
                    MessageBox.Show("No leave types found in database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error loading leave types: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLeaveHistory(int userId)
        {
            try
            {
                // Validate userId
                if (userId <= 0)
                {
                    MessageBox.Show("Invalid user ID. Cannot load leave history.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT lr.request_id, lt.leave_name, lr.start_date, lr.end_date, 
                               DATEDIFF(DAY, lr.start_date, lr.end_date) + 1 AS BalanceDay, 
                               lr.reason, lr.status
                        FROM LeaveRequests lr
                        INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                        WHERE lr.user_id = @user_id
                        ORDER BY lr.created_at DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            MdataGridView2.Rows.Clear();

                            while (reader.Read())
                            {
                                // Use column indices instead of names to avoid case sensitivity issues
                                MdataGridView2.Rows.Add(
                                    reader.IsDBNull(0) ? 0 : reader.GetInt32(0),                    // request_id
                                    reader.IsDBNull(1) ? "Unknown" : reader.GetString(1),          // leave_name  
                                    reader.IsDBNull(2) ? "" : reader.GetDateTime(2).ToShortDateString(),  // start_date
                                    reader.IsDBNull(3) ? "" : reader.GetDateTime(3).ToShortDateString(),  // end_date
                                    reader.IsDBNull(4) ? 0 : reader.GetInt32(4),                   // BalanceDay
                                    reader.IsDBNull(5) ? "" : reader.GetString(5),                 // reason
                                    reader.IsDBNull(6) ? "Unknown" : reader.GetString(6)           // status
                                );
                            }
                        }
                    }
                }

                // Apply status-based styling
                ApplyStatusStyling();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error loading leave history: {sqlEx.Message}\nError Number: {sqlEx.Number}",
                              "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyStatusStyling()
        {
            foreach (DataGridViewRow row in MdataGridView2.Rows)
            {
                if (!row.IsNewRow && row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();

                    switch (status.ToLower())
                    {
                        case "pending":
                            row.Cells["Status"].Style.BackColor = System.Drawing.Color.Orange;
                            row.Cells["Status"].Style.ForeColor = System.Drawing.Color.White;
                            break;
                        case "approved":
                            row.Cells["Status"].Style.BackColor = System.Drawing.Color.Green;
                            row.Cells["Status"].Style.ForeColor = System.Drawing.Color.White;
                            break;
                        case "rejected":
                            row.Cells["Status"].Style.BackColor = System.Drawing.Color.Red;
                            row.Cells["Status"].Style.ForeColor = System.Drawing.Color.White;
                            break;
                    }
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < MdataGridView2.Rows.Count && !MdataGridView2.Rows[e.RowIndex].IsNewRow)
                {
                    var row = MdataGridView2.Rows[e.RowIndex];

                    // Only allow editing of pending requests
                    string status = row.Cells["Status"].Value?.ToString() ?? "";
                    if (status.ToLower() != "pending")
                    {
                        MessageBox.Show("Only pending requests can be edited.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    selectedRequestId = Convert.ToInt32(row.Cells["Id"].Value);

                    // Find and select the matching leave type
                    string leaveTypeName = row.Cells["Type"].Value.ToString();
                    foreach (dynamic item in Mcomleavetype.Items)
                    {
                        if (item.Name == leaveTypeName)
                        {
                            Mcomleavetype.SelectedItem = item;
                            break;
                        }
                    }

                    MdateTimePicker1.Value = DateTime.Parse(row.Cells["StartDate"].Value.ToString());
                    MdateTimePicker2.Value = DateTime.Parse(row.Cells["EndDate"].Value.ToString());
                    MtextBox1.Text = row.Cells["Reason"].Value.ToString();
                    UpdateLeaveTakenDays();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting leave request: " + ex.Message);
            }
        }

        // Method to check leave balance before submission
        private bool CheckLeaveBalance(int leaveTypeId, int requestedDays)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT remaining_days 
                        FROM LeaveBalance 
                        WHERE user_id = @user_id AND leave_type_id = @leave_type_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", currentUserId);
                        cmd.Parameters.AddWithValue("@leave_type_id", leaveTypeId);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            int remainingDays = Convert.ToInt32(result);
                            return remainingDays >= requestedDays;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking leave balance: " + ex.Message);
            }
            return false;
        }

        private void Mtxt_request_Click_1(object sender, EventArgs e)
        {
            // Refresh the form
            LoadLeaveHistory(currentUserId);
        }

        // Public method to refresh data (can be called from parent form)
        public void RefreshData()
        {
            LoadLeaveHistory(currentUserId);
        }
    }
}

