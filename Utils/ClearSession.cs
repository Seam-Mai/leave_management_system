using System;

namespace leave_management_system.Utils
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }
        public static int RoleId { get; set; }
        public static string Position { get; set; }
        public static string Email { get; set; }

        // Method to clear session (for logout)
        public static void ClearSession()
        {
            UserId = 0;
            Username = string.Empty;
            FullName = string.Empty;
            RoleId = 0;
            Position = string.Empty;
            Email = string.Empty;
        }

        // Method to check if user is logged in
        public static bool IsLoggedIn()
        {
            return UserId > 0 && !string.IsNullOrEmpty(Username);
        }
    }
}