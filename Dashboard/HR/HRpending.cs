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

namespace leave_management_system.Dashboard.HR
{
    public partial class HRpending : UserControl
    {
        public HRpending()
        {
            InitializeComponent();
            HRLoadPendingLeaveRequests();
        }
        private string ConnectionString = @"Server=SEAM-MAI\MSIDB;Database=leave_system;Integrated Security=true;Encrypt=False";

        private void HRLoadPendingLeaveRequests()
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
                        WHERE lr.status = 'Pending'
                        ORDER BY lr.created_at DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            HRdataGridView1.Rows.Clear();

                            foreach (DataRow row in dataTable.Rows)
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

                            foreach (DataGridViewRow row in HRdataGridView1.Rows)
                            {
                                if (row.Cells["Status"].Value != null &&
                                    row.Cells["Status"].Value.ToString() == "Pending")
                                {
                                    row.Cells["Status"].Style.BackColor = Color.Orange;
                                    row.Cells["Status"].Style.ForeColor = Color.White;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading pending leave requests: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        public void RefreshData()
        {
            HRLoadPendingLeaveRequests();
        }

        public int GetPendingRequestsCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM LeaveRequests WHERE status = 'Pending'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting pending requests count: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return 0;
            }
        }

        private void HRdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (HRdataGridView1.Columns[e.ColumnIndex].Name == "Action")
                {
                    int requestId = Convert.ToInt32(HRdataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
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
                            lr.approver_comments
                        FROM LeaveRequests lr
                        INNER JOIN Users u ON lr.user_id = u.user_id
                        INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                        WHERE lr.request_id = @RequestId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestId", requestId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string details = $"Leave Request Details:\n\n" +
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
                                               $"Comments: {reader["approver_comments"] ?? "None"}";

                                MessageBox.Show(details, "Leave Request Details",
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

        private void HRPendding_Click(object sender, EventArgs e)
        {
            RefreshData();
            MessageBox.Show("Pending leave requests refreshed!", "Refresh",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

