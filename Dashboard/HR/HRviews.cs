using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace leave_management_system.Dashboard.HR
{
    public partial class HRviews : UserControl
    {
        private readonly string ConnectionString = @"Server=SEAM-MAI\MSIDB;Database=leave_system;Integrated Security=true;Encrypt=False";
        private int currentPage = 1;
        private int recordsPerPage = 10;
        private int totalRecords = 0;
        private int totalPages = 0;


        public HRviews()
        {
            InitializeComponent();
            LoadApprovedRequests();
        }

        // Load Approved Leave Requests with all columns
        private void LoadApprovedRequests()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Total count for pagination
                    string countQuery = @"
                SELECT COUNT(*) 
                FROM LeaveRequests lr
                INNER JOIN Users u ON lr.user_id = u.user_id
                INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                WHERE lr.status = 'Approved'";

                    totalRecords = Convert.ToInt32(new SqlCommand(countQuery, connection).ExecuteScalar());
                    totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);

                    string query = @"
                SELECT 
                    lr.request_id,
                    u.full_name,
                    lt.leave_name,
                    lr.start_date,
                    lr.end_date,
                    DATEDIFF(day, lr.start_date, lr.end_date) + 1 AS no_of_days,
                    lr.reason,
                    'N/A' AS attachment,
                    lr.status,
                    'View Details' AS action
                FROM LeaveRequests lr
                INNER JOIN Users u ON lr.user_id = u.user_id
                INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                WHERE lr.status = 'Approved'
                ORDER BY lr.created_at DESC
                OFFSET @Offset ROWS
                FETCH NEXT @RecordsPerPage ROWS ONLY";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Offset", (currentPage - 1) * recordsPerPage);
                        command.Parameters.AddWithValue("@RecordsPerPage", recordsPerPage);

                        DataTable dt = new DataTable();
                        new SqlDataAdapter(command).Fill(dt);

                        HRdataGridView1.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            HRdataGridView1.Rows.Add(
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

                        // Set Status column color
                        int statusColumnIndex = 8; // Status column index
                        foreach (DataGridViewRow dgvRow in HRdataGridView1.Rows)
                        {
                            if (dgvRow.Cells[statusColumnIndex].Value?.ToString() == "Approved")
                            {
                                dgvRow.Cells[statusColumnIndex].Style.BackColor = Color.Green;
                                dgvRow.Cells[statusColumnIndex].Style.ForeColor = Color.White;
                            }
                        }

                        UpdatePaginationLabels();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave requests: " + ex.Message);
            }
        }


        // Search functionality
        private void SearchApprovedRequests(string searchText)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                string query = @"
                    SELECT 
                        lr.request_id,
                        lr.user_id,
                        u.full_name,
                        lr.leave_type_id,
                        lt.leave_name,
                        lr.start_date,
                        lr.end_date,
                        DATEDIFF(day, lr.start_date, lr.end_date) + 1 AS no_of_days,
                        lr.reason,
                        lr.status,
                        lr.approver_id,
                        approver.full_name AS approver_name,
                        lr.approver_comments,
                        lr.created_at
                    FROM LeaveRequests lr
                    INNER JOIN Users u ON lr.user_id = u.user_id
                    INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                    LEFT JOIN Users approver ON lr.approver_id = approver.user_id
                    WHERE lr.status = 'Approved' AND u.full_name LIKE @search
                    ORDER BY lr.created_at DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@search", SqlDbType.NVarChar).Value = "%" + searchText + "%";

                    DataTable dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);

                    HRdataGridView1.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        HRdataGridView1.Rows.Add(
                            row["request_id"],
                            row["user_id"],
                            row["full_name"],
                            row["leave_type_id"],
                            row["leave_name"],
                            Convert.ToDateTime(row["start_date"]).ToString("yyyy-MM-dd"),
                            Convert.ToDateTime(row["end_date"]).ToString("yyyy-MM-dd"),
                            row["no_of_days"],
                            row["reason"],
                            row["status"],
                            row["approver_id"],
                            row["approver_name"],
                            row["approver_comments"]
                        );
                    }

                    HRlblPage.Text = $"Search results: {dt.Rows.Count} record(s)";
                }
            }
        }

        // Show details in MessageBox
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
                MessageBox.Show("Error fetching leave request details: " + ex.Message);
            } }





        private void HRdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && HRdataGridView1.Columns[e.ColumnIndex].Name == "Action")
            {
                int requestId = Convert.ToInt32(HRdataGridView1.Rows[e.RowIndex].Cells["request_id"].Value);
                ShowLeaveRequestDetails(requestId);
            }
        }

        private void HRbtnReset_Click(object sender, EventArgs e)
        {
            HRtxtSearch.Clear();
            currentPage = 1;
            LoadApprovedRequests();
        }

        private void HRbtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadApprovedRequests();
            }
        }

        private void HRbtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadApprovedRequests();
            }
        }

        private void HRtxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = HRtxtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
                SearchApprovedRequests(searchText);
            else
            {
                currentPage = 1;
                LoadApprovedRequests();
            }
        }

        private void UpdatePaginationLabels()
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
            HRlblPage.Text = $"Page {currentPage} of {totalPages}";
            HRbtnPrevious.Enabled = currentPage > 1;
            HRbtnNext.Enabled = currentPage < totalPages;
        }
    }
}
