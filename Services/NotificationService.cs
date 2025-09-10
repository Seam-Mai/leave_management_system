using leave_management_system.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace leave_management_system.Services
{
    public static class NotificationService
    {
        // Email configuration - Update these with your actual SMTP settings
        private static readonly string SmtpServer = "smtp.gmail.com";
        private static readonly int SmtpPort = 587;
        private static readonly string SmtpUsername = "your-email@company.com";
        private static readonly string SmtpPassword = "your-app-password";
        private static readonly string FromEmail = "noreply@company.com";

        public static void SendLeaveRequestNotification(int requestId)
        {
            try
            {
                // Get request details
                var requestDetails = GetLeaveRequestDetails(requestId);
                if (requestDetails == null) return;

                // Send notification to manager/HR
                string managerEmail = GetManagerEmail(requestDetails.UserId);
                if (!string.IsNullOrEmpty(managerEmail))
                {
                    string subject = $"New Leave Request - {requestDetails.EmployeeName}";
                    string body = CreateLeaveRequestEmailBody(requestDetails, "submitted");

                    SendEmail(managerEmail, subject, body);
                }

                // Send confirmation to employee
                if (!string.IsNullOrEmpty(requestDetails.EmployeeEmail))
                {
                    string subject = "Leave Request Submitted Successfully";
                    string body = CreateLeaveRequestEmailBody(requestDetails, "received");

                    SendEmail(requestDetails.EmployeeEmail, subject, body);
                }
            }
            catch (Exception ex)
            {
                // Log error but don't break the main flow
                System.Diagnostics.Debug.WriteLine($"Notification error: {ex.Message}");
            }
        }

        public static void SendLeaveStatusUpdateNotification(int requestId, string newStatus, string comments = "")
        {
            try
            {
                var requestDetails = GetLeaveRequestDetails(requestId);
                if (requestDetails == null) return;

                // Send notification to employee
                if (!string.IsNullOrEmpty(requestDetails.EmployeeEmail))
                {
                    string subject = $"Leave Request {newStatus} - {requestDetails.LeaveType}";
                    string body = CreateStatusUpdateEmailBody(requestDetails, newStatus, comments);

                    SendEmail(requestDetails.EmployeeEmail, subject, body);
                }

                // If approved, also notify HR for record keeping
                if (newStatus.ToLower() == "approved")
                {
                    string hrEmail = GetHREmail();
                    if (!string.IsNullOrEmpty(hrEmail))
                    {
                        string subject = $"Leave Approved - {requestDetails.EmployeeName}";
                        string body = CreateStatusUpdateEmailBody(requestDetails, newStatus, comments);

                        SendEmail(hrEmail, subject, body);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Status update notification error: {ex.Message}");
            }
        }

        private static void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                using (var client = new SmtpClient(SmtpServer, SmtpPort))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(SmtpUsername, SmtpPassword);

                    var mailMessage = new MailMessage()
                    {
                        From = new MailAddress(FromEmail, "Leave Management System"),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    };

                    mailMessage.To.Add(toEmail);

                    // Uncomment the line below when you have proper SMTP settings
                    // client.Send(mailMessage);

                    // For now, just log the email content
                    System.Diagnostics.Debug.WriteLine($"Email sent to: {toEmail}");
                    System.Diagnostics.Debug.WriteLine($"Subject: {subject}");
                    System.Diagnostics.Debug.WriteLine($"Body: {body}");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Email sending error: {ex.Message}");
            }
        }

        private static LeaveRequestDetails GetLeaveRequestDetails(int requestId)
        {
            try
            {
                string query = @"
                    SELECT 
                        lr.request_id,
                        lr.user_id,
                        u.full_name as employee_name,
                        u.email as employee_email,
                        u.position,
                        lt.leave_type_name,
                        lr.start_date,
                        lr.end_date,
                        DATEDIFF(DAY, lr.start_date, lr.end_date) + 1 as total_days,
                        lr.reason,
                        lr.status,
                        lr.created_at
                    FROM LeaveRequests lr
                    JOIN Users u ON lr.user_id = u.user_id
                    JOIN LeaveTypes lt ON lr.leave_type_id = lt.leave_type_id
                    WHERE lr.request_id = @requestId";

                SqlParameter[] parameters = {
                    new SqlParameter("@requestId", requestId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    return new LeaveRequestDetails
                    {
                        RequestId = Convert.ToInt32(row["request_id"]),
                        UserId = Convert.ToInt32(row["user_id"]),
                        EmployeeName = row["employee_name"].ToString(),
                        EmployeeEmail = row["employee_email"].ToString(),
                        Position = row["position"].ToString(),
                        LeaveType = row["leave_type_name"].ToString(),
                        StartDate = Convert.ToDateTime(row["start_date"]),
                        EndDate = Convert.ToDateTime(row["end_date"]),
                        TotalDays = Convert.ToInt32(row["total_days"]),
                        Reason = row["reason"].ToString(),
                        Status = row["status"].ToString(),
                        CreatedAt = Convert.ToDateTime(row["created_at"])
                    };
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting request details: {ex.Message}");
            }

            return null;
        }

        private static string GetManagerEmail(int employeeUserId)
        {
            try
            {
                // This assumes managers have role_id = 2
                // You might need to adjust based on your organizational structure
                string query = @"
                    SELECT TOP 1 email 
                    FROM Users 
                    WHERE role_id = 2
                    ORDER BY user_id"; // Or however you determine which manager

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0]["email"].ToString();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting manager email: {ex.Message}");
            }

            return null;
        }

        private static string GetHREmail()
        {
            try
            {
                string query = @"
                    SELECT TOP 1 email 
                    FROM Users 
                    WHERE role_id = 4
                    ORDER BY user_id";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0]["email"].ToString();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting HR email: {ex.Message}");
            }

            return null;
        }

        private static string CreateLeaveRequestEmailBody(LeaveRequestDetails details, string action)
        {
            string template = action == "submitted" ? @"
                <html>
                <body style='font-family: Arial, sans-serif;'>
                    <h2>New Leave Request</h2>
                    <p>A new leave request has been submitted and requires your approval:</p>
                    
                    <table style='border-collapse: collapse; width: 100%;'>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Employee:</td><td style='padding: 8px; border: 1px solid #ddd;'>{0}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Position:</td><td style='padding: 8px; border: 1px solid #ddd;'>{1}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Leave Type:</td><td style='padding: 8px; border: 1px solid #ddd;'>{2}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Start Date:</td><td style='padding: 8px; border: 1px solid #ddd;'>{3:dd/MM/yyyy}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>End Date:</td><td style='padding: 8px; border: 1px solid #ddd;'>{4:dd/MM/yyyy}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Total Days:</td><td style='padding: 8px; border: 1px solid #ddd;'>{5}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Reason:</td><td style='padding: 8px; border: 1px solid #ddd;'>{6}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Request Date:</td><td style='padding: 8px; border: 1px solid #ddd;'>{7:dd/MM/yyyy HH:mm}</td></tr>
                    </table>
                    
                    <p>Please review and process this request at your earliest convenience.</p>
                    
                    <p><small>This is an automated message from the Leave Management System.</small></p>
                </body>
                </html>" : @"
                <html>
                <body style='font-family: Arial, sans-serif;'>
                    <h2>Leave Request Confirmation</h2>
                    <p>Your leave request has been successfully received:</p>
                    
                    <table style='border-collapse: collapse; width: 100%;'>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Request ID:</td><td style='padding: 8px; border: 1px solid #ddd;'>{8}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Leave Type:</td><td style='padding: 8px; border: 1px solid #ddd;'>{2}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Start Date:</td><td style='padding: 8px; border: 1px solid #ddd;'>{3:dd/MM/yyyy}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>End Date:</td><td style='padding: 8px; border: 1px solid #ddd;'>{4:dd/MM/yyyy}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Total Days:</td><td style='padding: 8px; border: 1px solid #ddd;'>{5}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Status:</td><td style='padding: 8px; border: 1px solid #ddd;'>Pending Approval</td></tr>
                    </table>
                    
                    <p>Your request is now pending approval. You will be notified once a decision has been made.</p>
                    
                    <p><small>This is an automated message from the Leave Management System.</small></p>
                </body>
                </html>";

            return string.Format(template,
                details.EmployeeName,
                details.Position,
                details.LeaveType,
                details.StartDate,
                details.EndDate,
                details.TotalDays,
                details.Reason,
                details.CreatedAt,
                details.RequestId);
        }

        private static string CreateStatusUpdateEmailBody(LeaveRequestDetails details, string newStatus, string comments)
        {
            string statusColor = newStatus.ToLower() == "approved" ? "#28a745" : "#dc3545";

            string template = @"
                <html>
                <body style='font-family: Arial, sans-serif;'>
                    <h2>Leave Request Status Update</h2>
                    <p>Your leave request has been <span style='color: {0}; font-weight: bold;'>{1}</span>:</p>
                    
                    <table style='border-collapse: collapse; width: 100%;'>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Request ID:</td><td style='padding: 8px; border: 1px solid #ddd;'>{2}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Leave Type:</td><td style='padding: 8px; border: 1px solid #ddd;'>{3}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Start Date:</td><td style='padding: 8px; border: 1px solid #ddd;'>{4:dd/MM/yyyy}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>End Date:</td><td style='padding: 8px; border: 1px solid #ddd;'>{5:dd/MM/yyyy}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Total Days:</td><td style='padding: 8px; border: 1px solid #ddd;'>{6}</td></tr>
                        <tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Status:</td><td style='padding: 8px; border: 1px solid #ddd; color: {0}; font-weight: bold;'>{1}</td></tr>
                        {7}
                    </table>
                    
                    <p><small>This is an automated message from the Leave Management System.</small></p>
                </body>
                </html>";

            string commentsRow = "";
            if (!string.IsNullOrWhiteSpace(comments))
            {
                commentsRow = $"<tr><td style='font-weight: bold; padding: 8px; border: 1px solid #ddd;'>Comments:</td><td style='padding: 8px; border: 1px solid #ddd;'>{comments}</td></tr>";
            }

            return string.Format(template,
                statusColor,
                newStatus.ToUpper(),
                details.RequestId,
                details.LeaveType,
                details.StartDate,
                details.EndDate,
                details.TotalDays,
                commentsRow);
        }
    }

    public class LeaveRequestDetails
    {
        public int RequestId { get; set; }
        public int UserId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string Position { get; set; }
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalDays { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}