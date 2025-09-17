using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leave_management_system.Security
{
    public partial class ViewsEmployee : UserControl
    {
        private string ConnectionString = @"Server=SEAM-MAI\MSIDB;Database=leave_system;Integrated Security=true;Encrypt=False";
        private int currentPage = 1;
        private int recordsPerPage = 10;
        private int totalRecords = 0;
        private int totalPages = 0;

        public ViewsEmployee()
        {
            InitializeComponent();
            InitializeEvents();
            LoadApprovedLeaveRequests();
        }

        private void InitializeEvents()
        {
            // Add event handlers for pagination buttons
            btnNext.Click += BtnNext_Click;
            btnPrevious.Click += BtnPrevious_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadApprovedLeaveRequests()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // First, get total count for pagination
                    string countQuery = @"
                        SELECT COUNT(*) 
                        FROM LeaveRequests lr
                        INNER JOIN Users u ON lr.user_id = u.user_id
                        INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                        WHERE lr.status = 'Approved'";

                    using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                    {
                        totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
                        totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
                    }

                    // Get paginated data
                    string query = @"
                        SELECT 
                            lr.request_id,
                            u.full_name,
                            lt.leave_name,
                            lr.start_date,
                            lr.end_date,
                            DATEDIFF(day, lr.start_date, lr.end_date) + 1 as no_of_days,
                            lr.reason,
                            'N/A' as attachment,
                            lr.status,
                            'View Details' as action,
                            lr.created_at,
                            lr.approver_comments,
                            approver.full_name as approver_name
                        FROM LeaveRequests lr
                        INNER JOIN Users u ON lr.user_id = u.user_id
                        INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                        LEFT JOIN Users approver ON lr.approver_id = approver.user_id
                        WHERE lr.status = 'Approved'
                        ORDER BY lr.created_at DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @RecordsPerPage ROWS ONLY";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Offset", (currentPage - 1) * recordsPerPage);
                        command.Parameters.AddWithValue("@RecordsPerPage", recordsPerPage);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Clear existing data
                            dataGridView1.Rows.Clear();

                            // Add data to DataGridView
                            foreach (DataRow row in dataTable.Rows)
                            {
                                dataGridView1.Rows.Add(
                                    row["request_id"],
                                    row["full_name"],
                                    row["leave_name"],
                                    Convert.ToDateTime(row["start_date"]).ToString("MM/dd/yyyy"),
                                    Convert.ToDateTime(row["end_date"]).ToString("MM/dd/yyyy"),
                                    row["no_of_days"],
                                    row["reason"],
                                    row["attachment"],
                                    row["status"],
                                    row["action"]
                                );
                            }

                            // Set status column color for approved requests
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Status"].Value != null &&
                                    row.Cells["Status"].Value.ToString() == "Approved")
                                {
                                    row.Cells["Status"].Style.BackColor = Color.Green;
                                    row.Cells["Status"].Style.ForeColor = Color.White;
                                }
                            }

                            // Update pagination info
                            UpdatePaginationControls();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading approved leave requests: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void UpdatePaginationControls()
        {
            lblPage.Text = $"Page {currentPage} of {totalPages} (Total: {totalRecords} records)";
            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;

            // Update button colors based on enabled state
            btnPrevious.BackColor = btnPrevious.Enabled ?
                Color.FromArgb(100, 149, 237) : Color.Gray;
            btnNext.BackColor = btnNext.Enabled ?
                Color.FromArgb(100, 149, 237) : Color.Gray;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadApprovedLeaveRequests();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadApprovedLeaveRequests();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the clicked column is the Action column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Action")
                {
                    // Get the request ID from the selected row
                    int requestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                    ShowLeaveRequestDetails(requestId);
                }
            }
        }

        private void ShowLeaveRequestDetails(int requestId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            lr.request_id,
                            u.full_name,
                            u.email,
                            u.position,
                            lt.leave_name,
                            lr.start_date,
                            lr.end_date,
                            DATEDIFF(day, lr.start_date, lr.end_date) + 1 as no_of_days,
                            lr.reason,
                            lr.status,
                            lr.created_at,
                            lr.approver_comments,
                            approver.full_name as approver_name
                        FROM LeaveRequests lr
                        INNER JOIN Users u ON lr.user_id = u.user_id
                        INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                        LEFT JOIN Users approver ON lr.approver_id = approver.user_id
                        WHERE lr.request_id = @RequestId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestId", requestId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string details = $"Approved Leave Request Details:\n\n" +
                                               $"Request ID: {reader["request_id"]}\n" +
                                               $"Employee: {reader["full_name"]}\n" +
                                               $"Email: {reader["email"]}\n" +
                                               $"Position: {reader["position"]}\n" +
                                               $"Leave Type: {reader["leave_name"]}\n" +
                                               $"Start Date: {Convert.ToDateTime(reader["start_date"]):MM/dd/yyyy}\n" +
                                               $"End Date: {Convert.ToDateTime(reader["end_date"]):MM/dd/yyyy}\n" +
                                               $"Number of Days: {reader["no_of_days"]}\n" +
                                               $"Reason: {reader["reason"]}\n" +
                                               $"Status: {reader["status"]}\n" +
                                               $"Applied Date: {Convert.ToDateTime(reader["created_at"]):MM/dd/yyyy HH:mm}\n" +
                                               $"Approved By: {reader["approver_name"] ?? "N/A"}\n" +
                                               $"Approver Comments: {reader["approver_comments"] ?? "None"}";

                                MessageBox.Show(details, "Approved Leave Request Details",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave request details: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        // Public method to refresh data
        public void RefreshData()
        {
            currentPage = 1; // Reset to first page
            LoadApprovedLeaveRequests();
        }

        // Method to get approved requests count
        public int GetApprovedRequestsCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM LeaveRequests WHERE status = 'Approved'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting approved requests count: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return 0;
            }
        }

        // Method to search approved requests
        public void SearchApprovedRequests(string searchTerm)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            lr.request_id,
                            u.full_name,
                            lt.leave_name,
                            lr.start_date,
                            lr.end_date,
                            DATEDIFF(day, lr.start_date, lr.end_date) + 1 as no_of_days,
                            lr.reason,
                            'N/A' as attachment,
                            lr.status,
                            'View Details' as action
                        FROM LeaveRequests lr
                        INNER JOIN Users u ON lr.user_id = u.user_id
                        INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                        WHERE lr.status = 'Approved' 
                        AND (u.full_name LIKE @SearchTerm 
                             OR lt.leave_name LIKE @SearchTerm 
                             OR lr.reason LIKE @SearchTerm)
                        ORDER BY lr.created_at DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Clear existing data
                            dataGridView1.Rows.Clear();

                            // Add filtered data to DataGridView
                            foreach (DataRow row in dataTable.Rows)
                            {
                                dataGridView1.Rows.Add(
                                    row["request_id"],
                                    row["full_name"],
                                    row["leave_name"],
                                    Convert.ToDateTime(row["start_date"]).ToString("MM/dd/yyyy"),
                                    Convert.ToDateTime(row["end_date"]).ToString("MM/dd/yyyy"),
                                    row["no_of_days"],
                                    row["reason"],
                                    row["attachment"],
                                    row["status"],
                                    row["action"]
                                );
                            }

                            // Update status colors
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Status"].Value != null &&
                                    row.Cells["Status"].Value.ToString() == "Approved")
                                {
                                    row.Cells["Status"].Style.BackColor = Color.Green;
                                    row.Cells["Status"].Style.ForeColor = Color.White;
                                }
                            }

                            lblPage.Text = $"Search Results: {dataTable.Rows.Count} records found";
                            btnPrevious.Enabled = false;
                            btnNext.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching approved requests: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
    }
}