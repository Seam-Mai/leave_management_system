using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace leave_management_system.Dashboard.HR
{
    public partial class HRMange : UserControl
    {
        private string ConnectionString = @"Server=SEAM-MAI\MSIDB;Database=leave_system;Integrated Security=true;Encrypt=False";

        public HRMange()
        {
            InitializeComponent();
            SetupDataGridView(); // Setup columns including button columns
            HRLoadPendingLeaveRequests();
            HRMdataGridView1.CellClick += HRMdataGridView1_CellClick;
        }

        // Step 1: Setup DataGridView columns
        private void SetupDataGridView()
        {
            HRMdataGridView1.Columns.Clear();

            HRMdataGridView1.Columns.Add("request_id", "Request ID");
            HRMdataGridView1.Columns.Add("full_name", "Employee Name");
            HRMdataGridView1.Columns.Add("email", "Email");
            HRMdataGridView1.Columns.Add("leave_name", "Leave Type");
            HRMdataGridView1.Columns.Add("start_date", "Start Date");
            HRMdataGridView1.Columns.Add("end_date", "End Date");
            HRMdataGridView1.Columns.Add("no_of_days", "No. of Days");
            HRMdataGridView1.Columns.Add("reason", "Reason");
            HRMdataGridView1.Columns.Add("status", "Status");

            // Approve button column
            DataGridViewButtonColumn approveColumn = new DataGridViewButtonColumn();
            approveColumn.Name = "ApproveAction";
            approveColumn.HeaderText = "Approve";
            approveColumn.Text = "Approve";
            approveColumn.UseColumnTextForButtonValue = true;
            HRMdataGridView1.Columns.Add(approveColumn);

            // Reject button column
            DataGridViewButtonColumn rejectColumn = new DataGridViewButtonColumn();
            rejectColumn.Name = "RejectAction";
            rejectColumn.HeaderText = "Reject";
            rejectColumn.Text = "Reject";
            rejectColumn.UseColumnTextForButtonValue = true;
            HRMdataGridView1.Columns.Add(rejectColumn);

            // Optional: set column widths
            HRMdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Step 2: Load leave requests
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
                            u.email,
                            lt.leave_name,
                            lr.start_date,
                            lr.end_date,
                            DATEDIFF(day, lr.start_date, lr.end_date) + 1 as no_of_days,
                            lr.reason,
                            lr.status
                        FROM LeaveRequests lr
                        INNER JOIN Users u ON lr.user_id = u.user_id
                        INNER JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                        ORDER BY lr.created_at DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        HRMdataGridView1.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            HRMdataGridView1.Rows.Add(
                                row["request_id"],
                                row["full_name"],
                                row["email"],
                                row["leave_name"],
                                Convert.ToDateTime(row["start_date"]).ToString("MM/dd/yyyy"),
                                Convert.ToDateTime(row["end_date"]).ToString("MM/dd/yyyy"),
                                row["no_of_days"],
                                row["reason"],
                                row["status"]
                            );
                        }
                    }

                    // Highlight Pending Status
                    foreach (DataGridViewRow row in HRMdataGridView1.Rows)
                    {
                        if (row.Cells["status"].Value != null && row.Cells["status"].Value.ToString() == "Pending")
                        {
                            row.Cells["status"].Style.BackColor = Color.Orange;
                            row.Cells["status"].Style.ForeColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave requests: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Step 3: Handle button clicks
        private void HRMdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow selectedRow = HRMdataGridView1.Rows[e.RowIndex];

            int requestId = Convert.ToInt32(selectedRow.Cells["request_id"].Value);
            string userEmail = selectedRow.Cells["email"].Value.ToString();

            if (HRMdataGridView1.Columns[e.ColumnIndex].Name == "ApproveAction")
            {
                UpdateLeaveStatus(requestId, "Pending");
                MessageBox.Show("Leave request approved (status set to Pending for manager).", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (HRMdataGridView1.Columns[e.ColumnIndex].Name == "RejectAction")
            {
                UpdateLeaveStatus(requestId, "Reject");
                SendRejectionEmail(userEmail);
                MessageBox.Show("Leave request rejected and email sent to user.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            HRLoadPendingLeaveRequests(); // Refresh
        }

        // Step 4: Update status in database
        private void UpdateLeaveStatus(int requestId, string status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE LeaveRequests SET status = @Status WHERE request_id = @RequestId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@RequestId", requestId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating leave status: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Step 5: Send rejection email
        private void SendRejectionEmail(string toEmail)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("your_hr_email@domain.com");
                mail.To.Add(toEmail);
                mail.Subject = "Leave Request Rejected";
                mail.Body = "Your leave request has been rejected. Please contact HR for more details.";

                SmtpClient smtp = new SmtpClient("smtp.domain.com");
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("your_hr_email@domain.com", "password");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
