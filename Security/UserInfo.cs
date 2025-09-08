using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leave_management_system.Security
{
    // User information class
    public class UserInfo
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public DateTime? LastLogin { get; set; }
    }

  
    public static class GlobalUserInfo
    {
        public static UserInfo CurrentUser { get; set; }

        public static void ClearUser()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static string GetDisplayName()
        {
            return CurrentUser?.DisplayName ?? "Guest";
        }
    }
}
