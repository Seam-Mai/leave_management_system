using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace leave_management_system.Dashboard.Manager
{
    public partial class ManagerManage : UserControl
    {
        private string ConnectionString = @"Server=SEAM-MAI\MSIDB;Database=leave_system;Integrated Security=true;Encrypt=False";

        public ManagerManage()
        {
            InitializeComponent();
            SetupDataGridView(); // setup columns with Approve/Reject buttons
            LoadPendingLeaveRequests();
            MdataGridView1.CellClick += MdataGridView1_CellClick;
        }

        // Step 1: Setup DataGridView columns including buttons
        private void SetupDataGridView()
        {
            MdataGridView1.Columns.Clear();

            MdataGridView1.Columns.Add("request_id", "Request ID");
            MdataGridView1.Columns.Add("full_name", "Employee Name");
            MdataGridView1.Columns.Add("email", "Email");
            MdataGridView1.Columns.Add("leave_name", "Leave Type");
            MdataGridView1.Columns.Add("start_date", "Start Date");
            MdataGridView1.Columns.Add("end_date", "End Date");
            MdataGridView1.Columns.Add("no_of_days", "No. of Days");
            MdataGridView1.Columns.Add("reason", "Reason");
            MdataGridView1.Columns.Add("status", "Status");

            // Approve button column
            DataGridViewButtonColumn approveColumn = new DataGridViewButtonColumn();
            approveColumn.Name = "ApproveAction";
            approveColumn.HeaderText = "Approve";
            approveColumn.Text = "Approve";
            approveColumn.UseColumnTextForButtonValue = true;
            MdataGridView1.Columns.Add(approveColumn);

            // Reject button column
            DataGridViewButtonColumn rejectColumn = new DataGridViewButtonColumn();
            rejectColumn.Name = "RejectAction";
            rejectColumn.HeaderText = "Reject";
            rejectColumn.Text = "Reject";
            rejectColumn.UseColumnTextForButtonValue = true;
            MdataGridView1.Columns.Add(rejectColumn);

            MdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Step 2: Load pending leave requests
        private void LoadPendingLeaveRequests()
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

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        MdataGridView1.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            MdataGridView1.Rows.Add(
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

                    foreach (DataGridViewRow row in MdataGridView1.Rows)
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
                MessageBox.Show($"Error loading leave requests: {ex.Message}");
            }
        }

        // Step 3: Handle button clicks for Approve/Reject
        private void MdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow selectedRow = MdataGridView1.Rows[e.RowIndex];
            int requestId = Convert.ToInt32(selectedRow.Cells["request_id"].Value);
            string userEmail = selectedRow.Cells["email"].Value.ToString();

            if (MdataGridView1.Columns[e.ColumnIndex].Name == "ApproveAction")
            {
                UpdateLeaveStatus(requestId, "Pending"); // Set as Pending for Manager
                SendNotificationEmail(userEmail, "approved");
                MessageBox.Show("Leave request approved (status set to Pending).");
            }
            else if (MdataGridView1.Columns[e.ColumnIndex].Name == "RejectAction")
            {
                UpdateLeaveStatus(requestId, "Reject");
                SendNotificationEmail(userEmail, "rejected");
                MessageBox.Show("Leave request rejected and email sent to user.");
            }

            LoadPendingLeaveRequests(); // Refresh grid
        }

        // Step 4: Update status in DB
        private void UpdateLeaveStatus(int requestId, string status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE LeaveRequests SET status=@Status WHERE request_id=@RequestId";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@RequestId", requestId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating leave status: {ex.Message}");
            }
        }

        // Step 5: Send email notification
        private void SendNotificationEmail(string toEmail, string action)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("your_hr_email@domain.com");
                mail.To.Add(toEmail);
                mail.Subject = $"Leave Request {action}";
                mail.Body = $"Your leave request has been {action}.";

                SmtpClient smtp = new SmtpClient("smtp.domain.com"); 
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("your_hr_email@domain.com", "password");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}");
            }
        }
    }
}
